using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsBlog_review.UserControls;

namespace NewsBlog_review
{
    public abstract class News
    {
        public static int indexCounter { get; set; } = 0;

        public static List<News> newsBase = new List<News>();
        public string Title { get; set; }
        public string Text { get; set; }
        public string Athtor { get; set; }
        public News(string title, string text)
        {
            Title = CheckTitle(title);
            Text = CheckText(text);
            if (MyUser.ActiveUser.Login == null)
            {
                Athtor = "Anon";
            }
            else Athtor = "Anon";
            newsBase.Add(this);
        }
        private static string CheckTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ApplicationException("Пустой заголовок!");
            return title;
        }
        private static string CheckText(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) throw new ApplicationException("Пустой текст!");
            return text;
        }
    }
}
