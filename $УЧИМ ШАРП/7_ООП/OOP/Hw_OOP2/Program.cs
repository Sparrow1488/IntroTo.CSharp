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
            Console.WriteLine("Создать (1) / К покупкам (2)");
            while (true)
            {
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        {
                            Console.Write("Ваше имя: ");
                            string _setName = Console.ReadLine();
                            Console.Write("Ваша фамилия: ");
                            string _setSecondName = Console.ReadLine();
                            Console.Write("Ваш телефон: ");
                            string _phoneNumber = Console.ReadLine();
                            Profile prof1 = new Profile(_setName, _setSecondName, _phoneNumber);
                            Console.WriteLine($"Поздравляем {prof1.FullName}, Вы создали свой профиль!");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("///Магазин");
                            break;
                        }
                    case "профиль":
                        {
                            break;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("Вы не выбрали!");
                        Console.WriteLine("Создать (1) / К покупкам (2)");
                        break;
                }

            }
            
            //string _setNumber = Console.ReadLine();
            //Console.Write("Ваша почта: ");
            //string _setEmail = Console.ReadLine();
            //Console.Write("Уведомления (по желанию) (да/нет): ");
            //string _stocks = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
