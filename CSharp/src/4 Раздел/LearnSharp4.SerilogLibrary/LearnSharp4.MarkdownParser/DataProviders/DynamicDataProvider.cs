using LearnSharp4.MarkdownParser.Expressions.Dynamic;
using System.IO;

namespace LearnSharp4.MarkdownParser.DataProviders
{
    public class DynamicDataProvider
    {
        public DynamicDataProvider(DynamicExpression expression)
        {
            Expression = expression;
        }

        public DynamicExpression Expression { get; }
        private string _fileDataPath = string.Empty;

        public DynamicDataProvider FromFile(string filePath)
        {
            _fileDataPath = filePath;
            return this;
        }

        public string Update(string source)
        {
            Expression.Value = File.ReadAllText(_fileDataPath);
            string toReplace = "${" + Expression.Name + "}";
            var newValue = source.Replace(toReplace, Expression.Value);
            return newValue;
        }
    }
}
