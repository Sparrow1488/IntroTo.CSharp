using System;
using System.Collections.Generic;
using System.Text;
using UsersAndCommands1.UsersDir;

namespace UsersAndCommands1.CommandsDir.Creator_Commands
{
    class GetAllUser : Command
    {
        public override void MyCommand(string enterCom)
        {
            sCommand = "get all users";
            if (enterCom == sCommand)
            {
                User.GetLoginPasswordUsers();
            }
        }
    }
}
