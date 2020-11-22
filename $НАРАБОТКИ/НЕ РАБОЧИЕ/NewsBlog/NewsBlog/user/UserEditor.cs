using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.user
{
    public class UserEditor : User
    {
        public UserEditor(string login, string password) : base(login, password){}

        public override void PrintNews()
        {
            Console.WriteLine("new");
        }

        public void AddNews()
        {
            // рите TODO: потом сделать добавление новостей
        }
    }
}
