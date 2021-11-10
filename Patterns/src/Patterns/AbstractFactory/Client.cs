namespace AbstractFactory
{
    internal class Client
    {
        private AbstractCarFactory _factory;
        private AbstractCorps _corps;
        private AbstractTransmission _transmission;
        private AbstractWeels _weels;
        public Client(AbstractCarFactory factory)
        {
            _factory = factory;
        }
        public void Run()
        {
            _corps = _factory.CreateCorps();
            _transmission = _factory.CreateTransmission();
            _weels = _factory.CreateWeels();
            _transmission.Interact(_weels);
            _corps.Interact(_transmission);
            System.Console.WriteLine("Сборка окончена");
        }
    }
}
