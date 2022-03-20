using LearnSharp4.MarkdownParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LearnSharp4.MarkdownParser.Expressions
{
    internal abstract class MdExpression
    {
        public abstract string Name { get; protected set; }
        public abstract char StartsWith { get; protected set; }
        public abstract Regex Regex { get; protected set; }
        public string Value { get; protected set; }
        public string FullValue { get; protected set; }

        public static List<MdExpression> Expressions { get; } = new List<MdExpression>()
        {
            new BoldExpression(),
            new UnderlineExpression(),
            new LinkExpression()
        };

        public static MdText[] ParseUsingTriggers(string text)
        {
            throw new NotImplementedException();
            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];
                var expresses = Expressions.Where(expr => expr.StartsWith == symbol);
                if (expresses.Any())
                {
                }
            }
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
                    if (Name == "Link") HandleAsLink(match);
                    else HandleAsOther(match);
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
            clone.FullValue = FullValue;
            return clone;
        }

        private void HandleAsLink(Match match)
        {
            FullValue = match.Groups[0].Value;
            Value = match.Groups[0].Value;
        }

        private void HandleAsOther(Match match)
        {
            FullValue = match.Groups[0].Value;
            Value = match.Groups[1].Value;
        }
    }
}
