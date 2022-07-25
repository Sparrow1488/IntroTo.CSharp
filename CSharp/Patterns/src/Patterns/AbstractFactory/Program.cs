using AbstractFactory.Bmw;
using AbstractFactory.Lada;

namespace AbstractFactory
{
    internal class Program
    {
        public  static void Main(string[] args)
        {
            var ladaFactory = new LadaFactory();
            var ladaClient = new Client(ladaFactory);
            ladaClient.Run();

            var bmwFactory = new BmwFactory();
            var bmwClient = new Client(bmwFactory);
            bmwClient.Run();
        }
    }
}
