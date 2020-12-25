using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketsHW
{
    class Program
    {
        static string path = @"C:\Users\DOM\Desktop\HTML\C#\The-basis-of-CScharp\$УЧИМ_ШАРП\2 Раздел\8_Сокеты_Клиент-серверное_приложение\TCP\SocketsHW\SocketsHW\Sho1.txt";
        static string commandWrite = "";
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8090;

            var endPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(endPoint);
            socket.Listen(2);

            //Thread threadCommand = new Thread(new ParameterizedThreadStart(WriteCommand));
            //threadCommand.Start(socket);
            try
            {
                while (true)
                {
                    var listener = socket.Accept();

                    //WriteCommandServer(listener); // TODO: ЗАКРЫТИЕ СЕРВЕРА ПО КОМАНДЕ ИЗ КОНСОЛИ

                    var buffer = new byte[256];
                    int size;
                    var data = new StringBuilder();

                    do
                    {
                        size = listener.Receive(buffer);
                        data.Append(Encoding.UTF8.GetString(buffer), 0, size);
                    }
                    while (socket.Available > 0);

                    if (data.Equals("read"))
                        ReadCommand(listener);
                    if (data.Equals("write"))
                    {
                        listener.Send(Encoding.UTF8.GetBytes("/рандомное число/"));
                        WriteRandom(path, listener);
                    }
                    listener.Send(Encoding.UTF8.GetBytes(data.ToString()));
                    Console.WriteLine("Команда user: " + data);

                }
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();

            }
            catch(SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        static async void WriteCommand(object socket)
        {
            await Task.Run(() =>
            {
                commandWrite = Console.ReadLine();
                //if (commandWrite.Equals("выход"))
                //    (Socket)socket.Close();
            });
        }
        static async Task WriteRandom(string path, Socket listener)
        {
            await Task.Run(() =>
            {
                using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    Random rnd = new Random();
                    sw.WriteLine(rnd.Next(100).ToString());
                }
            });
        }
        static void ReadCommand(Socket listener)
        {
            FileInfo fileInfo = new FileInfo(path);
            using (var sr = new StreamReader(fileInfo.FullName))
            {
                string fullText = sr.ReadToEnd();

                listener.Send(Encoding.UTF8.GetBytes($"{fileInfo.Name}\n"));
                listener.Send(Encoding.UTF8.GetBytes($"{fullText}"));
            }
        }


    }
}
