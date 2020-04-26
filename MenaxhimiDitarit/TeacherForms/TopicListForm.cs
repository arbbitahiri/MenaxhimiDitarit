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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class TopicListForm : Form
    {
        private readonly TopicBLL _topicBLL;
        private List<Topic> MyTopics;

        private readonly SubjectBLL _subjectBLL;
        private readonly List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private readonly List<Class> MyClasses;

        public TopicListForm()
        {
            InitializeComponent();

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MySubjects = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = MySubjects;

            MyClasses = _classBLL.GetAll();
            cmbSelectClass.DataSource = MyClasses;
        }

        private void RefreshList()
        {
            MyTopics = _topicBLL.GetAll();
            dgvTopicList.DataSource = MyTopics;
        }

        private Topic GetTopic(GridViewRowInfo topicRow)
        {
            try
            {
                Topic topic = new Topic
                {
                    TopicID = (int)topicRow.Cells[0].Value,
                    ClassID = (int)topicRow.Cells[1].Value,
                    SubjectID = (int)topicRow.Cells[2].Value,
                    Date = (DateTime)topicRow.Cells[3].Value,
                    Time = (int)topicRow.Cells[4].Value,
                    Content = (string)topicRow.Cells[5].Value,
                    InsertBy = (string)topicRow.Cells[6].Value,
                    InsertDate = (DateTime)topicRow.Cells[7].Value,
                    LUB = (string)topicRow.Cells[8].Value,
                    LUD = (DateTime)topicRow.Cells[9].Value,
                    LUN = (int)topicRow.Cells[10].Value
                };

                return topic;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void TopicListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_topicBLL != null)
            {
                if (cmbSelectSubject.SelectedIndex != -1 && cmbSelectClass.SelectedIndex != -1)
                {
                    var findTopic = MyTopics.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()) && f.Date == dtpSelectDay.Value.Date).ToList();

                    dgvTopicList.DataSource = findTopic;
                }
                else
                    MessageBox.Show("Please select a class, a subject and a day!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Topic does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTopicList.SelectedRows.Count > 0)
            {
                var row = dgvTopicList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var topic = GetTopic(dgvTopicList.Rows[row]);
                    if (topic != null)
                    {
                        TopicCreateForm updateTopic = new TopicCreateForm(topic);
                        updateTopic.StartPosition = FormStartPosition.CenterParent;
                        updateTopic.ShowDialog();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTopicList.SelectedRows.Count > 0)
            {
                var row = dgvTopicList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var topic = GetTopic(dgvTopicList.Rows[row]);
                    if (topic != null)
                    {
                        if (MessageBox.Show($"Are you sure you want to delete?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _topicBLL.Remove(topic.TopicID);
                            MessageBox.Show("The selected topic has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
