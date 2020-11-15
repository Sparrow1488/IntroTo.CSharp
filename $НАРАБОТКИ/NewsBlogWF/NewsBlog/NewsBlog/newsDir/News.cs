using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsBlog
{
    public class News
    {
        public static string[,] NewsDB { get; private set; } = new string[4,2];

        public static void setStandartNews()
        {
            NewsDB[0, 0] = "Платформа Microsoft .NET";
            NewsDB[0, 1] = "Это комплекс программ, устанавливаемый поверх операционной системы и обеспечивающий выполнение программ, написанных специально для .NET.";
            NewsDB[1, 0] = "Как работает .NET";
            NewsDB[1, 1] = "В результате компиляции .NET-программы генерируется не машинный код, а так называемый байт-код, содержащий команды виртуальной машины (в .NET он называется IL-кодом от англ. Intermediate Language - промежуточный язык). Команды байт-кода не зависят от процессора и используемой операционной системы. При запуске программа, содержащая IL-код, подается на вход виртуальной машины, которая и производит выполнение программы. Часть виртуальной машины, называемая JIT-компилятором (Just In Time - непосредственно в данный момент), сразу после запуска .NET-программы переводит ее промежуточный код в машинный (проводя при этом его оптимизацию), после чего запускает программу на исполнение. Если быть точными, то промежуточный код переводится в машинный частями по мере выполнения программы.";
            NewsDB[2, 0] = "Современный язык программирования Object Pascal";
            NewsDB[2, 1] = "Язык PascalABC.NET включает в себя практически весь стандартный язык Паскаль, а также большинство языковых расширений языка Delphi. Однако, этих средств недостаточно для современного программирования. Именно поэтому PascalABC.NET расширен рядом конструкций, а его стандартный модуль - рядом подпрограмм, типов и классов, что позволяет создавать легко читающиеся приложения средней сложности.";
        }
        public static int indexCounter = 0; 
        public static void PrintNews(Label title, TextBox text)
        {
            if (indexCounter < NewsDB.GetLength(0))
            {
                title.Text = $"{NewsDB[indexCounter, 0]}";
                text.Text = $"   {NewsDB[indexCounter, 1]}";
            }
        }
        public static void ScrollNewsLeft(Label tit, TextBox text)
        {
            if (indexCounter <= NewsDB.GetLength(0) && indexCounter != 0)
            {
                indexCounter--;
                PrintNews(tit, text);
            }
            else
            {
                indexCounter = NewsDB.GetLength(0) - 1;
                PrintNews(tit, text);
            }
        }
        public static void ScrollNewsRight(Label tit, TextBox text)
        {
            if (indexCounter < (NewsDB.GetLength(0) - 1) && NewsDB[indexCounter + 1,0] != null)
            {
                indexCounter++;
                PrintNews(tit, text);
            }
            else
            {
                indexCounter = 0;
                PrintNews(tit, text);
            }
        }


        public static bool AddNews(TextBox title, TextBox text, Label exeption)
        {
            string _title = CheckTitle(title.Text);
            string _text = CheckText(text.Text);
            if (_title != "0" && _text != "0")
            {
                int lastIndex = NewsDB.GetLength(0);
                NewsDB[3, 0] = _title;
                NewsDB[3, 1] = _text;
                return true;
            }
            else
            {
                exeption.Visible = true;
                return false;
            }
        }

        public static string CheckTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                return title;
            }
            return "0";
        }
        public static string CheckText(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                return text;
            }
            return "0";
        }
    }
}
