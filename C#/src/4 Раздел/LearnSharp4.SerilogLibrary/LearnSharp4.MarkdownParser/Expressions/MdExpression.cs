using LearnSharp4.MarkdownParser.Enums;
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
        public abstract string StartsWith { get; protected set; }
        public abstract string EndsWith { get; protected set; }
        public abstract MdExpressionType Type { get; protected set; }
        public abstract Regex Regex { get; protected set; }
        public string Value { get; protected set; }
        public string FullValue { get; protected set; }

        public static List<MdExpression> Expressions { get; } = new List<MdExpression>()
        {
            new BoldExpression(),
            new UnderlineExpression(),
            new LinkExpression(),
            new HeaderExpression()
        };

        public virtual MdExpression[] TryParse(string row)
        {
            var founds = new List<MdExpression>();
            var matches = Regex.Matches(row);
            for (int i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                if (match.Success)
                {
                    if (Name == "Link") InitMatchAsLink(match);
                    if (Name == "Header") InitMatchAsHeader(match);
                    else InitMatch(match);
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

        private void InitMatchAsLink(Match match)
        {
            FullValue = match.Groups[0].Value;
            Value = match.Groups[0].Value;
        }

        private void InitMatchAsHeader(Match match)
        {
            var normalizedGroup = match.Groups.Values.Skip(1).Reverse().ToArray();
            var notEmptyGroup = normalizedGroup.Where(group => !string.IsNullOrWhiteSpace(group.Value)).FirstOrDefault();
            var headerLvl = Array.IndexOf(normalizedGroup, notEmptyGroup) + 1;
            var headerExpression = (HeaderExpression)this;
            FullValue = match.Groups[0].Value;
            Value = notEmptyGroup.Value;
            headerExpression.Level = headerLvl;
        }

        private void InitMatch(Match match)
        {
            FullValue = match.Groups[0].Value;
            Value = match.Groups[1].Value;
        }
    }
}
