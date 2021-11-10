using NewsBlog.command;
using NewsBlog.user;
using System;
using System.Collections.Generic;
using NewsBlog.news;

namespace NewsBlog
{
    class Program
    {
        private static Dictionary<string, Command> Commands = new Dictionary<string, Command>
        {
            { "регистрация", new CheckIn() },
            { "вход", new Entrance() }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите дальнейшее действие: ");
            foreach(var elem in Commands.Keys)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("______");
            string commad = Console.ReadLine();
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            SelectCommand(commad, login, password);
        }

        private static void SelectCommand(string commandName, string login, string password)
        {
            Commands[commandName].CallCommand(login, password);
        }
    }
}
