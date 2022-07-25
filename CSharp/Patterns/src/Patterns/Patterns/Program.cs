using System;
using System.Collections;

namespace Patterns
{
    class Program
    {
        private static Document doc;
        static void Main(string[] args)
        {
            doc = new Document();
            doc.Changes += (string message) => Console.WriteLine(message);
            doc.AddBlock("Я хочу пиццу, чтобы была очень вкусная");
            doc.SetFontSize(18);

            var history = new EditorHistory();
            history.Changes += (string message) => Console.WriteLine(message);
            history.Push(doc.SaveState());

            doc.AddBlock("А еще роллов хочу, если уж быть честным!!!");
            doc.SetFontSize(36);
            history.Push(doc.SaveState());

            doc.RestoreState(history.Pop());// версия 2
            doc.Print();
            doc.RestoreState(history.Pop());// версия 1
            doc.Print();

        }
    }
}
