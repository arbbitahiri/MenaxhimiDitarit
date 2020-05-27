using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.App_Forms.MessageBoxes
{
    public partial class OKCancel : Form
    {
        public OKCancel(string title, string description, Bitmap pictureBox)
        {
            InitializeComponent();

            lblTitle.Text = title;
            lblText.Text = description;
            picYesNo.Image = pictureBox;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
