using System;

namespace MyWorkTeamHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.GoWork += Person1_GoWork;
            person1.GoSleep += Person1_GoSleep;
            person1.GoEatDinner += Person1_GoEatDinner;
            while (true)
            {
                Console.Write("Ваша команда: ");
                string command = Console.ReadLine();
                person1.ControlPerson(command);
            }
        }

        private static void Person1_GoEatDinner()
        {
            Console.WriteLine("Челик кушоит");
        }

        private static void Person1_GoSleep()
        {
            Console.WriteLine("Челик спит");
        }

        private static void Person1_GoWork()
        {
            Console.WriteLine("Челик работает на заводе");
        }
    }
}
