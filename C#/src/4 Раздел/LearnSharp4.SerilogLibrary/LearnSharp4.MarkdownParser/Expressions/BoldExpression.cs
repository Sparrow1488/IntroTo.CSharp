using LearnSharp4.MarkdownParser.Enums;
using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class BoldExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Bold";
        public override Regex Regex { get; protected set; } = new Regex(@"\*\*(.*?)\*\*");
        public override string StartsWith { get; protected set; } = "**";
        public override string EndsWith { get; protected set; } = "**";
        public override MdExpressionType Type { get; protected set; } = MdExpressionType.Inline;
    }
}
