using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.App_Code
{
    public class MessageDialog
    {
        static ToolTip toolTip = new ToolTip();
        static int language = TranslateForm.CheckLanguage();

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
        /// Shows a MessageBox dialog with a message, if you want to continue
        /// with the dialog or not
        /// </summary>
        /// <param name="form">The form, this MSGB dialog will appear</param>
        /// <param name="message">The message in English</param>
        /// <param name="mesazhi">The message in Albanian(XK)</param>
        public static void DoYouWantToContinue(Form form, string message, string mesazhi)
        {
            var result = MessageBoxShow($"{message} registred successfully. Do you want to continue?", "Registered",
                $"{mesazhi} u regjistrua me sukses. Doni të vazhdoni?", "U regjistrua", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result != DialogResult.Yes)
            {
                form.Close();
            }
        }

        /// <summary>
        /// Closes the form, depending on if we want
        /// </summary>
        /// <param name="form">The form we want to close</param>
        public static void CloseForm(Form form)
        {
            if (Validation.CheckTextbox(form))
            {
                var result = MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    form.Close();
            }
            else
            {
                form.Close();
            }
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

        public static void ShowHelp(Form form, string htmlPage)
        {
            Help.ShowHelp(form, @"C:\Users\Arb Tahiri\Desktop\Riinvest\Viti II\Semestri IV\TI1\Projekti TI-1\MenaxhimiDitarit\help_MenaxhimiDitarit.chm", HelpNavigator.Topic, htmlPage);
        }
    }
}
