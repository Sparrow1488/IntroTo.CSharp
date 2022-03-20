using OwnTeditor.Abstractions;
using OwnTeditor.Mappers;
using OwnTeditor.Models;
using OwnTeditor.Parsers;
using System.IO;

namespace OwnTeditor
{
    internal class Program
    {
        private static void Main()
        {
            ITextDocumentMapper mapper = new MarkdownDocumentMapper();
            ITextParserAdapter parser = new MarkdownParser(mapper);
            TextDocument textDocument = parser.ParseDocument(GetText("./SampleData/Paragraph-1.md"));
            MarkdownDocument document = textDocument.As<MarkdownDocument>();
        }

        private static string GetText(string path) => File.ReadAllText(path);
    }
}
