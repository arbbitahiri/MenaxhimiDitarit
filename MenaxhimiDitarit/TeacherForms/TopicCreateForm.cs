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
    public partial class TopicCreateForm : Form
    {
        private readonly TopicBLL _topicBLL;
        private Topic _topics;
        private List<Topic> MyTopics;
        private bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private readonly List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private readonly List<Class> MyClasses;

        public TopicCreateForm()
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            update = false;

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MyTopics = _topicBLL.GetAll();

            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;

            dtpSelectDate.Enabled = false;
        }

        public TopicCreateForm(Topic topic)
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            _topics = topic;

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;

            update = _topics != null;
            dtpSelectDate.Enabled = false;
            PopulateForm(topic);
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
            if (CheckTextbox()) {
                Topic topic = new Topic();

                topic.TopicID = int.Parse(txtID.Text);
                topic.ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString());
                topic.SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString());
                topic.Date = dtpSelectDate.Value.Date;
                topic.Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString());
                topic.Content = txtContent.Text;
                topic.InsertBy = UserSession.GetUser.UserName;
                topic.InsertDate = DateTime.Now;
                topic.LUB = UserSession.GetUser.UserName;
                topic.LUD = DateTime.Now;

                if (!update)
                    topic.LUN++;
                else if (update)
                    topic.LUN = ++_topics.LUN;

                if (!update) {
                    var temp = MyTopics.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                    && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                    && t.Time == Convert.ToInt32(cmbSelectClass.SelectedItem.ToString())).ToList();

                    if (temp.Count > 0)
                        MessageBox.Show("Topic exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else {
                        bool isRegistred = _topicBLL.Add(topic);

                        if (isRegistred) {
                            MessageBox.Show("Topic registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    bool isUpdated = _topicBLL.Add(topic);

                    if (isUpdated) {
                        MessageBox.Show("Topic updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
