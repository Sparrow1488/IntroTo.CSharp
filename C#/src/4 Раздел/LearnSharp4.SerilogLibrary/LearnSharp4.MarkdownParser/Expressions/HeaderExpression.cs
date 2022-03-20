using LearnSharp4.MarkdownParser.Enums;
using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal class HeaderExpression : MdExpression
    {
        public override string Name { get; protected set; } = "Header";
        public override Regex Regex { get; protected set; } = new Regex("######(.*)|#####(.*)|####(.*)|###(.*)|##(.*)|#(.*)");
        public int Level { get; internal set; } = 0;
        public override string StartsWith { get; protected set; } = "#";
        public override string EndsWith { get; protected set; } = "\r";
        public override MdExpressionType Type { get; protected set; } = MdExpressionType.Block;

        public override MdExpression Clone()
        {
            var clone = (HeaderExpression)base.Clone();
            clone.Level = Level;
            return clone;
        }
    }
}
