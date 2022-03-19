using LearnSharp4.MarkdownParser.Expressions;
using System;

namespace LearnSharp4.MarkdownParser
{
    internal class Program
    {
        private static void Main()
        {
            // string markdownText = "# Header 1\n**Hello MdParser!**\nVisit my [page](google.com)";
            string markdownText = "**bold** **second bold text** ** and    second ahahahah **";
            var expression = MdExpression.Parse(markdownText);
        }
    }
}
