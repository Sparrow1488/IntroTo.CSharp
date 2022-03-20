using LearnSharp4.MarkdownParser.Expressions;
using System.Collections.Generic;
using System.Linq;

namespace LearnSharp4.MarkdownParser
{
    internal class Program
    {
        private static void Main()
        {
            string markdownText = "# Header 1\n## Header 2";
            //string markdownText = "[Link](google.com) **bold** **second bold text** <u>underline text</u>";
            var results = MdParser.Parse(markdownText);
        }
    }
}
