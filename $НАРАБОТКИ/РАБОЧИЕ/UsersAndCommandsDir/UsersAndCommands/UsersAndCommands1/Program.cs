using System;
using UsersAndCommands1.UsersDir;
using UsersAndCommands1.CommandsDir;
using UsersAndCommands1.CommandsDir.Creator_Commands;
using System.Collections.Generic;
using System.Threading;


namespace UsersAndCommands1
{
    class Program
    {
        public static User ActiveUser { get; private set; } //активный пользователь
        public static void AddAllU()
        {
            new DefaultUsers("User", "1234");
        } //тупа добавили базовых пользователей
        static void Main(string[] args)
        {
            AddAllU();
            CompleteAutorization();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(ActiveUser.Login + " > ");
                Console.ForegroundColor = ConsoleColor.White;
                string enterCommand = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(enterCommand)) Console.WriteLine("Получить список команд: get commands");
                else FindCommand(enterCommand);
            }
        }
        public static void CompleteAutorization()
        {
            Console.Write("Login: ");
            string log = Console.ReadLine();
            Console.Write("Password: ");
            string pas = Console.ReadLine();
            ActiveUser = User.Autorization(log, pas);
            UserAccess(ActiveUser); //добавляем команды default или creators
        }
        //СЮДЫ ДОБАВЛЯЕМ СТАНДАРТНЫЕ КОМАНДЫ
        public static void GetStandartCommands()
        {
            new PrintHello();
            new GetAllCommands();
            new GetLoginsAllUsers();
            new ClearConsole();
            new InfoAboutMe();
            new Exit();
        }
        //СЮДЫ ДОБАВЛЯЕМ КОМАНДЫ ДЛЯ РЕДАКТОРОВ
        public static void GetCreatorCommands()
        {
            new GetAllUser();
        }
        
        public static void UserAccess(User nowActiveUser)
        {
            if (ActiveUser.IsCreator == false)
            {
                GetStandartCommands();
            }
            if (ActiveUser.IsCreator == true)
            {
                GetStandartCommands();
                GetCreatorCommands();
            }
        }
        public static void FindCommand(string findCommand)
        {
            for (int i = 0; i < Command.allCommandList.Count; i++)
            {
                Command.allCommandList[i].MyCommand(findCommand);
            }
        }
    }
}
