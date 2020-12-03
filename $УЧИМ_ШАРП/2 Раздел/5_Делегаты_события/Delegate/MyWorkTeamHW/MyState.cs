using System;
using System.Collections.Generic;
using System.Text;

namespace MyWorkTeamHW
{
    public class MyState
    {
        public static int myMoney = 10000;
        public static int myPersonal = 1;

        public static void GetMyState()
        {
            Console.WriteLine($"Деньги: {myMoney}");
            Console.WriteLine($"Сотрудники: {myPersonal}");
        }
    }
}
