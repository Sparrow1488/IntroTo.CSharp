using System;
using System.Collections.Generic;
using System.Text;
using UsersAndCommands1.UsersDir;

namespace UsersAndCommands1
{
    public abstract class Commands
    {
        public abstract void Logout(string login, string pass);
    }
}
