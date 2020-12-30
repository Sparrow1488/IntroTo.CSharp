using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWF
{
    public class Client
    {
        private string Message;
        public string GetMessage;
        public string IP;
        public int Port;
        private Socket socket;
        private IPEndPoint endPoint;
        public Client(string ip, int port)
        {
            if (string.IsNullOrWhiteSpace(ip) || port <= 0)
                throw new ArgumentException("Ошибка ввода");
            Port = port;
            IP = ip;
            endPoint = new IPEndPoint(IPAddress.Parse(IP), port);
        }

        public void SendMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Проблема с вводом данных");

            Message = message;
            var data = Encoding.UTF8.GetBytes(Message);
            socket.Send(data);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        public void CreateSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Connect(endPoint);
        }

        public async Task PullData(ListBox listMessages)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        var data = new byte[256];
                    
                        socket.Receive(data);

                        var getMessage = Encoding.UTF8.GetString(data);
                        listMessages.Items.Add(GetMessage);

                        //socket.Shutdown(SocketShutdown.Both);
                        //socket.Close();
                    }
                    catch (SocketException) {  }
                    
                }
            });
        }

    }
}
