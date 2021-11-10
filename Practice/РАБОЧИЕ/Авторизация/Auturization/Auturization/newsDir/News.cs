using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auturization
{
    public class News
    {
        public static string[,] newsDataBase { get; private set; } =
            {
                { "Title 1", "News 1"},
                { "Title 2", "News 2"},
                { "Title 3", "News 3"},
                { "Title 4", "News 4"}
            };

        public static void AddNews(Label titleText, Label textText, string title, string text)
        {
            string _title = CheckTitle(title);
            string _text = CheckText(text);
            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(text))
            {
                titleText.Text = _title;
                textText.Text = _text;
            }
        }

        private static string CheckTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                return title;
            }
            return "Enter_title";
        }

        private static string CheckText(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                return text;
            }
            return "Enter_text";
        }

    }
}
