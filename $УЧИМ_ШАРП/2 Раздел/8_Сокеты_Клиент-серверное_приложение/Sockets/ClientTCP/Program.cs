using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

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
        static void Main(string[] args)
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
            //const string ip = "127.0.0.1";
            //const int port = 8080;

            //var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            //var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            #endregion
        }
    }
}
