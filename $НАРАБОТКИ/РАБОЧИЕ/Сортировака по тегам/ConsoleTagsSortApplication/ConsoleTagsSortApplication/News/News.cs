using System;
using System.Collections.Generic;
using ConsoleTagsSortApplication.Tags;

namespace ConsoleTagsSortApplication.News
{
    public class News
    {
        public static List<News> newsAll = new List<News>();
        public List<Tag> tagsInNews = new List<Tag>();
        public string Title;
        public string Descriprion;
        public int ID;
        public News(string title, string description)
        {
            Title = title;
            Descriprion = description;
            newsAll.Add(this);
            ID = newsAll.Count - 1;

        }
        
        public static void ShowTitleAllNews()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Заголовки:");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var news in newsAll)
            {
                Console.WriteLine($"ID: {news.ID} Title: {news.Title}");
            }
        }
        public static News ShowFirstFindNews(string tag)
        {
            foreach (var news in newsAll)
            {
                foreach (var findTag in news.tagsInNews)
                {
                    if (findTag.tagName == tag) return news;
                }
            }
            return null;
        }
        public static void ShowAllFindNews(string tag)
        {
            foreach (var news in newsAll)
            {
                foreach (var findTag in news.tagsInNews)
                {
                    if (findTag.tagName == tag)
                    {
                        news.ReadActiveNews();
                    }
                        
                }
            }
        }
        public static News GetNewsForID(int id)
        {
            return newsAll[id];
        }
        public void AddTagInNews(ref Tag tag)
        {
            tagsInNews.Add(tag);
        }
        public void ShowTagsInActiveNews()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Новость: '{Title}' с тегами: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var tag in tagsInNews)
            {
                Console.WriteLine(tag.tagName);
            }
        }
        public void ReadActiveNews()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  " + Descriprion);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ID:" + ID);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
