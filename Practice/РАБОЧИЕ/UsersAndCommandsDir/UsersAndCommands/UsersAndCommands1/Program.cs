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
        static void Main(string[] args)
        {
            bool exitChoose = true;
            while(exitChoose)
            {
                Console.WriteLine("Вход(L) / Регистрация(R)");
                string chooseStart = Console.ReadLine();
                ChooseLogInOrAutorization(chooseStart, ref exitChoose);
            }
            AddAllUsers();
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
        private static void AddAllUsers()
        {
            new DefaultUsers("User", "1234");
            new DefaultUsers("Big_Boss1488", "4549823");
            new DefaultUsers("MamaMia13", "3457");
            new DefaultUsers("ScaryBoy", "11111");
        } //тупа добавили базовых пользователей
        private static void CompleteAutorization()
        {
            Console.Write("Login: ");
            string log = Console.ReadLine();
            Console.Write("Password: ");
            string pas = Console.ReadLine();
            ActiveUser = User.Autorization(log, pas);
            UserAccess(ActiveUser); //добавляем команды default или creators
        }
        private static void CompleteRegistration()
        {
            Console.Write("Login: ");
            string log = Console.ReadLine();
            Console.Write("Password: ");
            string pas = Console.ReadLine();
            ActiveUser = User.Registration(log, pas);
            UserAccess(ActiveUser); //добавляем команды default или creators
        }
        private static void ChooseLogInOrAutorization(string choose, ref bool exit)
        {
            switch (choose)
            {
                case "L":
                    {
                        CompleteAutorization();
                        Console.WriteLine($"Добрый день, {ActiveUser.Login}!");
                        exit = false;
                        break;
                    }
                case "R":
                    {
                        CompleteRegistration();
                        Console.WriteLine($"Добро пожаловать, {ActiveUser.Login}!");
                        exit = false;
                        break;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("Что-то пошло не так...");
                    break;
            }
        }
        private static void GetStandartCommands()    // СЮДЫ ДОБАВЛЯЕМ СТАНДАРТНЫЕ КОМАНДЫ
        {
            new PrintHello();
            new GetAllCommands();
            new GetLoginsAllUsers();
            new ClearConsole();
            new InfoAboutMe();
            new Exit();
            new EditMyPrifile(); // в процессе разработки
        }
        private static void GetCreatorCommands()     // СЮДЫ ДОБАВЛЯЕМ КОМАНДЫ ДЛЯ РЕДАКТОРОВ
        {
            new GetAllUser();
        }
        private static void UserAccess(User nowActiveUser)   // ОТ УРОВНЯ ПРАВ ДОБАВЛЯЕМ КОМАНДЫ
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
        private static void FindCommand(string findCommand)
        {
            for (int i = 0; i < Command.allCommandList.Count; i++)
            {
                Command.allCommandList[i].MyCommand(findCommand);
            }
        }
    }
}
