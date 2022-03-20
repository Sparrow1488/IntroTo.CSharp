using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class HeaderExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Header";
        public override char StartsWith { get; protected set; }
        public override Regex Regex { get; protected set; } = new Regex("######(.*)|#####(.*)|####(.*)|###(.*)|##(.*)|#(.*)");
        public int Level { get; internal set; } = 0;

        public override MdExpression Clone()
        {
            var clone = (HeaderExpression)base.Clone();
            clone.Level = Level;
            return clone;
        }
    }
}
