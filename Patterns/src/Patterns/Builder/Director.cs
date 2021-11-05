namespace Builder
{
    internal class Director
    {
        private PhoneBuilder _builder;
        public Director(PhoneBuilder builder)
        {
            _builder = builder;
        }
        public void Construct()
        {
            _builder.BuildCorpus();
            System.Console.WriteLine("Сделан корпус");
            _builder.BuildDisplay();
            System.Console.WriteLine("Готов дисплей");
            _builder.BuildProcessor();
            System.Console.WriteLine("Запрограммирован процессор");
            _builder.BuildButton();
            System.Console.WriteLine("Готова кнопка");
        }
    }
}
