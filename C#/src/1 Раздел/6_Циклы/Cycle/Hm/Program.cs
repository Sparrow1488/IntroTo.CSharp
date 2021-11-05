using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            bool checkEnterVolumeNums = true;
            int volumeEnterNums = 0;
            while (checkEnterVolumeNums)
            {
                Console.Write("С каким числом переменных мы будем работать? (max 20) : ");
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= 20)
                {
                    volumeEnterNums = result;
                    checkEnterVolumeNums = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение или количество");
                } 
            }

            List<int> listNums = new List<int>();
            sbyte counterEnterNums = 0;
            while (listNums.Count != volumeEnterNums)
            {
                Console.Write("Введите целое число: ");
                var enterNum = Console.ReadLine();
                if(int.TryParse(enterNum, out int chekedEnterNum))
                {
                    listNums.Add(chekedEnterNum);
                    counterEnterNums++;
                }
                else
                {
                    Console.WriteLine("Вы явно ввели недопустимое число!\nВы можете опирировать только " +
                        "целыми числами");
                }
                Console.WriteLine($"Осталось ввести {volumeEnterNums - counterEnterNums} чисел!");
            }

            Console.Clear();
            Console.WriteLine("Все ваши значения: ");
            foreach (var item in listNums)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(item + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();

            bool checkMathAction = true;
            while (checkMathAction)
            {
                Console.Write("Действие: ");
                string mathAction = Console.ReadLine();
                switch (mathAction)
                {
                    case "сумма":
                        {
                            int sum = 0;
                            for (int i = 0; i < listNums.Count; i++)
                            {
                                sum += listNums[i];
                            }
                            Console.WriteLine(sum);
                            break;
                        }
                    case "разность":
                        {
                            int subStartZero = listNums[0];
                            for (int i = 1; i < listNums.Count; i++)
                            {
                                subStartZero -= listNums[i];
                            }
                            Console.WriteLine(subStartZero);
                            break;
                        }
                    case "произведение":
                        {
                            int multStartZero = listNums[0];
                            for (int i = 1; i < listNums.Count; i++)
                            {
                                multStartZero *= listNums[i];
                            }
                            Console.WriteLine(multStartZero);
                            break;
                        }
                    case "выход":
                        {
                            checkMathAction = false;
                            break;
                        }
                    case "!help":
                        {
                            Console.WriteLine("Команды:\nсуммаы\nразность\nпроизведение\nclear\nвыход ");
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Возможно, то что вы хотите, не существует...");
                            Console.WriteLine("Напишите '!help', чтобы получить список команд");
                            break;
                        }
                }
            }
            

            Console.Write("До связи...");
            Console.ReadKey(true);
        }
    }
}
