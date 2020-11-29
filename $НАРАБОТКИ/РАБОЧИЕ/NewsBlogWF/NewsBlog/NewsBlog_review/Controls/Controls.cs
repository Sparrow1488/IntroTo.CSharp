using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsBlog_review.Controls
{
    public class Controls<T>
        where T: TextBox
    {
        public static News PrintNews(T title, T text, Label athtor)
        {
            title.Text = News.newsBase[News.indexCounter].Title;
            title.ForeColor = News.newsBase[News.indexCounter].ForeColorTitle;
            text.Text = News.newsBase[News.indexCounter].Text;
            athtor.Text = News.newsBase[News.indexCounter].Athtor;
            return News.newsBase[News.indexCounter];
        }
        public static void ScrollNewsRight(T title, T text, Label athtor)
        {
            if (News.indexCounter < (News.newsBase.Count - 1) && News.newsBase[News.indexCounter + 1].Title != null)
            {
                News.indexCounter++;
                PrintNews(title, text, athtor);
            }
            else
            {
                News.indexCounter = 0;
                PrintNews(title, text, athtor);
            }
        }
        public static void ScrollNewsLeft(T title, T text, Label athtor)
        {
            if (News.indexCounter <= News.newsBase.Count && News.indexCounter != 0)
            {
                News.indexCounter--;
                PrintNews(title, text, athtor);
            }
            else
            {
                News.indexCounter = News.newsBase.Count - 1;
                PrintNews(title, text, athtor);
            }
        }
    }
}
