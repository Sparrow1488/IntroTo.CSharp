using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsBlog_review.UserControls;
using System.Drawing;
using System.Windows.Forms;

namespace NewsBlog_review
{
    public abstract class News
    {
        public static int indexCounter { get; set; } = 0;

        public static List<News> newsBase = new List<News>();
        public string Title { get; set; }
        public string Text { get; set; }
        public string Athtor { get; set; }
        public Color ForeColorTitle { get; set; } = Color.Black;
        public News(string title, string text)
        {
            Title = CheckTitle(title);
            Text = CheckText(text);
            if (MyUser<Label>.ActiveUser.Login == null)
            {
                Athtor = "Anon";
            }
            else Athtor = "Anon";
            newsBase.Add(this);
        }
        public static News GetNews()
        {
            return newsBase[indexCounter];
        }
        public static void SetEditNews(News editNews)
        {
            newsBase[indexCounter] = editNews;
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
