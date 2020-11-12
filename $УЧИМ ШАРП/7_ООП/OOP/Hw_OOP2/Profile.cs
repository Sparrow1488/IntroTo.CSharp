using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_OOP2
{
    public class Profile
    {
        private static string _name;
        private static string _secondName;
        private static string _number;
        private static string _email;
        private static bool _getStocks = true; //получать уведомления

        public Profile(string name, string secondName, string number)
        {
            _name = name;
            _secondName = secondName;
            _number = number;
        }

        public void StartCreateProfile() { 
}

        public string Name { get; }
        public string SecondName { get; }
        public string Number { get; }
        public string FullName { get { return _secondName + " " + _name; } }
        public void GetInfoProfile()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_secondName);
            Console.WriteLine(_number);
            Console.WriteLine(_email);
            Console.WriteLine("Уведомления: " + _getStocks);
        }
    }
}
