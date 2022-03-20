using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class BoldExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Bold";
        public override Regex Regex { get; protected set; } = new Regex(@"\*\*(.*?)\*\*");
        public override char StartsWith { get; protected set; } = '*';
    }
}
