using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class Program
    {
        static void showStartGame()
        {
            Console.WriteLine("У Вас в распаряжении один завод и одна шахта");
            Console.WriteLine("Производите, покупайте, нанимайте, конструируйте и продавайте!");
            Console.WriteLine("Напишите start, чтобы начать игру!");
            bool startGame = true;
            while (startGame)
            {
                string enterStartWord = Console.ReadLine();
                switch (enterStartWord)
                {
                    case "start":
                        {
                            Console.Clear();
                            startGame = false;
                            break;
                        }
                    case "exit":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Если вы не готовы, можете выйти: exit");
                            break;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            showStartGame();
            
            Console.WriteLine("Чтобы начать, вам необходимо преобрести персонал.\nСделать это можно в магазине: shop");
            while (true)
            {
                Console.Write("Вы в главном разделе. Ваша команда:");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "infomine":
                        {
                            Mine.showInfoMines();
                            break;
                        }
                    case "infoplant":
                        {
                            Plant.showInfoPlant();
                            break;
                        }
                    case "shop":
                        {
                            Console.WriteLine("В какой раздел магазина Вы хотите отправиться?");
                            string shopEnter = Console.ReadLine();
                            switch (shopEnter)
                            {
                                case "infoshop":
                                    {
                                        Shop.infoShop();
                                        break;
                                    }
                                    //приобрести персонал
                                case "personal":
                                    {
                                        Console.Write("Выберите направленность: ");
                                        string typeSpec = Console.ReadLine();
                                        Shop.buyPersonalSpecific(typeSpec);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "myInfo":
                        {
                            StateProduction.showInfoBuisnes();
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                    case "work main":
                        {
                            Console.WriteLine("Сколько работать: ");
                            int workHours = int.Parse(Console.ReadLine());
                            Mine.workMine(workHours);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
