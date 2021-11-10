using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewsBlog.autorizationDir;
using System.Drawing;

namespace NewsBlog
{
    public abstract class News
    {
        public static List<News> NewsDBList { get; private set; } = new List<News>();
       
        public string Title { get; protected set; }
        public string Text { get; protected set; }
        public string Athtor { get; protected set; }
        public Color bgCol
        {
            get
            {
                return Color.Red;
            }
            protected set { }
        }

        public static int indexCounter = 0; 

        public News(string title, string text, string athtor)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ApplicationException(nameof(title));
            if (string.IsNullOrWhiteSpace(text)) throw new ApplicationException(nameof(text));
            Title = title;
            Text = text;
            Athtor = athtor;

            NewsDBList.Add(this);
        }

        //  --ПРИМЕНЯЕМ ИЗМЕНЕНИЯ СТАТЬИ В РЕДАКТОРЕ--
        public static void NewsEditor(TextBox titleEdit, TextBox textEdit)
        {
            if(!string.IsNullOrWhiteSpace(titleEdit.Text)) NewsDBList[indexCounter].Title = titleEdit.Text;
            if(!string.IsNullOrWhiteSpace(textEdit.Text)) NewsDBList[indexCounter].Text = textEdit.Text;
        }
        //  --ЗАПОЛНЯЕМ ФОРМУ РЕДАКТОРА ЗАГОЛОВКОМ И ОПИСАНИЕМ РЕДАКТИРУЕМОЙ СТАТЬИ--
        public static void SetEditsNews(TextBox title, TextBox text)
        {
            title.Text = NewsDBList[indexCounter].Title;
            text.Text = NewsDBList[indexCounter].Text;
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
