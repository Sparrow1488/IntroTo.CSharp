using System;
using System.Collections.Generic;
using System.Text;
using UsersAndCommands1.CommandsDir;
using UsersAndCommands1.UsersDir ;

namespace UsersAndCommands1.CommandsDir
{
    class PrintHello : Command
    {
        public override void MyCommand(string entCommand)
        {
            sCommand = "print";
            if (entCommand == sCommand)
            {
                Console.WriteLine("Hello, " + Program.ActiveUser.Login);
            }
        }
    }
    class InfoAboutMe : Command
    {
        public override void MyCommand(string entCommand)
        {
            sCommand = "my info";
            if (entCommand == sCommand)
            {
                Console.WriteLine($"Login: {Program.ActiveUser.Login}; Password: *******; Access creator: {Program.ActiveUser.IsCreator}");
            }
        }
    }
    class ClearConsole : Command
    {
        public override void MyCommand(string entCommand)
        {
            sCommand = "clear";
            if (entCommand == sCommand)
            {
                Console.Clear();
            }
        }
    }
    class GetAllCommands : Command
    {
        public override void MyCommand(string entCommand)
        {
            sCommand = "get commands";
            if (entCommand == sCommand)
            {
                for (int i = 0; i < allCommandList.Count; i++)
                {
                    Console.Write("Command > ");
                    string command = allCommandList[i].sCommand;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(command);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
    class GetLoginsAllUsers : Command
    {
        public override void MyCommand(string entCommand)
        {
            sCommand = "get users";
            if (entCommand == sCommand)
            {
                foreach (var user in User.BaseUsers)
                {
                    Console.WriteLine("Login: " + user.Login);
                }
            }
        }
    }
    class Exit : Command
    {
        public override void MyCommand(string entCommand)
        {
            sCommand = "exit";
            if (entCommand == sCommand)
            {
                Console.WriteLine("Вы действительно желаете выйти? (Y, если да)");
                string choose = Console.ReadLine();
                if (choose == "Y")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
