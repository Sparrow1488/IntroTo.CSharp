using System;
using System.Collections.Generic;
using System.Text;
using UsersAndCommands1.UsersDir;

namespace UsersAndCommands1
{
    public abstract class Command
    {
        public static List<Command> allCommandList = new List<Command>();
        public string sCommand { get; protected set; }
        public abstract void MyCommand(string enterCom);

        public Command()
        {
            allCommandList.Add(this);
        }


    }
}
