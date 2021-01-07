using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientTCP
{
    class Program
    {
        // <!-- КЛИЕНТСКАЯ ЧАСТЬ-->
        // 1. пишем конфиг
        // 2. устанавливаем точку подключения
        // 3. подключаем сокет к конечной точке
        // 4. <отправляем>
        // 5. <ожидаем ответ>
        static async void Main(string[] args)
        {
            #region TCPClient
            //const string ip = "127.0.0.1";
            //const int port = 8080;

            //var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //while (true)
            //{
            //    var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //    Console.Write("Введите сообщение: ");
            //    var message = Console.ReadLine();

            //    if(message == "выход")
            //    {
            //        break;
            //    }

            //    var data = Encoding.UTF8.GetBytes(message); // не забываем закодировать данные
            //    tcpSocket.Connect(tcpEndPoint); // оформляем подключение
            //    tcpSocket.Send(data); // отправляем

            //    //<!--ПОДГОТАВЛИВАЕМ ВСЕ ДЛЯ ПОЛУЧЕНИЯ ОТВЕТА-->
            //    var buffer = new byte[256];
            //    var size = 0;
            //    var answer = new StringBuilder();

            //    //<!--ПОЛУЧАЕМ ОТВЕТ-->
            //    do
            //    {
            //        size = tcpSocket.Receive(buffer); // получаем по факту полученный размер байт
            //        answer.Append(Encoding.UTF8.GetString(buffer), 0, size);
            //    }
            //    while (tcpSocket.Available > 0);

            //    Console.WriteLine(answer);
            //    tcpSocket.Shutdown(SocketShutdown.Both);
            //    tcpSocket.Close();
            //}
            //Console.WriteLine("До связи...");
            #endregion

            #region UDPClient
            const string ip = "127.0.0.1";
            const int port = 8080;

            Console.Write("Ваш логин: ");
            var login = Console.ReadLine();

            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);

            while (!udpSocket.Connected)
            {
                Console.Write("Введите сообщение: ");
                var message = Console.ReadLine();

                EndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                udpSocket.SendTo(Encoding.UTF8.GetBytes($"{login}> {message}"), serverEndPoint);

                await PullData(udpSocket, serverEndPoint);
            }
            Console.WriteLine("End");
            #endregion
        }
        static async Task PullData(Socket udpSocket, EndPoint serverEndPoint)
        {
            await Task.Run(() =>{
                Console.WriteLine();
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();
                size = udpSocket.ReceiveFrom(buffer, ref serverEndPoint);
                data.Append(Encoding.UTF8.GetString(buffer));
                Console.WriteLine(data);
            });
        }
    }
}
