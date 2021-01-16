using System;
using FireSharp;

namespace testAuth.Classes
{
    public class MyUser
    {
        public string Login = null;
        public string Password = null;
        public MyUser(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public static MyUser ActiveUser = null;
    }
}
