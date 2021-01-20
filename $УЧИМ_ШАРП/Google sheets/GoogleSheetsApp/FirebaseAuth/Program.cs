using System;
using Firebase.Auth;
using Google.Api;
using Google.Cloud.Firestore;
using Google.Rpc;

namespace FirebaseAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            Firebase.Auth.FirebaseAuth auth = new Firebase.Auth.FirebaseAuth();
            Console.WriteLine(auth.User.DisplayName);
        }
    }
}
