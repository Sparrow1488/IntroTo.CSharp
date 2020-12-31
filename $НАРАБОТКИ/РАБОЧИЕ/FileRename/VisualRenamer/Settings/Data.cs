using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VisualRenamer
{
    public class Data
    {
        public static bool ModeRename = false;
        public static List<string> applyModes = new List<string>();
        public static void ShowExceptionPanel(string text, Panel exPanel)
        {
            exPanel.Visible = true;
            Control[] controls = exPanel.Controls.Find("exceptionText", true);
            if(controls.Length >= 0)
                controls[0].Text = text;
        }
        public static void ModeControl(Button button, CheckedListBox modeListBox)
        {
            if (!ModeRename)
            {
                ModeRename = true;
                modeListBox.Visible = true;
                button.BackColor = Color.Green;
            }
            else if (ModeRename)
            {
                ModeRename = false;
                modeListBox.Visible = false;
                button.BackColor = Color.Yellow;
            }
        }
        
    }
}
