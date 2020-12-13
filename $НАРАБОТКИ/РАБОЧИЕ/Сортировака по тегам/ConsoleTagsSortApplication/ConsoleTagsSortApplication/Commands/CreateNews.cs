using System;
using ConsoleTagsSortApplication.News;
using ConsoleTagsSortApplication.Tags;
using System.IO;

namespace ConsoleTagsSortApplication.Commands
{
    public class CreateNews : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + "?Создать новость");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "new";
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
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
    public class ReadCommand : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + "             ?Читать все новости");
            Console.WriteLine(myCommand + " + id -> 'id'?Найти и читать новость по id");
            Console.WriteLine(myCommand + " + 'id'      ?Читать новость по id");
            Console.WriteLine(myCommand + " + 'tag'     ?Читать новость по тегу");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "read"; //id, 'id'
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
            {
                News.News.ShowTitleAllNews();
            }
            else if(enterCommand[0] == myCommand && int.TryParse(enterCommand[1], out int result))
            {
                ActiveControls.ActiveNews = News.News.GetNewsForID(result);
                ActiveControls.ActiveNews?.ReadActiveNews();
            }
            else if (enterCommand[0] == myCommand && enterCommand[1] == "id")
            {
                Console.Write("ID: ");
                int idReadNews = int.Parse(Console.ReadLine());
                ActiveControls.ActiveNews = News.News.GetNewsForID(idReadNews);
                ActiveControls.ActiveNews?.ReadActiveNews();
            }
            else if (enterCommand[0] == myCommand && enterCommand[1] == "tag" && enterCommand.Length == 2)
            {
                Console.Write("Введите тег: ");
                string tag = Console.ReadLine();
                ActiveControls.ActiveTag = Tag.GetTag(tag);
                if (ActiveControls.ActiveTag == null) Console.WriteLine("Тег не найден");
                else News.News.ShowAllFindNews(ActiveControls.ActiveTag.tagName);
            }
        }
    }
    public class ClearConsole : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + "?Очистить консоль");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "clear";
            if (enterCommand[0] == myCommand)
            {
                Console.Clear();
            }
        }
    }
    public class HelpCommand : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + "?Команда для вывода всех команд.");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "help";
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
            {
                foreach (var comnd in commandsAll)
                {
                    Console.Write("Command: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(comnd.myCommand);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }
    public class SetCommand : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + tag -> []'tags'?Задать теги новости по id");
        }
        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "set"; //tag
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
                GetInfoCommand();
            else if (enterCommand[0] == myCommand && enterCommand[1] == "tag")
            {
                EnterIdAndGetNews();
                Console.WriteLine("Добавить теги: ");
                while (true) //TODO: возможно повторение тегов, при добавлении
                {
                    Console.Write("+");
                    string tagName = Console.ReadLine();
                    if (SaveEnterTagsAndExit(tagName)) break;
                    SetTagForNews(tagName);
                }
            }
        }
        private static bool SaveEnterTagsAndExit(string tag)
        {
            if (tag == "")
            {
                Console.WriteLine("save");
                ActiveControls.ActiveNews.ShowTagsActiveNews();
                return true;
            }
            return false;
        }
        private static void SetTagForNews(string tagEnter)
        {
            if (!bCheckIdInActiveNews(tagEnter))
            {
                foreach (var tag in Tag.tagsAll)
                {
                    if (tagEnter == tag.tagName)
                    {
                        ActiveControls.ActiveTag = Tag.GetTag(tagEnter);
                        ActiveControls.ActiveNews.AddTagInNews(ref ActiveControls.ActiveTag);
                    }
                }
            }
            else if (bCheckIdInActiveNews(tagEnter)) Console.WriteLine("Тег уже добавлен!");
        }
        private static void EnterIdAndGetNews()
        {
            Console.Write("Введите ID новости: ");
            if(int.TryParse(Console.ReadLine(), out int id))
                ActiveControls.ActiveNews = News.News.GetNewsForID(id);
            else Console.WriteLine("Ошибка формата!");
        }
        private static bool bCheckIdInActiveNews(string enterTag)
        {
            foreach (var tag in ActiveControls.ActiveNews.tagsInNews)
            {
                if (enterTag == tag.tagName) return true;
            }
            return false;
        }
    }
    public class UserCommand : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + set + login -> 'login'?Изменить логин");
            Console.WriteLine(myCommand + " + set + name -> 'name'  ?Изменить имя");
            Console.WriteLine(myCommand + " + get + i            ?Получить информацию о ползьователе");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "user"; //set-login, set-name, get-info
            if (enterCommand.Length == 1 && enterCommand[0] == myCommand)
                GetInfoCommand();
            else if (enterCommand[0] == myCommand && enterCommand[1] == "set")
            {
                if (enterCommand[2] == "login") SetLogin();
                else if (enterCommand[2] == "name") SetName();
            }
            else if (enterCommand[0] == myCommand && enterCommand[1] == "get")
            {
                if (enterCommand[2] == "i") GetInfo();
            }
        }
        private static void SetLogin()
        {
            Console.WriteLine("Введите новый логин: ");
            string newLogin = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newLogin))
                ActiveControls.ActiveUser = newLogin;
            else Console.WriteLine("Ошибка написания");
        }
        private static void SetName()
        {
            Console.WriteLine("Введите ваше имя: ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
                ActiveControls.ActiveUserName = newName;
            else Console.WriteLine("Ошибка написания");
        }
        private static void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("L:" + ActiveControls.ActiveUser);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("N:" + ActiveControls.ActiveUserName);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class SaveCommand : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + id -> 'id' -> 'path'?Сохранить новость по id");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "save"; //save-news
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
                GetInfoCommand();
            else if(enterCommand[0] == myCommand && enterCommand[1] == "id" && enterCommand.Length == 2)
            {
                Console.Write("Введите ID: ");
                if(int.TryParse(Console.ReadLine(), out int id))
                {
                    ActiveControls.ActiveNews = News.News.GetNewsForID(id);
                    ActiveControls.ActiveNews.ReadActiveNews();
                    Console.WriteLine("Save? (Y/N)");
                    string chooseSave = Console.ReadLine();
                    if(chooseSave == "Y")
                    {
                        Console.WriteLine("Path: ");
                        string path = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(path))
                        {
                            using (var sw = new StreamWriter(path + ".txt", false))
                            {
                                sw.WriteLine(ActiveControls.ActiveNews.Title);
                                sw.Write(ActiveControls.ActiveNews.Descriprion);
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Saved!\nPath: " + path);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            path = @"\ConsoleTagsSortApplication\MySaveNews";
                            using (var sw = new StreamWriter(ActiveControls.ActiveNews.Title + ".txt"))
                            {
                                sw.Write(ActiveControls.ActiveNews.Title);
                                sw.Write(ActiveControls.ActiveNews.Descriprion);
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Saved!\nPath: " + path);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Отмэна");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
    //TODO: добавить описание команд в консоли!

}
