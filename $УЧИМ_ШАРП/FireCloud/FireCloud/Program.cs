using System;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace FireCloud
{
    class Program
    {
        //https://github.com/GoogleCloudPlatform/dotnet-docs-samples/blob/9dc01e0314cd744c6c97f938875f61245fc6ee2b/firestore/api/Quickstart/Program.cs#L37-L38
        //https://console.firebase.google.com/project/client-server-testapp/firestore/data~2FMyCollection-Test~2FUser?hl=ru
        //https://firebase.google.com/docs/cloud-messaging/server
        static void Main(string[] args)
        {
            string project = "User";
            FirestoreDb db = FirestoreDb.Create(project);
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", project);
        }
    }
}
