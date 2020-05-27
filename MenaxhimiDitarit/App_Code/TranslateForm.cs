using MenaxhimiDitarit.DirectorForms;
using MenaxhimiDitarit.TeacherForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.App_Code
{
    public class TranslateForm
    {
        public static void ChangeLanguages(string langCode)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                ChangeLanguage(langCode, openForm);

                foreach (var openChildForm in openForm.MdiChildren)
                    ChangeLanguage(langCode, openChildForm);
            }
        }

        private static void ChangeLanguage(string languange, Form actualForm)
        {
            CultureInfo cultureInfo = new CultureInfo(languange);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ComponentResourceManager resources;

            if (actualForm.GetType() == typeof(AdminMain))
                resources = new ComponentResourceManager(typeof(AdminMain));

            else if (actualForm.GetType() == typeof(TeacherMain))
                resources = new ComponentResourceManager(typeof(TeacherMain));

            else
                resources = new ComponentResourceManager(typeof(DirectorMain));

            TranslateControls(actualForm.Controls, cultureInfo, resources);
        }

        private static void TranslateControls(Control.ControlCollection controls, CultureInfo cultureInfo, ComponentResourceManager resources)
        {
            foreach (Control control in controls)
            {
                //localize c# winform current winform
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

        public static void ToolStripItemTranslate(ToolStripItem item, CultureInfo cultureInfo, ComponentResourceManager resources)
        {
            if (item is ToolStripMenuItem)
            {
                var menuItem = (ToolStripMenuItem)item;
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
