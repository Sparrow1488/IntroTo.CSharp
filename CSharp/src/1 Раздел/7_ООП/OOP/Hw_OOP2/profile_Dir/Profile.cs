using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_OOP2
{
    public class Profile
    {
        private string _name;
        private string _secondName;
        private string _number;
        private string _email = "not";
        private bool _getStocks = true; //получать уведомления

        public Profile(string name, string secondName, string number)
        {
            _name = checkName(name);
            _secondName = checkSecondName(secondName);
            _number = checkNumberPhone(number);
        }
        private static string checkName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            return "not found";
        }
        private static string checkSecondName(string secondName)
        {
            if (!string.IsNullOrWhiteSpace(secondName))
            {
                return secondName;
            }
            return "not found";
        }
        private static string checkNumberPhone(string number)
        {
            if (!string.IsNullOrWhiteSpace(number))
            {
                return number;
            }
            return "not found";
        }
        public string Name { get; }
        public string SecondName { get; }
        public string Number { get; }
        public string FullName { get { return _secondName + " " + _name; } }
        public void GetInfoProfile()
        {
            Console.WriteLine("Имя: " + _name);
            Console.WriteLine("Фамилия: " + _secondName);
            Console.WriteLine("Телефон: " + _number);
            Console.WriteLine("Email: " + _email);
            //string a = _getStocks ? true : false;
            Console.WriteLine("Уведомления: " + _getStocks);
        }

        //private static void checkBool
    }
}
