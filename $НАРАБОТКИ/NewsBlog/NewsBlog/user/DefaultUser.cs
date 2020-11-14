using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.user
{
    public class DefaultUser : User
    {
        public DefaultUser(string login, string password) : base(login, password){}
        public override void PrintNews()
        {
            Console.WriteLine("news");
        }
    }
}
