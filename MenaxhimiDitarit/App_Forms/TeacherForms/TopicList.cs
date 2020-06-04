﻿using System;
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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class TopicList : Form
    {
        private readonly TopicBLL _topicBLL;
        private List<Topic> MyTopics;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public TopicList()
        {
            InitializeComponent();

            dgvTopicList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MySubjects = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = MySubjects;

            MyClasses = _classBLL.GetAll();
            cmbSelectClass.DataSource = MyClasses;
        }

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MyTopics = _topicBLL.GetAllTopic();
            dgvTopicList.DataSource = MyTopics;
        }

        //Mirren te dhenat nga rreshti i klikuar
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
                    InsertBy = (string)topicRow.Cells[8].Value,
                    InsertDate = (DateTime)topicRow.Cells[9].Value,
                    LUB = (string)topicRow.Cells[10].Value,
                    LUD = (DateTime)topicRow.Cells[11].Value,
                    LUN = (int)topicRow.Cells[12].Value
                };

                return topic;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Kerkojm te dhenat ne DataGrid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_topicBLL != null)
                {
                    if (cmbSelectSubject.SelectedIndex != -1 && cmbSelectClass.SelectedIndex != -1)
                    {
                        var findTopic = MyTopics.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                        && f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()) && f.Date == dtpSelectDay.Value.Date).ToList();

                        dgvTopicList.DataSource = findTopic;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please select a class, a subject and a day!", "Empty",
                            "Ju lutemi zgjidhni një klasë, një lëndë dhe një ditë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Topic does not exist!", "Doesn't exist",
                        "Tema nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Update te dhenat per rreshtin e klikuar ne DataGrid
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
                        TopicCreate updateTopic = new TopicCreate(topic)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateTopic.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        //Delete te dhenat per rreshtin e klikuar ne DataGrid
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
                        var result = Validation.MessageBoxShow("Are you sure you want to delete?", "Sure?",
                            "A je i/e sigurt që do ta fshini?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _topicBLL.RemoveTopic(topic.TopicID);

                            Validation.MessageBoxShow("The selected topic has been deleted successfully!", "Deleted",
                                "Tema u fshi me sukses!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
            RefreshList();
        }

        //Shikojme Content te Topic
        private void showContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTopicList.SelectedRows.Count > 0)
            {
                var row = dgvTopicList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var topic = GetTopic(dgvTopicList.Rows[row]);
                    if (topic != null)
                    {
                        Validation.MessageBoxShow($"Content: {topic.Content}", "Content",
                            $"Tema: {topic.Content}", "Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
