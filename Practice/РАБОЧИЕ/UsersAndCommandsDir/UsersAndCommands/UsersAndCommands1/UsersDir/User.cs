using System;
using System.Collections.Generic;
using System.Text;
using UsersAndCommands1;

namespace UsersAndCommands1.UsersDir
{
    public abstract class User
    {
        public static List<User> BaseUsers { get; set; } = new List<User>();
        public static List<User> BaseCreators { get; set; } = new List<User>()
        {
            new CreatorUser("Sparrow", "12"),
            new CreatorUser("Creator1", "123"),
        };

        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public bool IsCreator { get; protected set; }
        public string Description { get; private set; } = "Человек анонимность";

        public User(string login, string password)
        {
            bool loginCheck = CheckLogin(login);
            bool passwordCheck = CheckPassword(password);
            bool haveInList = CheckUsersInList(login, password);
            if (loginCheck && passwordCheck && !haveInList)
            {
                Login = login;
                Password = password.ToString();
                BaseUsers.Add(this);
            }
            else throw new ApplicationException($"{nameof(login)}, {nameof(password)}");
        }
        private static bool CheckLogin(string log)
        {
            if (!string.IsNullOrWhiteSpace(log)) return true; return false;
        }
        private static bool CheckPassword(string pas)
        {
            if (!string.IsNullOrWhiteSpace(pas)) return true; return false;
        }
        private static bool CheckUsersInList(string login, string password)
        {
            for (int i = 0; i < BaseUsers.Count; i++)
            {
                if (BaseUsers[i].Login == login && BaseUsers[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        private static bool CheckCreatorsInList(string login, string password)
        {
            for (int i = 0; i < BaseCreators.Count; i++)
            {
                if (BaseCreators[i].Login == login && BaseCreators[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void PrintListUsers()
        {
            Console.WriteLine("Default:");
            foreach (var user in BaseUsers)
            {
                Console.WriteLine($"Login: {user.Login};");
            }
            Console.WriteLine("Creators:");
            foreach (var creator in BaseCreators)
            {
                Console.WriteLine($"Login: {creator.Login};");
            }
        }
        public static string AccessRight(string log, string pas)
        {
            bool chList = CheckUsersInList(log, pas);
            bool chCre = CheckCreatorsInList(log, pas);
            if (chCre) return "Creator";
            if (chList) return "Default";
            return "0";
        }
        public static User Autorization(string log, string pas)
        {
            string access = AccessRight(log, pas);
            if (access == "0") throw new ApplicationException("Пользователь не имэитса");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Access > " + access);
            Console.ForegroundColor = ConsoleColor.White;

            return ReturnUser(log, pas);
        }
        public static User Registration(string log, string pas)
        {
            bool rightLogin = CheckLogin(log);
            bool rightPassword = CheckPassword(pas);
            if (pas.Length > 4 && rightLogin && rightPassword)
            {
                DefaultUsers defaultUser = new DefaultUsers(log, pas);
                return defaultUser;
            }
            throw new ApplicationException("Ошибка регистрации");
        }
        public static User ReturnUser(string log, string pas)
        {
            foreach (var creator in BaseCreators)
            {
                if (creator.Login == log && creator.Password == pas)
                {
                    return creator;
                }
            }
            foreach (var user in BaseUsers)
            {
                if (user.Login == log && user.Password == pas)
                {
                    return user;
                }
            }
            throw new ApplicationException("Пользователь не найден");
        }
        public static void EditUser(string command)
        {
            var me = ReturnUser(Program.ActiveUser.Login, Program.ActiveUser.Password);
            if (command == "login")
            {
                Console.Write("Придумайте логин: ");
                //TODO: БАХНУТЬ НАДО БЫ РЕДАКТОР ПРОФИЛЯ
                me.Login = "";
            }
        }
        
        public static void GetLoginPasswordUsers() //для редакторов
        {
            foreach (var user in BaseUsers)
            {
                Console.Write("Creator command > ");
                Console.WriteLine($"Login: {user.Login}; Password: {user.Password}");
            }
        }
    }
}
