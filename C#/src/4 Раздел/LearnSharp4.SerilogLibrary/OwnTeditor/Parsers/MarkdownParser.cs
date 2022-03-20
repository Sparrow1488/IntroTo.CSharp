using OwnTeditor.Abstractions;
using OwnTeditor.Helpers;
using ToolKitDocument = Microsoft.Toolkit.Parsers.Markdown.MarkdownDocument;

namespace OwnTeditor.Parsers
{
    public sealed class MarkdownParser : ITextParserAdapter
    {
        public MarkdownParser(ITextDocumentMapper documentMapper)
        {
            _documentMapper = documentMapper;
        }

        private ITextDocumentMapper _documentMapper;

        public TextDocument ParseDocument(string text)
        {
            Ex.ThrowIfEmptyOrNull(text);
            ToolKitDocument document = new ToolKitDocument();
            document.Parse(text);
            return _documentMapper.MapDocument(document);
        }
    }
}
