using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ServerForms.ServerProp
{
    public class ServerProperties
    {
        static string ipServer = "127.0.0.3";
        static int activePost = 8090;
        static IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ipServer), activePost);

        public Socket CreateSocket(IPEndPoint tcpEndPoint, int listeners)
        {
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(listeners);
            return tcpSocket;
        }

        static void ListenMode(Socket listenSocket, TextBox answersTextBox)
        {
            while (true)
            {
                Socket listener = listenSocket.Accept();

                var buffer = new byte[256];
                int size;
                var data = new StringBuilder();

                do
                {
                    //size = listener.Receive(buffer);
                    data.Append(Encoding.UTF8.GetString(buffer), 0, buffer.Length);
                }
                while (listenSocket.Available > 0);

                listener.Send(Encoding.UTF8.GetBytes(data.ToString()));

                answersTextBox.Text = 
            }
        }
    }
}
