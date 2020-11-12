using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP2_WF
{
    public class Profile
    {
        private static string _name;
        private static string _secondName;
        private static string _number;
        private static string _email;
        private static bool _getStocks = true; //получать уведомления

        //public Profile(string name, string secondName, string number)
        //{
        //    _name = name;
        //    _secondName = secondName;
        //    _number = number;
        //}

        public void StartCreateProfile(string name, string secondName, string number)
        {
            _name = name;
            _secondName = secondName;
            _number = number;
        }

        public string Name { get; }
        public string SecondName { get; }
        public string Number { get; }
        public string FullName { get { return _secondName + " " + _name; } }
        
    }
}
