using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTagsSortApplication.Commands
{
    public abstract class Command
    {
        public static List<Command> commandsAll = new List<Command>();
        public string myCommand;
        public Command()
        {
            commandsAll.Add(this);
        }

        public abstract void GetMyCommand(string[] enterCommand);
        public abstract void GetInfoCommand();

    }
}
