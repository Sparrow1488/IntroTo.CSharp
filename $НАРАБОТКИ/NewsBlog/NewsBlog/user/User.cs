using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.user
{
    public abstract class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string login, string password)
        {
            if(!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                Login = login;
                Password = password;
            }
            else
            {
                throw new ArgumentException("неверный формат данных");
            }
        }

        public abstract void PrintNews();
    }
}
