using System;

namespace ServerWF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server started");
            var server = new Server("127.0.0.1", 8090);

            while (true)
            {
                server.CreateSocket();
                server.ProcessingRequest();
            }
        }
    }
}
