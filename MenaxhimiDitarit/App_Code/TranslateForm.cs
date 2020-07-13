using MenaxhimiDitarit.DirectorForms;
using MenaxhimiDitarit.TeacherForms;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.App_Code
{
    public class TranslateForm
    {
        public static int checkLanguage = 0;
        /// <summary>
        /// Checks the language
        /// </summary>
        /// <returns>If it's English it returns 1, Albanian(XK) returns 2, else 0</returns>
        public static int CheckLanguage()
        {
            if (checkLanguage == 1)
            {
                return 1;
            }
            else if (checkLanguage == 2)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Changes the language
        /// </summary>
        /// <param name="langCode">Language code</param>
        public static void ChangeLanguages(string langCode)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                ChangeLanguage(langCode, openForm);

                foreach (var openChildForm in openForm.MdiChildren)
                    ChangeLanguage(langCode, openChildForm);
            }

            if (langCode == "sq-XK")
            {
                checkLanguage = 1;
            }
            else if (langCode == "en-UK")
            {
                checkLanguage = 2;
            }
            else
            {
                checkLanguage = 0;
            }
        }

        /// <summary>
        /// Changes the language of the form
        /// </summary>
        /// <param name="languange">The language we type</param>
        /// <param name="actualForm">The form we want to change the language</param>
        private static void ChangeLanguage(string languange, Form actualForm)
        {
            CultureInfo cultureInfo = new CultureInfo(languange);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ComponentResourceManager resources;

            if (actualForm.GetType() == typeof(AdminMain))
            {
                resources = new ComponentResourceManager(typeof(AdminMain));
            }
            else if (actualForm.GetType() == typeof(TeacherMain))
            {
                resources = new ComponentResourceManager(typeof(TeacherMain));
            }
            else
                resources = new ComponentResourceManager(typeof(DirectorMain));

            TranslateControls(actualForm.Controls, cultureInfo, resources);
        }

        /// <summary>
        /// Translates controls in form
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="cultureInfo"></param>
        /// <param name="resources"></param>
        private static void TranslateControls(Control.ControlCollection controls, CultureInfo cultureInfo, ComponentResourceManager resources)
        {
            foreach (Control control in controls)
            {
                if (control.Controls.Count > 0) TranslateControls(control.Controls, cultureInfo, resources);
                if (control is ToolStrip)
                {
                    foreach (ToolStripItem item in ((ToolStrip)control).Items)
                    {
                        string text = resources.GetString(item.Name + ".Text", cultureInfo);
                        if (text != null)
                            item.Text = text;

                        ToolStripItemTranslate(item, cultureInfo, resources);

                    }
                }
                else if (control is DataGridView)
                {
                    foreach (DataGridViewColumn dataGridViewColumn in ((DataGridView)control).Columns)
                    {
                        string text = resources.GetString(dataGridViewColumn.Name + ".HeaderText", cultureInfo);
                        if (text != null)
                        {
                            dataGridViewColumn.HeaderText = text;
                            control.Text = text;
                        }
                    }
                }
                else if (control is RadGridView)
                {
                    foreach (GridViewColumn dataGridViewColumn in ((RadGridView)control).Columns)
                    {
                        string text = resources.GetString(dataGridViewColumn.Name + ".HeaderText", cultureInfo);
                        if (text != null)
                        {
                            dataGridViewColumn.HeaderText = text;
                            control.Text = text;
                        }
                    }
                }
                else
                {
                    if (control.Name == "") return;
                    string text = resources.GetString(control.Name + ".Text", cultureInfo);
                    if (text != null)
                        control.Text = text;
                }
            }
        }

        /// <summary>
        /// Translates the tool strip items
        /// </summary>
        /// <param name="item"></param>
        /// <param name="cultureInfo"></param>
        /// <param name="resources"></param>
        public static void ToolStripItemTranslate(ToolStripItem item, CultureInfo cultureInfo, ComponentResourceManager resources)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                foreach (ToolStripItem toolStripItem in menuItem.DropDown.Items)
                {
                    string text = resources.GetString(toolStripItem.Name + ".Text", cultureInfo);
                    if (text != null)
                        toolStripItem.Text = text;

                    ToolStripItemTranslate(toolStripItem, cultureInfo, resources);
                }
            }
        }
    }
}
