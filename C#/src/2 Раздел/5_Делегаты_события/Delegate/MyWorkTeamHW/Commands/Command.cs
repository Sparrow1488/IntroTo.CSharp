using System;
using System.Collections.Generic;
using System.Text;
using MyWorkTeamHW.Commands;

namespace MyWorkTeamHW.Commands
{
    public abstract class Command
    {
        public static List<Command> commandBase = new List<Command>();
        public string myCommand { get; protected set; }

        public abstract void MyCommand(string enterCommand);

        public Command()
        {
            commandBase.Add(this);
        }

        public static void GetAllCommands()
        {
            foreach (var com in commandBase)
            {
                Console.Write("Команда: ");
                Console.WriteLine(com.myCommand);
            }
        }
    }
}
