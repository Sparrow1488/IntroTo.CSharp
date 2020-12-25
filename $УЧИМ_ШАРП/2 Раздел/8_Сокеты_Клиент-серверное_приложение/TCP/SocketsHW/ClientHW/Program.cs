using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientHW
{
    class Program
    {
        static void Main(string[] args)
        {
            bool round = true;
            const string ip = "127.0.0.1";
            const int port = 8090;

            string path = @"C:\Users\DOM\Desktop\HTML\C#\The-basis-of-CScharp\$УЧИМ_ШАРП\2 Раздел\8_Сокеты_Клиент-серверное_приложение\TCP\SocketsHW\SocketsHW\Sho.txt";

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            try
            {
                while (round)
                {
                    var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    Console.Write("Введите сообщение: ");
                    var message = Console.ReadLine();

                    if (message.Equals("выход"))
                        break;

                    var data = Encoding.UTF8.GetBytes(message); // не забываем закодировать данные
                    tcpSocket.Connect(tcpEndPoint); // оформляем подключение
                    tcpSocket.Send(data); // отправляем

                    //<!--ПОДГОТАВЛИВАЕМ ВСЕ ДЛЯ ПОЛУЧЕНИЯ ОТВЕТА-->
                    var buffer = new byte[256];
                    var size = 0;
                    var answer = new StringBuilder();

                    //<!--ПОЛУЧАЕМ ОТВЕТ-->
                    do
                    {
                        size = tcpSocket.Receive(buffer); // получаем по факту полученный размер байт
                        answer.Append(Encoding.UTF8.GetString(buffer), 0, size);
                    }
                    while (tcpSocket.Available > 0);
                    Console.WriteLine(answer);

                    tcpSocket.Shutdown(SocketShutdown.Both);
                    tcpSocket.Close();
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
            
            Console.WriteLine("Завершение работы.");
        }
        static async void CheckServerActive()
        {
            await Task.Run(() =>
            {
                
            });
        }
    }
}
