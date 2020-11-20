using System;
using UsersAndCommands1.UsersDir;

namespace UsersAndCommands1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Создаем аккаунт");

                Console.Write("Login: ");
                string log = Console.ReadLine();
                Console.Write("Password: ");

                string pas = Console.ReadLine();
                new DefaultUsers(log, pas);
                Users.PrintListUsers();
            }
        }
    }
}
