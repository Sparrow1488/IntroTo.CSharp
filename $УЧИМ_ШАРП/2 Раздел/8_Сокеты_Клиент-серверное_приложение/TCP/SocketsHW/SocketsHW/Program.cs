using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SocketsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8090;

            var endPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(endPoint);
            socket.Listen(2);

            while (true)
            {
                var listener = socket.Accept();
                var buffer = new byte[256];
                int size;
                var data = new StringBuilder();

                do
                {
                    size = listener.Receive(buffer);
                    data.Append(Encoding.UTF8.GetString(buffer), 0, size);
                } 
                while (socket.Available > 0);

                if (data.Equals("фото"))
                {
                    listener.SendFile(@"C:\Users\DOM\Desktop\HTML\C#\The-basis-of-CScharp\$УЧИМ_ШАРП\2 Раздел\8_Сокеты_Клиент-серверное_приложение\TCP\SocketsHW\SocketsHW\Sho.txt");
                }
                else
                {
                    listener.Send(Encoding.UTF8.GetBytes("Что то прошло"));
                }

                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }

        }
    }
}
