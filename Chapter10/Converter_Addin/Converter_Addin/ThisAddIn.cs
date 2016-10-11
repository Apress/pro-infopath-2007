using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using InfoPath = Microsoft.Office.Interop.InfoPath;
using Office = Microsoft.Office.Core;

namespace Converter_Addin
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            if (this.Application.ActiveWindow != null)
            {
                Office.CommandBars commandBars = (Office.CommandBars)this.Application.ActiveWindow.CommandBars;
                Office.CommandBar standardBar = commandBars["Standard"];

                if (standardBar != null)
                {
                    Office.CommandBarButton converterButton = (Office.CommandBarButton)standardBar.Controls.Add(
                        Office.MsoControlType.msoControlButton, Type.Missing,
                        Type.Missing, Type.Missing, true);

                    converterButton.Caption = "Convert";
                    converterButton.Visible = true;
                    converterButton.Enabled = true;
                    converterButton.Style = Office.MsoButtonStyle.msoButtonCaption;

                    converterButton.Click += new Office._CommandBarButtonEvents_ClickEventHandler(openConverter_Click);
                }
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void openConverter_Click(Office._CommandBarButton src, ref bool Cancel)
        {
            Converter converter = new Converter();
            converter.Show();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
