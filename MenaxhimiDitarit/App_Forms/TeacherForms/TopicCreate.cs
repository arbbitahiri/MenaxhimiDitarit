using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
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
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.CheckTextbox(this))
                {
                    Topic topic = new Topic
                    {
                        TopicID = int.Parse(txtID.Text),
                        ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()),
                        SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()),
                        Date = dtpSelectDate.Value.Date,
                        Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString()),
                        Content = txtContent.Text,
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName
                    };

                    if (!update)
                        topic.LUN++;
                    else if (update)
                        topic.LUN = ++_topics.LUN;

                    //Shikojme nese Tema per klasen, lenden, oren dhe diten ekziston ne Orar
                    var checkSchedule = MySchedules.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                    && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                    && t.Day == dtpSelectDate.Value.DayOfWeek.ToString()).ToList();

                    if (checkSchedule.Count > 0)
                    {
                        if (!update)
                        {
                            //Shikojme nese Tema eshte shkruar me pare
                            var checkTopic = MyTopics.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                            && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                            && t.Date == DateTime.Parse(dtpSelectDate.Value.ToShortDateString())).ToList();

                            if (checkTopic.Count > 0)
                            {
                                Validation.MessageBoxShow($"Topic exists for day: {topic.Date.ToShortDateString()}", "Exists",
                                   $"Tema ekziston për ditën: {topic.Date.ToShortDateString()}", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bool isRegistred = _topicBLL.AddTopic(topic);

                                if (isRegistred)
                                {
                                    Validation.MessageBoxShow("Topic registered successfully!", "Registered",
                                        "Tema u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    Validation.MessageBoxShow("Registration failed!", "Error",
                                        "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            bool isUpdated = _topicBLL.AddTopic(topic);

                            if (isUpdated)
                            {
                                Validation.MessageBoxShow("Topic updated", "Updated",
                                    "Tema u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                Validation.MessageBoxShow("Update failed!", "Error",
                                    "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        Validation.MessageBoxShow("Can't create topic for that time!", "Error",
                            "Nuk mund të krijojë temë për atë kohë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        #region ErrorProvider
        private void picClass_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Class is required!", "Klasa duhet të plotësohet!", picClass);
        }

        private void picSubject_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Subject is required!", "Lënda duhet të plotësohet!", picSubject);
        }

        private void picTime_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Time is required!", "Ora duhet të plotësohet!", picTime);
        }

        private void picContent_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Content is required!", "Vërejtja duhet të plotësohet!", picContent);
        }

        private void cmbSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectClass.SelectedIndex != -1)
            {
                picClass.Visible = false;
            }
            else
            {
                picClass.Image = Properties.Resources.icons8_cancel_15;
            }
        }

        private void cmbSelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectSubject.SelectedIndex != -1)
            {
                picSubject.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picSubject);
            }
        }

        private void cmbSelectTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectTime.SelectedIndex != -1)
            {
                picTime.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picTime);
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (txtContent.Text != null && txtContent.Text.Length > 4)
            {
                picContent.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picContent);
            }
        }
        #endregion
    }
}
