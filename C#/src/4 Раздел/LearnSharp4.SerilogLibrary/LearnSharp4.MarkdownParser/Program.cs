using LearnSharp4.MarkdownParser.Models;
using Microsoft.Toolkit.Parsers.Markdown;
using System;
using System.IO;

namespace LearnSharp4.MarkdownParser
{
    internal class Program
    {
        private static void Main()
        {
            string sampleText = File.ReadAllText("./MdText/Paragraph-1.md");
            MarkdownDocument document = new MarkdownDocument();
            document.Parse(sampleText);

            foreach (var element in document.Blocks)
                MdWriter.PrintMdText(element);

            for (int i = 0; i < 3; i++)
                Console.WriteLine();
        }
    }
}
