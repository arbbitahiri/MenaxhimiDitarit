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
        ToolTip toolTip = new ToolTip();

        public Review()
        {
            InitializeComponent();
        }

        private void picReview_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Class is required!", picReview);
        }

        private void txtReview_TextChanged(object sender, EventArgs e)
        {
            if (txtReview.Text != null && txtReview.Text.Length > 2)
                picReview.Visible = false;
            else
                picReview.Image = Properties.Resources.icons8_cancel_15;
        }
    }
}
