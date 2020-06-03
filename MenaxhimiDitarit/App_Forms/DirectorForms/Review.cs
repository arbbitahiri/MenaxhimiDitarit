using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        #region ErrorProvider
        ToolTip toolTip = new ToolTip();

        private void picReview_MouseHover(object sender, EventArgs e)
        {
            if (txtReview.Text == null)
            {
                toolTip.Show("Review is required!", picReview);
            }
            else if (txtReview.Text.Length < 4)
            {
                toolTip.Show("Review is to short!", picReview);
            }
        }

        private void txtReview_TextChanged(object sender, EventArgs e)
        {
            if (txtReview.Text != null && txtReview.Text.Length > 5)
                picReview.Visible = false;
            else
                picReview.Image = Properties.Resources.icons8_cancel_15;
        }
        #endregion
    }
}
