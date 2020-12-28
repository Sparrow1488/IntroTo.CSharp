using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ServerWF
{
    public class Server
    {
        private IPEndPoint endPoint;
        private IPEndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.3"), 8090);

        private Socket socket;
        public Server(string ip, int port)
        {
            if (string.IsNullOrWhiteSpace(ip))
                throw new ArgumentException("Не имеется IP");
            if (port <= 0)
                throw new ArgumentException("Порт отдыхает");

            endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        }
        public void ProcessingRequest()
        {
            var data = new byte[256];
            var size = socket.Receive(data); // получаем данные
            Console.WriteLine("Полученные данные: " + size);
            SendData(data, socket);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
        private void SendData(byte[] buffer, Socket socket)
        {
            socket.Connect(senderEndPoint);
            socket.Send(buffer);
        }
        public void CreateSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(endPoint);
        }
        
        
    }
}
