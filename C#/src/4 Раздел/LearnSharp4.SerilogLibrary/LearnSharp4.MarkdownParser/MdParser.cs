using LearnSharp4.MarkdownParser.Expressions;
using LearnSharp4.MarkdownParser.Models;
using System.Collections.Generic;
using System.Linq;

namespace LearnSharp4.MarkdownParser
{
    internal static class MdParser
    {
        public static MdText[] Parse(string row)
        {
            var results = new List<MdText>();
            foreach (var express in MdExpression.Expressions)
            {
                var parsed = express.TryParse(row).Where(expr => !string.IsNullOrWhiteSpace(expr.Value));
                foreach (var parsedExpr in parsed)
                {
                    row = row.Replace(parsedExpr.FullValue, "");
                    results.Add(new MdText(parsedExpr.Value, new string[] { parsedExpr.Name }));
                }
            }
            return results.ToArray();
        }
    }
}
