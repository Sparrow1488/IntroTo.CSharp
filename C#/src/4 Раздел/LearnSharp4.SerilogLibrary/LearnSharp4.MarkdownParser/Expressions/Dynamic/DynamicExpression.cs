using Microsoft.Toolkit.Parsers.Markdown.Blocks;

namespace LearnSharp4.MarkdownParser.Expressions.Dynamic
{
    public class DynamicExpression
    {
        public DynamicExpression(string name)
        {
            Name = name;
        }

        public string Name { get; internal set; }
        public string Value { get; internal set; }
    }
}
