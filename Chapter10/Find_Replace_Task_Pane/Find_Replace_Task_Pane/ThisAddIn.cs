using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using InfoPath = Microsoft.Office.Interop.InfoPath;
using Office = Microsoft.Office.Core;

namespace Find_Replace_Task_Pane
{
    public partial class ThisAddIn
    {
        private TaskPane tp;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            tp = new TaskPane();
            CustomTaskPanes.Add(tp, "Task Pane");
            CustomTaskPanes[0].Visible = true; 
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
