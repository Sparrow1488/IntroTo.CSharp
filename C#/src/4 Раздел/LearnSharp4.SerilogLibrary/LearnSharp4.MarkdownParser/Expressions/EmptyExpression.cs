using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class EmptyExpression : MdExpression
    {
        public override string Name { get; protected set; }
        public override Regex Regex { get; protected set; }
        public override string Starts { get; protected set; }
        public override string Ends { get; protected set; }
    }
}
