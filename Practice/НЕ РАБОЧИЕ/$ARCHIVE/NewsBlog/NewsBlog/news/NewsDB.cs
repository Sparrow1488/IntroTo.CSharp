using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.news
{
    public static class NewsDB
    {
        private static List<string> _dbNews = new List<string>();

        public static void AddNews(string news)
        {
            if (!string.IsNullOrWhiteSpace(news))
            {
                _dbNews.Add(news);
            }
        }
        public static void PrintNews(int count)
        {
            if(count <= _dbNews.Count)
            {
                _dbNews.Reverse();
                for (int i = 0; i < count ; i++)
                {
                    Console.WriteLine(_dbNews[i]);
                }
            }
        }
        public static void PrintNews()
        {
             _dbNews.Reverse();
             for (int i = 0; i < _dbNews.Count; i++)
             {
                 Console.WriteLine(_dbNews[i]);
             }
        }
    }
}
