using System;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace FireSharpTest
{
    public class Program
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "6CScUkKUdSLgSDtq1QWtfY2NCPP57aa6ajBn7R4Y",
            BasePath = "https://client-server-testapp-default-rtdb.firebaseio.com/"
        };
        private static FirebaseClient client = null;
        private static string parentPath = "ClientList";
        private static MyUser ActiveUser = null;

        static void Main(string[] args)
        {
            CreateClient();

            Console.Write("Write login: ");
            string log = Console.ReadLine();
            Console.Write("Write password: ");
            string pass = Console.ReadLine();

            ActiveUser = CreateUser(log, pass);

            SetResponse setClient = client.Set($"{parentPath}/{ActiveUser.Login}", ActiveUser);
            Console.WriteLine("Wait...");
            Console.WriteLine("New user is create!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Login: {ActiveUser.Login}\nPassword: {ActiveUser.Password}\nID: {ActiveUser.ID}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void CreateClient()
        {
            client = new FirebaseClient(config);
            if (client != null)
            {
                Console.WriteLine("Client is connected!");
            }
            else
            {
                throw new ArgumentNullException("Ошибка подключения");
            }
        }
        private static MyUser CreateUser(string login, string password)
        {
            var wasUser = client.Get($"{parentPath}/{login}");
            MyUser getUser = wasUser.ResultAs<MyUser>();
            if (getUser != null)
            {
                throw new ArgumentNullException("Возможно данный пользователь уже существует!");
            }
                
            var myClient = new MyUser(login, password);
            if (myClient != null)
            {
                return myClient;
            }
            else
            {
                return null;
            }
        }
    }
}
