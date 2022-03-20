using LearnSharp4.MarkdownParser.DataProviders;
using LearnSharp4.MarkdownParser.Expressions.Dynamic;
using LearnSharp4.MarkdownParser.Models;
using Microsoft.Toolkit.Parsers.Markdown;
using Microsoft.Toolkit.Parsers.Markdown.Blocks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearnSharp4.MarkdownParser
{
    internal class Program
    {
        private static void Main()
        {
            string sampleText = File.ReadAllText("./MdText/Paragraph-1.md");
            MarkdownDocument document = new MarkdownDocument();
            document.Parse(sampleText);
            MdParser.ParseDocument(sampleText);

            var @dynamic = new DynamicExpression("date-now");
            var dynamicDataProvider = new DynamicDataProvider(@dynamic).FromFile("./MdText/DynamicExample-1.txt");
            MdWriter.DynamicProvider = dynamicDataProvider;

            foreach (var element in document.Blocks)
            {
                MdWriter.PrintMdText(element);
            }

            for (int i = 0; i < 3; i++)
                Console.WriteLine();
        }
    }
}
