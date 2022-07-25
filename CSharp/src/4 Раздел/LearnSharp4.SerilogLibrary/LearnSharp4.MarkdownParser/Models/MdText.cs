using System.Collections.Generic;

namespace LearnSharp4.MarkdownParser.Models
{
    internal class MdText
    {
        public MdText(string text, IEnumerable<string> styles)
        {
            Text = text;
            Styles = styles;
        }

        public string Text { get; }
        public IEnumerable<string> Styles { get; }
    }
}
