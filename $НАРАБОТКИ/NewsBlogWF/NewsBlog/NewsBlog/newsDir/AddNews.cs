using System;
using NewsBlog.newsDir;
using System.Windows.Forms;

namespace NewsBlog.newsDir
{
    public class AddNews : News
    {
        public AddNews(string title, string text) : base(title, text)
        {

        }
        public static void SetAthtor(string nameAthtor, int indexNews)
        {
            if (!string.IsNullOrWhiteSpace(nameAthtor))
            {

            }
        }
        //public static bool AddNewsConstructor(TextBox title, TextBox text, Label exeption)
        //{
        //    exeption.Visible = false;
        //    string _title = CheckTitle(title.Text);
        //    string _text = CheckText(text.Text);
        //    if (_title != "0" && _text != "0")
        //    {
        //        AddNews newsAdd = new AddNews(_title, _text);
        //        NewsDBList.Add(newsAdd);
        //        return true;
        //    }
        //    else
        //    {
        //        exeption.Visible = true;
        //    }
        //    return false;
        //}
    }
}
