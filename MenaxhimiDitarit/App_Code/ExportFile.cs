﻿using System;
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
using System.Threading;

namespace MenaxhimiDitarit.App_Code
{
    public class ExportFile
    {
        static int language = TranslateForm.CheckLanguage();

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

        public static void ExportExcel(string fileName, string emriFiles, string defaultExt, string filter, RadGridView gridView)
        {
            Thread thread = new Thread(() =>
            {
                var saveFileDialog = Validation.SaveFile(fileName, emriFiles, defaultExt, filter);

                saveFileDialog.ShowDialog();

                ExportToExcel(gridView, saveFileDialog.FileName, fileName, emriFiles);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        public static void ExportPDF(string fileName, string emriFiles, string defaultExt, string filter, RadGridView gridView)
        {
            Thread thread = new Thread(() =>
            {
                var saveFileDialog = Validation.SaveFile(fileName, emriFiles, defaultExt, filter);

                saveFileDialog.ShowDialog();

                ExportToPDF(gridView, saveFileDialog.FileName);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
