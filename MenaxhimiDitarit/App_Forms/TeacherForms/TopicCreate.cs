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

            MyTopics = _topicBLL.GetAll();

            CostumizeDesign();
        }

        public TopicCreate(Topic topic)
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            _topics = topic;

            CostumizeDesign();

            update = _topics != null;

            PopulateForm(topic);
        }

        private void CostumizeDesign()
        {
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            dtpSelectDate.Enabled = false;
            txtID.Enabled = false;
            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;
        }

        private void PopulateForm(Topic topic)
        {
            txtID.Text = topic.TopicID.ToString();
            cmbSelectClass.SelectedItem = MyClasses.FirstOrDefault(f => f.ClassID == topic.ClassID);
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == topic.SubjectID);
            dtpSelectDate.Value = topic.Date;
            cmbSelectTime.SelectedItem = topic.Time;
            txtContent.Text = topic.Content;
        }

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

                    var checkSchedule = MySchedules.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                    && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                    && t.Day == dtpSelectDate.Value.ToString("dddd")).ToList();

                    if (checkSchedule.Count > 0)
                    {
                        if (!update)
                        {
                            var checkTopic = MyTopics.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                            && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                            && t.Date == DateTime.Parse(dtpSelectDate.Value.ToShortDateString())).ToList();

                            if (checkTopic.Count > 0)
                                MessageBox.Show($"Topic exists for day: {topic.Date.ToShortDateString()}", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                bool isRegistred = _topicBLL.Add(topic);

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
                            bool isUpdated = _topicBLL.Add(topic);

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
                MessageBox.Show($"There has been a problem.\n{ex.Message}", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
