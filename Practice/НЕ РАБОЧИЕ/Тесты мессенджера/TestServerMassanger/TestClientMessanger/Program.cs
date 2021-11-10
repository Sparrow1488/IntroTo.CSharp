using System;

namespace TestClientMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("127.0.0.3", 8080);
            Console.WriteLine("Client create");

            while (true)
            {
                client.ConnectSocket();
                Console.Write("Write message: ");
                var mes = Console.ReadLine();
                client.SendData(mes);
            }
        }
    }
}
