using System;

namespace TestServerMassanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("127.0.0.3", 8080);
            Console.WriteLine("Server started");

            while (true)
            {
                server.CreateSocket();
                server.ProcessingRequest();
            }
        }
    }
}
