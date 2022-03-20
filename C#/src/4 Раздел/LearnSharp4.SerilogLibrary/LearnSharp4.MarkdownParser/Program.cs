namespace LearnSharp4.MarkdownParser
{
    internal class Program
    {
        private static void Main()
        {
            // string markdownText = "# Header 1\n**Hello MdParser!**\nVisit my [page](google.com)";
            string markdownText = "[Link](google.com) **bold** **second bold text** <u>underline text</u>";
            var results = MdParser.Parse(markdownText);
        }
    }
}
