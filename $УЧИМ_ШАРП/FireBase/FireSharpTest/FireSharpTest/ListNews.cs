using System;
using System.Collections.Generic;
using System.Text;

namespace FireSharpTest
{
    class ListNews
    {
        public string MyName = "Mega-list";
        public List<News> list = new List<News>();
        public ListNews(News a, News b)
        {
            list.Add(a);
            list.Add(b);
        }
    }
}
