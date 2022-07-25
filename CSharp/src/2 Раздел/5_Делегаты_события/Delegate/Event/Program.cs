using System;

namespace Event
{
    class Program
    {
        public delegate void MyDelegate();
        public event MyDelegate Event; //создается событие в поле класса

        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Олег"
            };
            person.GoToSleep += Person_GoToSleep; //подписались на событие
            person.GoWork += Person_GoWork; ; //подписались на событие
            person.ControlPerson(DateTime.Parse("02.12.2020 7:50")); //вызвали событие у объекта, оно выполнилось, но тк мы не подписались на него, мы не смогли отследить изменения
        }

        private static void Person_GoWork(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Name} работает"); //не безопасное приведение типов. такое лучше переделывать
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("человек спит");
        }
    }
}
