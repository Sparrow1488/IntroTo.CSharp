using PrivateServices.NetCore.Console.Models;

namespace PrivateServices.NetCore.Console.Sessions
{
    internal class Session
    {
        public Client Client { get; internal set; } = new Client();

        public static Session Current { get; internal set; } = new Session();
    }
}
