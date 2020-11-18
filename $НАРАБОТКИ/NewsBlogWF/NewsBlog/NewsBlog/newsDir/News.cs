using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewsBlog
{
    public abstract class News
    {
        public static List<News> NewsDBList { get; private set; } = new List<News>();
       
        public string Title { get; protected set; }
        public string Text { get; protected set; }
        public string Athtor { get; protected set; }

        public static int indexCounter = 0; 
        public static int pageCounter = indexCounter + 1; 

        public News(string title, string text)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ApplicationException(nameof(title));
            if (string.IsNullOrWhiteSpace(text)) throw new ApplicationException(nameof(text));
            Title = title;
            Text = text;

            NewsDBList.Add(this);
        }
        public static void NewsEditor(TextBox titleEdit, TextBox textEdit)
        {
            if(!string.IsNullOrWhiteSpace(titleEdit.Text)) NewsDBList[indexCounter].Title = titleEdit.Text;
            if(!string.IsNullOrWhiteSpace(textEdit.Text)) NewsDBList[indexCounter].Text = textEdit.Text;
        }
        public static void SetEditsNews(TextBox title, TextBox text)
        {
            title.Text = NewsDBList[indexCounter].Title;
            text.Text = NewsDBList[indexCounter].Text;
        }
        public static void PrintNews(TextBox title, TextBox text)
        {
            if (indexCounter < NewsDBList.Count && NewsDBList.Count!=0)
            {
                title.Text = $"{NewsDBList[indexCounter].Title}";
                text.Text = $"{NewsDBList[indexCounter].Text}";
            }
        }
        public static void ScrollNewsLeft(TextBox tit, TextBox text)
        {
            if (indexCounter <= NewsDBList.Count && indexCounter != 0)
            {
                indexCounter--;
                PrintNews(tit, text);
            }
            else
            {
                indexCounter = NewsDBList.Count - 1;
                PrintNews(tit, text);
            }
        }
        public static void ScrollNewsRight(TextBox tit, TextBox text)
        {
            if (indexCounter < (NewsDBList.Count - 1) && NewsDBList[indexCounter + 1].Title != null)
            {
                indexCounter++;
                PrintNews(tit, text);
            }
            else
            {
                indexCounter = 0;
                PrintNews(tit, text);
            }
        }
        
        public static string CheckTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title)){return title;}return "0";
        }
        public static string CheckText(string text)
        {
            if (!string.IsNullOrWhiteSpace(text)){return text;}return "0";
        }


    }
}
