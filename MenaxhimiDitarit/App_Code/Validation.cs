using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls;
using System.Security.Cryptography;
using MenaxhimiDitarit.App_Forms.AdminForms;

namespace MenaxhimiDitarit.App_Code
{
    public class Validation
    {
        static ToolTip toolTip = new ToolTip();
        static int language = TranslateForm.CheckLanguage();

        /// <summary>
        /// Calculates hash for password
        /// </summary>
        /// <param name="password">Password we type</param>
        /// <returns></returns>
        public static string CalculateHash(string password)
        {
            var inputBuffer = Encoding.Unicode.GetBytes(password);

            byte[] hashedBytes;
            using (var hasher = new SHA256Managed())
            {
                hashedBytes = hasher.ComputeHash(inputBuffer);
            }

            return BitConverter.ToString(hashedBytes).Replace("-", string.Empty);
        }

        /// <summary>
        /// Shows MessageBox depending on the language
        /// </summary>
        /// <param name="message">Message in English</param>
        /// <param name="title">Title in English</param>
        /// <param name="mesazhi">Message in Albanian(XK)</param>
        /// <param name="titulli">Title in Albanian(XK)</param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult MessageBoxShow(string message, string title, string mesazhi, string titulli,
            MessageBoxButtons buttons, MessageBoxIcon icon)
        {
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

        /// <summary>
        /// ToolTip to show info when hovering the picture
        /// </summary>
        /// <param name="message">Message in English</param>
        /// <param name="mesazhi">Message in Albanian(XK)</param>
        /// <param name="pictureBox"></param>
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

        /// <summary>
        /// Shows class schedule depending on selected class
        /// </summary>
        public static void ShowClassSchedule(int classNo)
        {
            ClassScheduler viewSchedule = new ClassScheduler(classNo)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            viewSchedule.ShowDialog();
        }

        /// <summary>
        /// Capitalizes word when typing in textbox
        /// </summary>
        /// <param name="textBox">The textbox we are writing</param>
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

        /// <summary>
        /// Sets the image visibility
        /// </summary>
        /// <param name="pictureBox"></param>
        public static void SetImageVisibility(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.icons8_cancel_15;
            pictureBox.Visible = true;
        }

        /// <summary>
        /// Doesn't let numbers in textbox
        /// </summary>
        /// <param name="e"></param>
        public static void NoNumber(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c))
                e.Handled = true;
        }

        /// <summary>
        /// Doesn't let letters in textbox
        /// </summary>
        /// <param name="e"></param>
        public static void NoLetter(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 32)
                e.Handled = true;
        }

        /// <summary>
        /// Checks textboxes if they are empty
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checks combobox if they are selected
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets text in radio buttons
        /// </summary>
        /// <param name="groupBox">Groupbox in wich the radio buttons are in</param>
        /// <returns></returns>
        public static string GetSelectedRBTN(GroupBox groupBox)
        {
            foreach (Control ctrl in groupBox.Controls)
            {
                if (ctrl is RadioButton && ((RadioButton)ctrl).Checked == true)
                    return ctrl.Text;
            }
            return null;
        }

        /// <summary>
        /// Checks if the textbox is valid depending on Regex
        /// </summary>
        /// <param name="reg">The regex we write</param>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsValid(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);

            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Gets age
        /// </summary>
        /// <param name="birthDate"></param>
        /// <returns></returns>
        public static int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
                age--;
            return age;
        }

        /// <summary>
        /// Saves file depending on the language
        /// </summary>
        /// <param name="fileName">Filename in English</param>
        /// <param name="emriFiles">Filename in Albanian(XK)</param>
        /// <param name="defaultExt">Default extension</param>
        /// <param name="filter">Filters the dialog</param>
        /// <returns></returns>
        public static SaveFileDialog SaveFile(string fileName, string emriFiles, string defaultExt, string filter)
        {
            if (language == 2)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    DefaultExt = defaultExt,
                    Filter = filter
                };

                return saveFileDialog;
            }
            else if (language == 1)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = emriFiles,
                    DefaultExt = defaultExt,
                    Filter = filter
                };

                return saveFileDialog;
            }
            else
            {
                return null;
            }
        }

        #region Cell Formatting

        static System.Drawing.Font italicFont = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Italic);

        /// <summary>
        /// Formats cell in GridView
        /// </summary>
        /// <param name="e"></param>
        /// <param name="columnName">Column name in English</param>
        /// <param name="emriKolones">Column name in Albanian(XK)</param>
        public static void CellFormatting(CellFormattingEventArgs e, string columnName, string emriKolones)
        {
            if (language == 2)
            {
                ToCellFormatting(e, columnName);
            }
            else if (language == 1)
            {
                ToCellFormatting(e, emriKolones);
            }
        }

        /// <summary>
        /// Formats cell when we want to print
        /// </summary>
        /// <param name="e"></param>
        /// <param name="columnName">Column name in English</param>
        /// <param name="emriKolones">Column name in Albanian(XK)</param>
        public static void PrintCellFormatting(PrintCellFormattingEventArgs e, string columnName, string emriKolones)
        {
            if (language == 2)
            {
                ToPrintCellFormatting(e, columnName);
            }
            else if (language == 1)
            {
                ToPrintCellFormatting(e, emriKolones);
            }
        }

        /// <summary>
        /// Formats the cell in ItalicFont
        /// </summary>
        /// <param name="e"></param>
        /// <param name="columnName">Column name where we want to format the cell</param>
        private static void ToCellFormatting(CellFormattingEventArgs e, string columnName)
        {
            GridDataCellElement cell = e.CellElement as GridDataCellElement;

            if (cell != null)
            {
                if (cell.ColumnInfo.Name == columnName)
                {
                    cell.Font = italicFont;
                    cell.Padding = new Padding(4);
                }
                else
                {
                    cell.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local);
                }
            }
        }

        /// <summary>
        /// Formats the cell in ItalicFont
        /// </summary>
        /// <param name="e"></param>
        /// <param name="columnName">Column name where we want to format the cell</param>
        private static void ToPrintCellFormatting(PrintCellFormattingEventArgs e, string columnName)
        {
            if (e.Column != null && e.Column.Name == columnName && e.Row is GridViewRowInfo)
            {
                e.PrintCell.Font = italicFont;
            }
        }
        #endregion

        /// <summary>
        /// Initializes the print document depending on the language
        /// </summary>
        /// <param name="printDocument"></param>
        /// <param name="header">Header in English</param>
        /// <param name="headerXK">Header in Albanian(XK)</param>
        public static void InitializePrintDocument(RadPrintDocument printDocument, string header, string headerXK)
        {
            if (language == 2)
            {
                printDocument.LeftFooter = "Page [Page #] of [Total Pages]";
                printDocument.LeftHeader = "[Time Printed]";
                printDocument.MiddleFooter = "***";
                printDocument.MiddleHeader = header;
                printDocument.RightFooter = $"Printed by: {UserSession.GetUser.UserName}";
                printDocument.RightHeader = "[Date Printed]";
            }
            else if (language == 1)
            {
                printDocument.LeftFooter = "Faqja [Page #] prej [Total Pages]";
                printDocument.LeftHeader = "[Time Printed]";
                printDocument.MiddleFooter = "***";
                printDocument.MiddleHeader = headerXK;
                printDocument.RightFooter = $"Printuar nga: {UserSession.GetUser.FullName}";
                printDocument.RightHeader = "[Date Printed]";
            }
        }
    }
}