using System;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("127.0.0.1", 8080);
            Console.WriteLine("Client create");
            while (true)
            {
                client.CreateSocket();
                Console.Write("Write: ");
                var mes = Console.ReadLine();
                client.SendMessage(mes);
                Console.WriteLine("Отправлено");
                client.PullData();
            }
        }
    }
}
