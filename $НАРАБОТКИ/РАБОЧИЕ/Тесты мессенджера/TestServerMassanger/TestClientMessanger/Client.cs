using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TestClientMessanger
{
    public class Client
    {
        public IPEndPoint endPointConnecting;
        private Socket socket;

        public Client(string ipConnecting, int portConnecting)
        {
            if (string.IsNullOrWhiteSpace(ipConnecting) || portConnecting <= 0)
                throw new ArgumentException("Ошибка ввода");

            endPointConnecting = new IPEndPoint(IPAddress.Parse(ipConnecting), portConnecting);
        }

        public void ConnectSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endPointConnecting);
        }

        public void SendData(string message)
        {
            var data = new byte[256];
            data = Encoding.UTF8.GetBytes(message);
            socket.Send(data);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
