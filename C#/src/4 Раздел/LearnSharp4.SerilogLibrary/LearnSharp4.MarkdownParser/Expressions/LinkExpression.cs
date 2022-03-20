using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class LinkExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Link";
        public override char StartsWith { get; protected set; } = '[';
        public override Regex Regex { get; protected set; } = new Regex(@"\[.*?\)");
    }
}
