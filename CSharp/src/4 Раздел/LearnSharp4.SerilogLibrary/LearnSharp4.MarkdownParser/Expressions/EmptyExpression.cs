using LearnSharp4.MarkdownParser.Enums;
using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class EmptyExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Empty";
        public override Regex Regex { get; protected set; }
        public override string StartsWith { get; protected set; }
        public override string EndsWith { get; protected set; }
        public override MdExpressionType Type { get; protected set; } = MdExpressionType.Inline;
    }
}
