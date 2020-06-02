using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class CommentList : Form
    {
        private readonly TopicBLL _commentBLL;
        private List<Topic> MyComments;

        public CommentList()
        {
            InitializeComponent();

            _commentBLL = new TopicBLL();
        }

        private void RefreshList()
        {
            MyComments = _commentBLL.GetAllComment();
            dgvCommentList.DataSource = MyComments;
        }

        private void CommentList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
