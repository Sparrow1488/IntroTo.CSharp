using System;
using ConsoleTagsSortApplication.Tags;
using System.Runtime;

namespace ConsoleTagsSortApplication
{
    class Program
    {
        

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
            ActiveControls.ActiveNews = new News.News("Убили негра", "Не смешно");
            new News.News("Забили гол в негра", "Почти смешно");
            new News.News("В киберпанке 2077 убрали негров", "Ахахахахах");
            new News.News("Перегрузки", "Этот метод выполняет порядковое сравнение (с учетом регистра и без учета языка и региональных параметров). Поиск начинается с позиции первого символа этой строки и продолжается до последней позиции символа. \n" +
            "Чтобы выполнить сравнение с учетом языка и региональных параметров или порядкового номера без учета регистра: ");
        }
        static void AddAllCommands()
        {
            new Commands.CreateNews();
            new Commands.ReadCommand();
            new Commands.ClearConsole();
            new Commands.SetCommand();
            new Commands.HelpCommand();
            new Commands.UserCommand();
            new Commands.SaveCommand();
        }
        static void Main(string[] args)
        {
            AddAllTags();
            AddAllNews();
            AddAllCommands();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{ActiveControls.ActiveUser} > ");
                Console.ForegroundColor = ConsoleColor.White;

                string command = Console.ReadLine().Trim();
                string[] splitCommand = command.Split(" ");
                bool infoCommand = false;

                foreach (var word in splitCommand)
                {
                    infoCommand = bCheckedInfoCommand(word);
                }
                foreach (var getCommand in Commands.Command.commandsAll)
                {
                    if (infoCommand && getCommand.myCommand == splitCommand[0])
                        getCommand.GetInfoCommand();
                    else
                        getCommand.GetMyCommand(splitCommand);
                    
                }
            }
        }
        static bool bCheckedInfoCommand(string word)
        {
            if (word == "info") return true;
            else return false;
        }

    }
}
