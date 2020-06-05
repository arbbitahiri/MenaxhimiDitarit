using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using Telerik.WinControls;
using System.Security.Cryptography;
using System.Collections.Generic;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Linq;

namespace MenaxhimiDitarit.App_Code
{
    public class Validation
    {
        static ToolTip toolTip = new ToolTip();
        static int language = TranslateForm.CheckLanguage();

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

        public static int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
                age--;
            return age;
        }

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

        private static void ToPrintCellFormatting(PrintCellFormattingEventArgs e, string columnName)
        {
            if (e.Column != null && e.Column.Name == columnName && e.Row is GridViewRowInfo)
            {
                e.PrintCell.Font = italicFont;
            }
        }
        #endregion

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

        #region Export
        public static void ExportToExcel(RadGridView radGridView, string filePath, string sheetName, string sheetNameXK)
        {
            if (language == 2)
            {
                ToExcel(radGridView, filePath, sheetName);
            }
            else if (language == 1)
            {
                ToExcel(radGridView, filePath, sheetNameXK);
            }
        }

        private static void ToExcel(RadGridView radGridView, string filePath, string sheetName)
        {
            if (radGridView.Rows.Count > 0)
            {
                object missingValue = Missing.Value;

                Excel._Application xlApp = new Excel.Application();
                Excel._Workbook xlBook = xlApp.Workbooks.Add(missingValue);
                Excel._Worksheet xlSheet = null;

                xlApp.Visible = false;

                xlSheet = xlBook.Sheets["Sheet1"];
                xlSheet = xlBook.ActiveSheet;
                xlSheet.Name = sheetName;

                for (int i = 1; i < radGridView.Columns.Count + 1; i++)
                {
                    xlSheet.Cells[1, i] = radGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < radGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < radGridView.Columns.Count; j++)
                    {
                        xlSheet.Cells[i + 2, j + 1] = radGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                xlBook.SaveAs(filePath, missingValue, missingValue, missingValue, missingValue, missingValue,
                    Excel.XlSaveAsAccessMode.xlExclusive, missingValue, missingValue, missingValue, missingValue, missingValue);

                xlApp.Quit();
            }
        }

        public static void ExportToPDF(RadGridView radGridView, string filePath)
        {
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(radGridView.Columns.Count);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font textFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);

            foreach (GridViewDataColumn column in radGridView.Columns)
            {
                PdfPCell pdfCell = new PdfPCell(new Phrase(column.HeaderText, textFont))
                {
                    BackgroundColor = new BaseColor(240, 240, 240)
                };
                pdfTable.AddCell(pdfCell);
            }

            foreach (GridViewDataRowInfo row in radGridView.Rows)
            {
                foreach (GridViewCellInfo cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), textFont));
                }
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDocument, fileStream);
                pdfDocument.Open();
                pdfDocument.Add(pdfTable);
                pdfDocument.Close();
            }
        }
        #endregion
    }
}