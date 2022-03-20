using LearnSharp4.MarkdownParser.Enums;
using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class UnderlineExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Underline";
        public override Regex Regex { get; protected set; } = new Regex(@"<u>(.*?)</u>");
        public override string StartsWith { get; protected set; } = "<u>";
        public override string EndsWith { get; protected set; } = "</u>";
        public override MdExpressionType Type { get; protected set; } = MdExpressionType.Inline;
    }
}
