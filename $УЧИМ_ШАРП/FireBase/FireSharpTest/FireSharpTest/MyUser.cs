using System;
using System.Collections.Generic;
using System.Text;

namespace FireSharpTest
{
    public class MyUser
    {
        public string Login = null;
        public string Password = null;
        public int ID;
        public MyUser(string login, string password)
        {
            Login = login;
            Password = password;
            ID = RndID();
        }
        private static int RndID()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1000);
        }
    }
}
