using System;
using ConsoleTagsSortApplication.NewsDir;
using ConsoleTagsSortApplication.Tags;
using System.IO;
using System.Collections.Generic;

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
                new News(createTitle, createDisc).ReadActiveNews();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    public class ReadCommand : Command
    {
        ActiveControls active = new ActiveControls();
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + id -> 'id'           ?Найти и читать новость по id");
            Console.WriteLine(myCommand + " + 'id'                 ?Читать новость по id");
            Console.WriteLine(myCommand + " + 'tag'                ?Читать новость по тегу");
            Console.WriteLine(myCommand + " + all                  ?Читать все новости");
            Console.WriteLine(myCommand + " + tags -> 'id'(новости)?Читать все теги в новости");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "read";

            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
                News.ShowTitleAllNews();

            else if (enterCommand[0] == myCommand && int.TryParse(enterCommand[1], out int result))
                News.GetNewsForID(result).ReadActiveNews();

            else if (enterCommand[0] == myCommand && enterCommand[1] == "id")
            {
                Console.Write("ID: ");
                int idReadNews = int.Parse(Console.ReadLine());
                News.GetNewsForID(idReadNews).ReadActiveNews();
            }

            else if (enterCommand[0] == myCommand && enterCommand[1] == "tag" && enterCommand.Length == 2)
            {
                string tag;
                var _findTags = new List<Tag>();
                Console.WriteLine("Введите тег: ");
                while (true)
                {
                    Console.Write("-");
                    tag = Console.ReadLine().Trim();
                    if (Tag.CheckTagNameInList(tag))
                        _findTags.Add(Tag.GetTag(tag));
                    if (tag == "") break;
                }
                var getFindNews = News.ShowAllFindNewsList(_findTags);
                foreach (var news in getFindNews)
                    news.ReadActiveNews();
            }

            else if (enterCommand[0] == myCommand && enterCommand[1] == "all" && enterCommand.Length == 2)
                News.ShowAllNews();
            else if(enterCommand[0] == myCommand && enterCommand[1] == "tags" && enterCommand.Length == 2)
            {
                Console.Write("ID: ");
                if(int.TryParse(Console.ReadLine(), out int id))
                    News.GetNewsForID(id).ShowTagsActiveNews();
                else Console.WriteLine("Ошибка ввода!");
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
        private static Tag ActiveTag;
        private static News ActiveNews;

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
                GetNewsForId();
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

        private static void SetTagForNews(string tagEnter)
        {
            if (!bCheckIdInActiveNews(tagEnter))
            {
                foreach (var tag in Tag.tagsAll)
                {
                    if (tagEnter == tag.tagName)
                    {
                        ActiveTag = Tag.GetTag(tagEnter);
                        ActiveNews.AddTagInNews(ref ActiveTag);
                    }
                }
            }
            else if (bCheckIdInActiveNews(tagEnter)) Console.WriteLine("Тег уже добавлен!");
        }
        private static void GetNewsForId()
        {
            Console.Write("Введите ID новости: ");
            if(int.TryParse(Console.ReadLine(), out int id))
                ActiveNews = News.GetNewsForID(id);
            else Console.WriteLine("Ошибка формата!");
        }
        private static bool bCheckIdInActiveNews(string enterTag)
        {
            foreach (var tag in ActiveNews.tagsInNews)
            {
                if (enterTag == tag.tagName) return true;
            }
            return false;
        }
        private static bool SaveEnterTagsAndExit(string tag)
        {
            if (tag == "")
            {
                Console.WriteLine("save");
                ActiveNews.ShowTagsActiveNews();
                return true;
            }
            return false;
        }

    }
    public class UserCommand : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + set + login -> 'login'    ?Изменить логин");
            Console.WriteLine(myCommand + " + set + name -> 'name'      ?Изменить имя");
            Console.WriteLine(myCommand + " + set + bname -> 'byeName'  ?Изменить прощание при завершении сеанса");
            Console.WriteLine(myCommand + " + get + i                   ?Получить информацию о ползьователе");
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
                else if (enterCommand[2] == "bname") SetByeName();
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
        private static void SetByeName()
        {
            Console.WriteLine("При завершении сеанса обращаться к вашему логину или имени? (login/name)");
            string chooseBye = Console.ReadLine();
            if (chooseBye == "login") ActiveControls.ByeName = ActiveControls.ActiveUser;
            else if (chooseBye == "name") ActiveControls.ByeName = ActiveControls.ActiveUserName;

            Console.WriteLine($"<<До связи, {ActiveControls.ByeName}...>>");
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
        ActiveControls active = new ActiveControls();
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + id -> 'id' -> 'path'?Сохранить новость по id");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            ActiveControls active = new ActiveControls();

            myCommand = "save"; //save-news
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
                GetInfoCommand();
            else if(enterCommand[0] == myCommand && enterCommand[1] == "id" && enterCommand.Length == 2)
            {
                Console.Write("Введите ID: ");
                if(int.TryParse(Console.ReadLine(), out int id))
                { //TODO: че то там с стандартным path
                    active.ActiveNews = News.GetNewsForID(id);
                    active.ActiveNews.ReadActiveNews();
                    Console.WriteLine("Save? (Y)");
                    string chooseSave = Console.ReadLine();
                    if (chooseSave == "Y")
                    {
                        Console.WriteLine("Path: ");
                        string path = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(path))
                            SaveSelectPath(path);
                        else
                            SaveStandartPath(path);
                    }
                    else
                        MessageCancel("Отмена действий");
                }
                else MessageCancel("Ошибка ввода");
            }
        }
        private void SaveSelectPath(string enterPath)
        {
            using (var sw = new StreamWriter(enterPath + ".txt", false))
            {
                sw.WriteLine(active.ActiveNews.Title);
                sw.Write(active.ActiveNews.Descriprion);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved!\nPath: " + enterPath);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void SaveStandartPath(string enterPath)
        {
            enterPath = @"\ConsoleTagsSortApplication\MySaveNews";
            using (var sw = new StreamWriter(active.ActiveNews.Title + ".txt"))
            {
                sw.Write(active.ActiveNews.Title);
                sw.Write(active.ActiveNews.Descriprion);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved!\nPath: " + enterPath);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void MessageCancel(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class ExitApplication : Command
    {
        public override void GetInfoCommand()
        {
            Console.WriteLine(myCommand + " + app?Завершить сеанс");
        }

        public override void GetMyCommand(string[] enterCommand)
        {
            myCommand = "exit"; //exit-app
            if (enterCommand[0] == myCommand && enterCommand.Length == 1)
                GetInfoCommand();
            else if (enterCommand[0] == myCommand && enterCommand[1] == "app" && enterCommand.Length == 2)
            {
                Console.WriteLine($"До связи, {ActiveControls.ByeName}...");
                Environment.Exit(0);
            }
        }
    }

}
