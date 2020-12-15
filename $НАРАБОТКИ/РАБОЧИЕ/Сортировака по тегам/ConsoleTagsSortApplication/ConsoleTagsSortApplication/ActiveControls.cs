using System;
using ConsoleTagsSortApplication.Tags;
using ConsoleTagsSortApplication.NewsDir;

namespace ConsoleTagsSortApplication
{
    public class ActiveControls
    {
        public News ActiveNews;
        public Tag ActiveTag;
        public static string ActiveUser = Environment.MachineName;
        public static string ActiveUserName = "Valentin";
        public static string ByeName = ActiveUserName; //выводится при завешении сеанса
    }
}
