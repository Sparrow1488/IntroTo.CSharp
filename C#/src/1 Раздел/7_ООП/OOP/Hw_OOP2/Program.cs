using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в магазин!\nЖелаете завести профиль или перейти к покупкам?");
            string nameUser = Console.ReadLine();
            string secondNameUser = Console.ReadLine();
            string phoneNumberUser = Console.ReadLine();
            Profile profile1 = new Profile(nameUser, secondNameUser, phoneNumberUser);
            profile1.GetInfoProfile();
            Console.WriteLine(profile1.FullName);
            Console.ReadKey();
        }
    }
}
