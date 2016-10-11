using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Find_Replace_Task_Pane
{
    public partial class TaskPane : UserControl
    {
        public TaskPane()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string find = txtFind.Text;
            string replace = txtReplace.Text;
            InfoPath.Application app = Globals.ThisAddIn.Application;
            IXMLDOMNodeList nodes = app.ActiveWindow.XDocument.DOM.documentElement.selectNodes("/descendant::*");
            foreach (IXMLDOMNode node in nodes)
            {
                if (node.nodeType == DOMNodeType.NODE_ELEMENT)
                {
                    if (node.childNodes.length == 1)
                    {
                        string tmpValue = node.text;
                        if (tmpValue.Length > 0)
                            node.text = tmpValue.Replace(find, replace);
                    }
                }
            }
        }
    }
}
