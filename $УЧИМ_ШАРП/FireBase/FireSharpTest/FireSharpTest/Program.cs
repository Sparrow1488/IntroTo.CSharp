using System;
using FireSharp.Config;
using FireSharp;
using FireSharp.Interfaces;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using System.Collections.Generic;
using Google.Cloud.Firestore.V1;
using FireSharp.Response;

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
        static async Task Main(string[] args)
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

            //< СОЗДАНИЕ СЕРВИСНОГО АККАУНТА, ТК GOOGLE_APPLICATION_CREDENTIALS ТОЛЬКО ДЛЯ СЕРВИСНЫХ АККОВ
            //ОТСУТСВУЕТ.JSON KEY ИЗ FIRECLOUD
            //string path = AppDomain.CurrentDomain.BaseDirectory + "client_secret.json";
            //Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            //FirestoreDb db = FirestoreDb.Create("testapp2-904b3");
            //Console.WriteLine("Create {0}", db.ProjectId);

            //Dictionary<string, string> data = new Dictionary<string, string>()
            //{
            //    { "Text", "My test string"}
            //};
            //DocumentReference doc = db.Collection("testing").Document("tests");
            //await doc.SetAsync(data);
            //Console.WriteLine("Add data");

            //DocumentSnapshot getData = await doc.GetSnapshotAsync();
            //if (getData.Exists)
            //{
            //    Dictionary<string, object> parseDictionory = getData.ToDictionary();
            //    foreach (var item in parseDictionory)
            //    {
            //        Console.WriteLine("get data: {0}: {1}", item.Key, item.Value);
            //    }
            //    Console.WriteLine("Get complete!");
            //}
            //else
            //{
            //    Console.WriteLine("File not exist");
            //}

            //string api_key = "AIzaSyC5xQGK98-mww-f22hLZp6VXSwnGxWhUHM";

            //var authProvider = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig(api_key));
            //var email = $"abcd{new Random().Next()}@test.com";

            //var auth = authProvider.SignInWithEmailAndPasswordAsync(email, "test1234").Result;

            //var user = auth.User.Email;
            //auth.User.E. ShouldBeEquivalentTo(email);
            //FireBaseApp
        }
        #region Other Methods
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
        #endregion
    }
}
