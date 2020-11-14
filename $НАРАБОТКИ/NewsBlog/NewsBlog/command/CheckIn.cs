using NewsBlog.user;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.command
{
    // ТУПА КУРОЧКА
    public class CheckIn : Command
    {   
        public override void CallCommand(string login, string passwrod)
        {
            User defUser = new DefaultUser(login, passwrod);
            UserDataBase.AddUser(defUser);
        }
    }
}
