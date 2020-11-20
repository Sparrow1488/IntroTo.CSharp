using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndCommands1.UsersDir
{
    public abstract class Users
    {
        public static List<Users> BaseUsers = new List<Users>();
        public static List<Users> BaseCreators = new List<Users>();

        protected string Login { get; set; }
        protected string Password { get; set; }
        public Users(string login, string password)
        {
            bool loginCheck = CheckLogin(login);
            bool passwordCheck = CheckPassword(password);
            bool haveInList = CheckUsersInList(login);
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
        private static bool CheckUsersInList(string login)
        {
            for (int i = 0; i < BaseUsers.Count; i++)
            {
                if (BaseUsers[i].Login == login)
                {
                    return true;
                }
            }
            return false;
        }
        public static void PrintListUsers()
        {
            foreach (var user in BaseUsers)
            {
                Console.WriteLine($"Login: {user.Login}; Password: {user.Password}");
            }
        }
    }
}
