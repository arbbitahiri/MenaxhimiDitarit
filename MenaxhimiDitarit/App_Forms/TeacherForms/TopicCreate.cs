using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class TopicCreate : Form
    {
        private readonly TopicBLL _topicBLL;
        private Topic _topics;
        private List<Topic> MyTopics;

        private bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> MySchedules;

        public TopicCreate()
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();
            _scheduleBLL = new ClassScheduleBLL();

            update = false;

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();
            MyTopics = _topicBLL.GetAllTopic();

            CustomizeDesign();
        }

        public TopicCreate(Topic topic)
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();
            _scheduleBLL = new ClassScheduleBLL();

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            _topics = topic;

            CustomizeDesign();

            update = _topics != null;

            PopulateForm(topic);
        }

        #region Metodat
        private void CustomizeDesign()
        {
            dtpSelectDate.Enabled = false;
            txtID.Enabled = false;
            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;
        }

        //Popullimi i TextBox-ave dhe ComboBox-ave me te dhenat nga Topic
        private void PopulateForm(Topic topic)
        {
            txtID.Text = topic.TopicID.ToString();
            cmbSelectClass.SelectedItem = MyClasses.FirstOrDefault(f => f.ClassID == topic.ClassID);
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == topic.SubjectID);
            dtpSelectDate.Value = topic.Date;
            cmbSelectTime.SelectedItem = topic.Time;
            txtContent.Text = topic.Content;
        }

        //Shikojme nese TextBox-at jane te mbushur me te dhena
        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is TextBox) {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckTextbox())
                {
                    Topic topic = new Topic();

                    topic.TopicID = int.Parse(txtID.Text);
                    topic.ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString());
                    topic.SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString());
                    topic.Date = dtpSelectDate.Value.Date;
                    topic.Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString());
                    topic.Content = txtContent.Text;
                    topic.InsertBy = UserSession.GetUser.UserName;
                    topic.LUB = UserSession.GetUser.UserName;

                    if (!update)
                        topic.LUN++;
                    else if (update)
                        topic.LUN = ++_topics.LUN;

                    //Shikojme nese Tema per klasen, lenden, oren dhe diten ekziston ne Orar
                    var checkSchedule = MySchedules.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                    && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                    && t.Day == dtpSelectDate.Value.ToString("dddd")).ToList();

                    //MessageBox.Show(dtpSelectDate.Value.ToString("dddd"));

                    if (checkSchedule.Count > 0)
                    {
                        if (!update)
                        {
                            //Shikojme nese Tema eshte shkruar me pare
                            var checkTopic = MyTopics.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                            && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                            && t.Date == DateTime.Parse(dtpSelectDate.Value.ToShortDateString())).ToList();

                            if (checkTopic.Count > 0)
                                MessageBox.Show($"Topic exists for day: {topic.Date.ToShortDateString()}",
                                    "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                bool isRegistred = _topicBLL.AddTopic(topic);

                                if (isRegistred)
                                {
                                    MessageBox.Show("Topic registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            bool isUpdated = _topicBLL.AddTopic(topic);

                            if (isUpdated)
                            {
                                MessageBox.Show("Topic updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Can't create topic for that time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!CheckTextbox())
            {
                var result = MessageBox.Show(this, "You have written something. Do you want to close?",
                    "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        ToolTip toolTip = new ToolTip();

        private void picClass_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Class is required!", picClass);
        }

        private void picSubject_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Subject is required!", picSubject);
        }

        private void picTime_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Time is required!", picTime);
        }

        private void picContent_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Content is required!", picContent);
        }

        private void cmbSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectClass.SelectedIndex != -1)
                picClass.Visible = false;
            else
                picClass.Image = Properties.Resources.icons8_cancel_15;
        }

        private void cmbSelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectSubject.SelectedIndex != -1)
                picSubject.Visible = false;
            else
                picSubject.Image = Properties.Resources.icons8_cancel_15;
        }

        private void cmbSelectTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectTime.SelectedIndex != -1)
                picTime.Visible = false;
            else
                picTime.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (txtContent.Text != null && txtContent.Text.Length > 2)
                picContent.Visible = false;
            else
                picContent.Image = Properties.Resources.icons8_cancel_15;
        }
    }
}
