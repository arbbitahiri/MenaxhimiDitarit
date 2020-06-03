using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.App_Code
{
    public class Validation
    {
        static ToolTip toolTip = new ToolTip();

        public static DialogResult MessageBoxShow(string message, string title, string mesazhi, string titulli,
            MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            int language = TranslateForm.CheckLanguage();

            if (language == 2)
            {
                return MessageBox.Show(message, title, buttons, icon);
            }
            else if (language == 1)
            {
                return MessageBox.Show(mesazhi, titulli, buttons, icon);
            }
            else
                return MessageBox.Show("null");
        }

        public static void ToolTipShow(string message, string mesazhi, PictureBox pictureBox)
        {
            int language = TranslateForm.CheckLanguage();

            if (language == 2)
            {
                toolTip.Show(message, pictureBox);
            }
            else if (language == 1)
            {
                toolTip.Show(mesazhi, pictureBox);
            }
        }

        public static void NoNumber(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c))
                e.Handled = true;
        }

        public static void NoLetter(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 32)
                e.Handled = true;
        }

        public static bool CheckTextbox(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
        }

        public static bool CheckComboBox(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ctrl as ComboBox;
                    if (cmb.SelectedIndex > -1)
                        return true;
                }
            }
            return false;
        }

        public static string GetSelectedRBTN(GroupBox groupBox)
        {
            foreach (Control ctrl in groupBox.Controls)
            {
                if (ctrl is RadioButton && ((RadioButton)ctrl).Checked == true)
                    return ctrl.Text;
            }
            return null;
        }

        public static bool IsValid(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);

            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }

        public static void Capitalize(TextBox textBox)
        {
            StringBuilder stringBuilder = new StringBuilder(textBox.Text.Length);
            bool capitalize = true;
            foreach (char c in textBox.Text)
            {
                stringBuilder.Append(capitalize ? char.ToUpper(c) : char.ToLower(c));
                capitalize = !char.IsLetter(c);
            }
            textBox.Text = stringBuilder.ToString();
            textBox.Select(textBox.Text.Length, 0);
        }

        public static void SetImageVisibility(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.icons8_cancel_15;
            pictureBox.Visible = true;
        }

        public static int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
                age--;
            return age;
        }
    }
}
