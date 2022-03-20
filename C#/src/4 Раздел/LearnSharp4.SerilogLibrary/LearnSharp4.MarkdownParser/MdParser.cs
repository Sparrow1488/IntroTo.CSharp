using LearnSharp4.MarkdownParser.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnSharp4.MarkdownParser
{
    internal static class MdParser
    {
        public static MdExpression[] Parse(string row)
        {
            var results = new List<MdExpression>();
            foreach (var express in MdExpression.Expressions)
            {
                var parsed = express.TryParse(row).Where(expr => !string.IsNullOrWhiteSpace(expr.Value));
                foreach (var parsedExpr in parsed)
                {
                    row = row.Replace(parsedExpr.FullValue, "");
                    results.Add(express);
                }
            }
            return results.ToArray();
        }

        internal static MdExpression[] ParseDocument(string sampleText)
        {
            var results = new List<MdExpression>();
            var lines = sampleText.Split('\n');

            var exprBlocks = MdExpression.Expressions.Where(ex => ex.Type == Enums.MdExpressionType.Block);
            foreach (var line in lines)
            {
                var similarBlockExpression = exprBlocks.FirstOrDefault(expr => line.StartsWith(expr.StartsWith));
                if (similarBlockExpression != null)
                    results.AddRange(HandleBlock(line, similarBlockExpression));
                else results.AddRange(HandleInline(line));
            }
            return results.ToArray();
        }

        private static IEnumerable<MdExpression> HandleInline(string line)
        {
            throw new NotImplementedException();
        }

        private static MdExpression[] HandleBlock(string block, MdExpression similarBlock)
        {
            throw new NotImplementedException();
            var blockEndIndex = block.IndexOf(similarBlock.EndsWith, similarBlock.StartsWith.Length);
        }
    }
}
