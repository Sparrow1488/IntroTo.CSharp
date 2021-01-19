using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Threading.Tasks;

namespace testClientStorage
{
    class Program
    {
        static FirestoreClient client;
        static async Task Main(string[] args)
        {
            client = FirestoreClient.Create();

            FirestoreSettings settings = client.Settings;
            Console.WriteLine("Create client");

            FirestoreDb db = FirestoreDb.Create("client-server-testapp", client);

            // Create a document with a random ID in the "users" collection.
            CollectionReference collection = db.Collection("users");
            DocumentReference document = await collection.AddAsync(new { Name = new { First = "Ada", Last = "Lovelace" }, Born = 1815 });

            // A DocumentReference doesn't contain the data - it's just a path.
            // Let's fetch the current document.
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();

            // We can access individual fields by dot-separated path
            Console.WriteLine(snapshot.GetValue<string>("Name.First"));
            Console.WriteLine(snapshot.GetValue<string>("Name.Last"));
            Console.WriteLine(snapshot.GetValue<int>("Born"));

            // Or deserialize the whole document into a dictionary
            Dictionary<string, object> data = snapshot.ToDictionary();
            Dictionary<string, object> name = (Dictionary<string, object>)data["Name"];
            Console.WriteLine(name["First"]);
            Console.WriteLine(name["Last"]);

            // See the "data model" guide for more options for data handling.

            // Query the collection for all documents where doc.Born < 1900.
            Query query = collection.WhereLessThan("Born", 1900);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot queryResult in querySnapshot.Documents)
            {
                string firstName = queryResult.GetValue<string>("Name.First");
                string lastName = queryResult.GetValue<string>("Name.Last");
                int born = queryResult.GetValue<int>("Born");
                Console.WriteLine($"{firstName} {lastName}; born {born}");
            }
        }
    }
}
