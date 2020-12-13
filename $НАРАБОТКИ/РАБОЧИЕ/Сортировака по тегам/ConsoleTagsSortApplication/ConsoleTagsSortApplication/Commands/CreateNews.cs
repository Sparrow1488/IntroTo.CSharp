using System;
using ConsoleTagsSortApplication.News;

namespace ConsoleTagsSortApplication.Commands
{
    public class CreateNews : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "new";
            if(enterCommand == myCommand)
            {
                Console.Write("Title: ");
                string createTitle = Console.ReadLine();
                Console.Write("Desc: ");
                string createDisc = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                new News.News(createTitle, createDisc).ReadActiveNews();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    public class ReadTitleAllNews : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "read all";
            if (enterCommand == myCommand)
            {
                News.News.ShowTitleAllNews();
            }
        }
    }
    public class ClearConsole : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "clear";
            if (enterCommand == myCommand)
            {
                Console.Clear();
            }
        }
    }
    public class ShowAllCommands : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "help";
            string[] arguments = enterCommand.Split(" ");
            if (enterCommand == myCommand)
            {
                foreach (var comnd in commandsAll)
                {
                    Console.Write("Command: ");
                    Console.WriteLine(comnd.myCommand);
                }
            }
            else if (arguments[0] == myCommand && arguments[1] == infoArgument)
            {
                Console.WriteLine("команда help info");
            }
            //Console.WriteLine(arguments[0] + " " + arguments[1]);
        }

    }
    public class FindNewsWithTag : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "find tag";
            if (enterCommand == myCommand)
            {
                Console.WriteLine("Введите тег: ");
                string tag = Console.ReadLine();
                Program.ActiveTag = Tags.Tag.GetTag(tag);
                News.News.ShowAllFindNews(Program.ActiveTag.tagName);
                //Program.ActiveNews = News.News.ShowFirstFindNews(Program.ActiveTag.tagName);
                //Program.ActiveNews.ReadActiveNews();
            }
        }
    }
    public class SetTag : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "set tag";
            if (enterCommand == myCommand)
            {
                Tags.Tag.ShowAllTags();
                News.News.ShowTitleAllNews();
                Console.Write("Введите ID: ");
                int id = int.Parse(Console.ReadLine());
                Program.ActiveNews = News.News.GetNewsForID(id);
                Console.WriteLine("Добавить теги: ");
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("-");
                    Console.ForegroundColor = ConsoleColor.White;
                    string tagName = Console.ReadLine();
                    if (tagName == "")
                    {
                        Program.ActiveNews.ShowTagsInActiveNews();
                        break;
                    }
                    Program.ActiveTag = Tags.Tag.GetTag(tagName);
                    Program.ActiveNews.AddTagInNews(ref Program.ActiveTag);
                }
            }
        }
    }
    public class ReadActiveNews : Command
    {
        public override void GetInfoCommand()
        {
            throw new NotImplementedException();
        }

        public override void GetMyCommand(string enterCommand)
        {
            myCommand = "read";
            if (enterCommand == myCommand)
            {
                Console.Write("ID: ");
                int idReadNews = int.Parse(Console.ReadLine());
                Program.ActiveNews = News.News.GetNewsForID(idReadNews);
                Program.ActiveNews.ReadActiveNews();
            }
        }
    }
    //TODO: добавить описание команд в консоли!

}
