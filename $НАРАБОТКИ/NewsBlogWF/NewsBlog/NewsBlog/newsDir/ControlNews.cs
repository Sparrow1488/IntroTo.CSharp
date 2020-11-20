using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsBlog.newsDir
{
    public class ControlNews
    {
        public static void ScrollNewsLeft(TextBox tit, TextBox text, TextBox athtor)
        {
            if (News.indexCounter <= News.NewsDBList.Count && News.indexCounter != 0)
            {
                News.indexCounter--;
                PrintNews(tit, text, athtor);
            }
            else
            {
                News.indexCounter = News.NewsDBList.Count - 1;
                PrintNews(tit, text, athtor);
            }
        }
        public static void ScrollNewsRight(TextBox tit, TextBox text, TextBox athtor)
        {
            if (News.indexCounter < (News.NewsDBList.Count - 1) && News.NewsDBList[News.indexCounter + 1].Title != null)
            {
                News.indexCounter++;
                PrintNews(tit, text, athtor);
            }
            else
            {
                News.indexCounter = 0;
                PrintNews(tit, text, athtor);
            }
        }
        public static void PrintNews(TextBox title, TextBox text)
        {
            if (News.indexCounter < News.NewsDBList.Count && News.NewsDBList.Count != 0)
            {
                title.Text = $"{News.NewsDBList[News.indexCounter].Title}";
                text.Text = $"{News.NewsDBList[News.indexCounter].Text}";
            }
        }
        public static void PrintNews(TextBox title, TextBox text, TextBox athtor)
        {
            if (News.indexCounter < News.NewsDBList.Count && News.NewsDBList.Count != 0)
            {
                title.Text = $"{News.NewsDBList[News.indexCounter].Title}";
                text.Text = $"{News.NewsDBList[News.indexCounter].Text}";
                athtor.Text = $"{News.NewsDBList[News.indexCounter].Athtor}";
            }
        }

    }
}
