using System;
using ConsoleTagsSortApplication.Tags;
using ConsoleTagsSortApplication.Commands;
using ConsoleTagsSortApplication.NewsDir;

namespace ConsoleTagsSortApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Command.CreateBase();
            Tag.CreateBase();
            News.CreateBase();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{ActiveControls.ActiveUser} > ");
                Console.ForegroundColor = ConsoleColor.White;

                string command = Console.ReadLine().Trim();
                string[] splitCommand = command.Split(" ");
                bool infoCommand = false;

                foreach (var word in splitCommand)
                {
                    infoCommand = bCheckedInfoCommand(word);
                }
                foreach (var getCommand in Commands.Command.commandsAll)
                {
                    if (infoCommand && getCommand.myCommand == splitCommand[0])
                        getCommand.GetInfoCommand();
                    else
                        getCommand.GetMyCommand(splitCommand);
                }
            }
        }
        static bool bCheckedInfoCommand(string word)
        {
            if (word == "info") return true;
            else return false;
        }

    }
}
