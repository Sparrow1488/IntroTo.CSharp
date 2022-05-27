using PrivateServices.Console.Models;

namespace PrivateServices.Console.Sessions
{
    internal class Session
    {
        public Client Client { get; internal set; } = new Client();

        public static Session Current { get; internal set; } = new Session();
    }
}
