using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class UnderlineExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Underline";
        public override Regex Regex { get; protected set; } = new Regex(@"<u>(.*?)</u>");
    }
}
