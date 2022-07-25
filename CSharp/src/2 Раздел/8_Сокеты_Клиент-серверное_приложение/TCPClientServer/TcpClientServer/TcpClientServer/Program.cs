using System;
using System.Net;
using System.Net.Sockets;

namespace TcpClientServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse("127.0.0.3"), 8900);
            serverSocket.Start();
            Console.WriteLine("Server started");

            TcpClient clientSocket = serverSocket.AcceptTcpClient();

            clientSocket.Close();
            Console.WriteLine("Client socket stopped");
            serverSocket.Stop();
            Console.WriteLine("Server socket stopped");
        }
    }
}
