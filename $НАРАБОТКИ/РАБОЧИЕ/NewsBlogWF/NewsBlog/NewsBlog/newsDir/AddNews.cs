using System;
using NewsBlog.newsDir;
using System.Windows.Forms;

namespace NewsBlog.newsDir
{
    public class AddNews : News
    {
        public AddNews(string title, string text, string athtor) : base(title, text, athtor)
        {
        }
    }
}
