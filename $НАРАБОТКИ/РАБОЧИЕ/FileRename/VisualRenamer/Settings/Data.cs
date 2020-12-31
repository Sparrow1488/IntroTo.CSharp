using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualRenamer
{
    public class Data
    {

        
        public static void ShowExceptionPanel(string text, Panel exPanel)
        {
            exPanel.Visible = true;
            Control[] controls = exPanel.Controls.Find("exceptionText", true);
            if(controls.Length >= 0)
                controls[0].Text = text;
        }
        
    }
}
