using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp4.TestableLibrary
{
    public class UserManager
    {
        public void AddUser(string name, string mail)
        {
            if (name is null || mail is null)
                throw new ArgumentNullException();

            if (name.Length < 1)
                throw new ArgumentException("Invalid name value");
            if (!mail.Contains("@"))
                throw new ArgumentException("Invalid mail value");
        }

        public bool TryAddUser(string name, string mail)
        {
            bool result = true;
            if (name is null || mail is null)
                throw new ArgumentNullException();

            if (name.Length < 1)
                result = false;
            if (!mail.Contains("@"))
                result = false;

            return result;
        }
    }
}
