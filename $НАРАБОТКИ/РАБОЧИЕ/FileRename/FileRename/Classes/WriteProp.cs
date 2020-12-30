using System;

namespace FileRename
{
    class WriteProp
    {
        public static void SetColorAndWrite(string mess, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(mess);
            Console.ResetColor();
        }
    }
}
