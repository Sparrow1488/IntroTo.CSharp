using System;
using System.Collections.Generic;

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
        public static void CreateBase()
        {
            new CreateNews();
            new ReadCommand();
            new ClearConsole();
            new SetCommand();
            new HelpCommand();
            new UserCommand();
            new SaveCommand();
        }
        public abstract void GetMyCommand(string[] enterCommand);
        public abstract void GetInfoCommand();

    }
}
