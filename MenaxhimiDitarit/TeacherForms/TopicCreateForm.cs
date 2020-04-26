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
        private Topics _topics;
        private readonly bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private readonly List<Subject> _subject;

        private readonly ClassBLL _classBLL;
        private readonly List<Class> _class;

        public TopicCreateForm()
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            update = false;

            _subject = _subjectBLL.GetAll();
            _class = _classBLL.GetAll();

            cmbSelectClass.DataSource = _class;
            cmbSelectSubject.DataSource = _subject;
        }

        public TopicCreateForm(Topics topic)
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            _topics = topic;

            _subject = _subjectBLL.GetAll();
            _class = _classBLL.GetAll();

            cmbSelectClass.DataSource = _class;
            cmbSelectSubject.DataSource = _subject;

            update = _topics != null;
            PopulateForm(topic);
        }

        private void PopulateForm(Topics topic)
        {
            txtID.Text = topic.TopicID.ToString();
            cmbSelectClass.SelectedItem = _class.FirstOrDefault(f => f.ClassID == topic.ClassID);
            cmbSelectSubject.SelectedItem = _subject.FirstOrDefault(f => f.SubjectID == topic.SubjectID);
            dtpSelectDate.Value = topic.Date;
            cmbSelectTime.SelectedItem = topic.Time;
            txtContent.Text = topic.Content;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Topics topic = new Topics();

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

            if (!update)
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
            else
            {
                MessageBox.Show("Topic Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
