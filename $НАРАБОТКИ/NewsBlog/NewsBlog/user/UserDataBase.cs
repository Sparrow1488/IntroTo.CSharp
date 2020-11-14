using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.user
{
    public class UserDataBase
    {
        public static Dictionary<string, string> Users = new Dictionary<string, string>()
        {
            { "bob", "1234" }
        };

        public static void AddUser(User user)
        {
            if (!string.IsNullOrWhiteSpace(user.Login) && !string.IsNullOrWhiteSpace(user.Password))
            {
                Users.Add(user.Login, user.Password);
            }
        }
        public static void RemoveUser(User user)
        {
            if (!string.IsNullOrWhiteSpace(user.Login))
            {
                Users.Remove(user.Login);
            }
        }
        public static void CheckValidityOfUser(string login, string password)
        {
            bool has = false;
            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                has = CheckDataOfUser(login, password);   
            }
            PrintResultOfCheck(has);
        }
        private static bool CheckDataOfUser(string login, string password)
        {
            foreach(var elem in Users.Keys)
            {
                if(elem.Equals(login) && Users[elem].Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        private static void PrintResultOfCheck(bool has)
        {
            if (has)
            {
                Console.WriteLine("Вы вошли...");
            }
            else
            {
                Console.WriteLine("Такого пользователя не существует!");
            }
        }
    }
}
