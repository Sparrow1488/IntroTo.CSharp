using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndCommands1.UsersDir
{
    class CreatorUser : User
    {
        public CreatorUser(string login, string password) : base(login, password)
        {
            IsCreator = true;
        }
    }
}
