using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AdressesDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.3"); // преобразуем строку в тип IPAddress
            int host = 8080;

            //<!-- ПОЛУЧАЕМ IP АДРЕСА VK.COM-->
            IPHostEntry iPHostVk = Dns.GetHostEntry("vk.com");

            Console.WriteLine(iPHostVk.HostName);
            foreach (var item in iPHostVk.AddressList)
                Console.WriteLine(item.ToString());

            //<!-- ПОЛУЧАЕМ IP АДРЕСА GOOGLE.COM-->
            IPHostEntry iPHostGoogle = Dns.GetHostEntry("google.com");

            Console.WriteLine(iPHostGoogle.HostName);
            foreach (var item in iPHostGoogle.AddressList)
                Console.WriteLine(item.ToString());

            Console.WriteLine();

            //<!--ЕЩЕ ОДИН СЕРВЕР-->
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var endPoint = new IPEndPoint(ip, host);
            socket.Bind(endPoint);
            socket.Listen(1);
            

            while (true)
            {
                var listener = socket.Accept();
                var buffer = new byte[1024];
                int size;
                var data = new StringBuilder();
                do
                {
                    size = listener.Receive(buffer);
                    data.Append(Encoding.UTF8.GetString(buffer), 0, size);
                }
                while (socket.Available > 0);

                Console.WriteLine(data);
                listener.Send(Encoding.UTF8.GetBytes("але"));
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

        }
    }
}
