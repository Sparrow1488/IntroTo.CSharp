using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerTCP1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port); // парсим наш ip (string) в стандартный формат подключения.

            // <!-- СОЗДАЕМ СОКЕТ В РЕЖИМЕ ОЖИДАНИЯ-->
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // шаблонный параметр (не должен изменяться)
            tcpSocket.Bind(tcpEndPoint); // связываем наш сокет с конечной точной
            tcpSocket.Listen(5); // сколько пользователей мы можем держать в режиме ожидания (некая защита от перегрузки)

            // <!--ПРОЦЕСС ПРОСЛУШИВАНИЯ-->
            while (true)
            {
                var listener = tcpSocket.Accept();
                var buffer = new byte[256]; // создаем хранилище, куда будут залетать наши полученные данные (указываем то, сколько мы можем принять байт)
                var sizeFact = 0; // по факту полученные байты
                var data = new StringBuilder();

                do
                {
                    sizeFact = listener.Receive(buffer); // получаем по факту полученный размер байт
                    data.Append(Encoding.UTF8.GetString(buffer), 0, sizeFact);
                }
                while (tcpSocket.Available > 0); // выполнять до тех пор, пока в нашем подключении будут какие либо данные

                Console.WriteLine(data);

                listener.Send(Encoding.UTF8.GetBytes("Успех!"));

                listener.Shutdown(SocketShutdown.Both); // корректно выключили
                listener.Close(); // закрыли
            }
        }
    }
}
