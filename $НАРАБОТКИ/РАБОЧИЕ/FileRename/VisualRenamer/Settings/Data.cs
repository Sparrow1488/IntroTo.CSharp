using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualRenamer
{
    public abstract class Data
    {
        public static List<string> tagsList = new List<string>();

        public static void CreateStandartTags()
        {
            tagsList.Add("[Overwatch]");
            tagsList.Add("D.va");
            tagsList.Add("Mercy");
            tagsList.Add("Widowmaker");
            tagsList.Add("Brigit");
        }

        public static void ShowTags(ListBox tagsList)
        {
            tagsList.Items.Clear();
            foreach (var tag in Data.tagsList)
                tagsList.Items.Add(tag);
        }
        public static void ShowExceptionPanel(string text, Panel exPanel)
        {
            exPanel.Visible = true;
            Control[] controls = exPanel.Controls.Find("exceptionText", true);
            if(controls.Length >= 0)
                controls[0].Text = text;
        }
        public static bool HasTag(string tagName)
        {
            foreach (var tag in tagsList)
            {
                if (tag.Equals(tagName))
                    return true;
            }
            return false;
        }
    }
}
