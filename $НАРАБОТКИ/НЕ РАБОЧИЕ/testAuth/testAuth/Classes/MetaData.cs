using System;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace testAuth
{
    public class MetaData
    {
        public static IFirebaseConfig config = new FirebaseConfig() 
        {
            AuthSecret = "Bm09F6gPsQ2Hp8WxdFbtqSSXZwNNgcIAwo7oOeyi",
            BasePath = "https://client-server-testapp-default-rtdb.firebaseio.com/"
        };
        public static string parentPath = "authWPF_Users";
        public static IFirebaseClient client = null;
        public static My
    }
}
