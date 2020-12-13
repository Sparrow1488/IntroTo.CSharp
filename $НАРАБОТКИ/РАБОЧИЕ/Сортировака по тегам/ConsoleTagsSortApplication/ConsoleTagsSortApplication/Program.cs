using System;
using ConsoleTagsSortApplication.Tags;

namespace ConsoleTagsSortApplication
{
    class Program
    {
        public static News.News ActiveNews;
        public static Tag ActiveTag;
        private static string ActiveUser = "User";

        static void AddAllTags()
        {
            new Sport();
            new Polityc();
            new Games();
            new Funny();
            new Science();
        }
        static void AddAllNews()
        {
            ActiveNews = new News.News("Убили негра", "Не смешно");
            new News.News("Забили гол в негра", "Почти смешно");
            new News.News("В киберпанке 2077 убрали негров", "Ахахахахах");
            new News.News("Перегрузки", "Этот метод выполняет порядковое сравнение (с учетом регистра и без учета языка и региональных параметров). Поиск начинается с позиции первого символа этой строки и продолжается до последней позиции символа. \n" +
            "Чтобы выполнить сравнение с учетом языка и региональных параметров или порядкового номера без учета регистра: ");
        }
        static void AddAllCommands()
        {
            new Commands.CreateNews();
            new Commands.ReadTitleAllNews();
            new Commands.ClearConsole();
            new Commands.FindNewsWithTag();
            new Commands.SetTag();
            new Commands.ShowAllCommands();
            new Commands.ReadActiveNews();
        }
        static void Main(string[] args)
        {
            AddAllTags();
            AddAllNews();
            AddAllCommands();
            while (true)
            {
                Console.Write($"{ActiveUser}>");
                string command = Console.ReadLine();
                foreach (var item in Commands.Command.commandsAll)
                {
                    item.GetMyCommand(command);
                }
            }
        }

    }
}
