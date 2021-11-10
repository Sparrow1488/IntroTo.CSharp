using System;
using NewsBlog.newsDir;
using System.Windows.Forms;

namespace NewsBlog.newsDir
{
    public class DefaultNews : News
    {
        public DefaultNews(string title, string text, string athtor) : base(title, text, athtor)
        {
        }
    }
}
