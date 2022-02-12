using System;
using System.IO;

namespace LearnSharp4.TestableLibrary
{
    public class HtmlBuilder
    {
        private string _outHtml = string.Empty;

        public void CreateBlockWithText(string text, DateTime date)
        {
            var template = File.ReadAllText("./template.txt");
            template = template.Replace("{text}", text);
            template = template.Replace("{date}", date.ToString());
            _outHtml = template;
        }

        public string Build()
        {
            return _outHtml;
        }
    }
}
