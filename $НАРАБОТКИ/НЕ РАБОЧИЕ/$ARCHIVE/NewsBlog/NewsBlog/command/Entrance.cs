using NewsBlog.user;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBlog.command
{
    public class Entrance : Command
    {
        public override void CallCommand(string login, string passwrod)
        {
            UserDataBase.CheckValidityOfUser(login, passwrod);
        }
    }
}
