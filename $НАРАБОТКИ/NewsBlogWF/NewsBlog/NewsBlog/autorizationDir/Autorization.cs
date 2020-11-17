using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsBlog.autorizationDir
{
    public class Autorization
    {
        public static string[,] UsersDB { get; private set; } =
        {
            {"Sparrow14", "1234" },
            {"User", "222" },
            {"Dimon12", "3434" },
            {"Gokhlia", "1488" },
        };

        public static bool loginCreator { get; private set; } = false;

        private static string[,] Creators =
        {
            {"Sparrow14", "1234" },
            {"Gokhlia", "1488" }
        };

        public static bool CheckUsers(TextBox login, TextBox pass)
        {
            for (int i = 0; i < UsersDB.GetLength(0); i++)
            {
                if (login.Text == UsersDB[i, 0])
                {
                    if (pass.Text == UsersDB[i, 1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool CheckCreators(TextBox log, TextBox pas)
        {
            for (int i = 0; i < Creators.GetLength(0); i++)
            {
                if (log.Text == Creators[i,0])
                {
                    if (pas.Text == Creators[i,1])
                    {
                        loginCreator = true;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
