using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal abstract class MdExpression
    {
        public abstract string Name { get; protected set; }
        public abstract Regex Regex { get; protected set; }
        public abstract string Starts { get; protected set; }
        public abstract string Ends { get; protected set; }
        public string Value { get; protected set; }
        public static List<MdExpression> Expressions { get; } = new List<MdExpression>()
        {
            new BoldExpression()
        };

        public static MdExpression[] Parse(string row)
        {
            var expressions = new List<MdExpression>();
            foreach (var express in Expressions)
            {
                var parsed = express.TryParse(row).Where(expr => !string.IsNullOrWhiteSpace(expr.Value));
                expressions.AddRange(parsed);
            }
            return expressions.ToArray();
        }

        public virtual MdExpression[] TryParse(string row)
        {
            var founds = new List<MdExpression>();
            var matches = Regex.Matches(row);
            for (int i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                if (match.Success)
                {
                    Value = match.Groups[1].Value;
                    founds.Add(Clone());
                }
            }
            return founds.ToArray();
        }

        public virtual MdExpression Clone()
        {
            var type = GetType();
            var clone = (MdExpression)type.Assembly.CreateInstance(type.FullName);
            clone.Value = Value;
            return clone;
        }
    }
}
