using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class EmptyExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Empty";
        public override char StartsWith { get; protected set; }
        public override Regex Regex { get; protected set; }
    }
}
