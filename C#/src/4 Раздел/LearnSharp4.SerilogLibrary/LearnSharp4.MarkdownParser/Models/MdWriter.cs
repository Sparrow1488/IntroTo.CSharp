using LearnSharp4.MarkdownParser.DataProviders;
using Microsoft.Toolkit.Parsers.Markdown;
using Microsoft.Toolkit.Parsers.Markdown.Blocks;
using System;

namespace LearnSharp4.MarkdownParser.Models
{
    public static class MdWriter
    {
        public static DynamicDataProvider DynamicProvider { get; set; }

        public static void PrintMdText(MarkdownBlock block)
        {
            if (block.Type == MarkdownBlockType.Paragraph)
            {
                var paragraph = (ParagraphBlock)block;
                foreach (var item in paragraph.Inlines)
                {
                    if (item.Type == MarkdownInlineType.Bold)
                        Print(item, ConsoleColor.Cyan);
                    else if (item.Type == MarkdownInlineType.MarkdownLink)
                        Print(item, ConsoleColor.DarkBlue);
                    else Print(item);
                }
            }
            else if (block.Type == MarkdownBlockType.Header)
                PrintLine(block, ConsoleColor.Red);
            else PrintLine(block);
        }

        public static void Print(object text, ConsoleColor color = ConsoleColor.White)
        {
            string printable = text.ToString();
            if (DynamicProvider != null)
                printable = DynamicProvider.Update(printable);
            Console.ForegroundColor = color;
            Console.Write(printable);
            Console.ResetColor();
        }

        public static void PrintLine(object text, ConsoleColor color = ConsoleColor.White)
        {
            Print(text, color);
            Console.WriteLine();
        }
    }
}
