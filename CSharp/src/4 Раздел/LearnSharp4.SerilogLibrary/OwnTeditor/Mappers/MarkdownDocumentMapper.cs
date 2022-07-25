using Microsoft.Toolkit.Parsers.Markdown;
using OwnTeditor.Abstractions;
using OwnTeditor.Models.Markdown;
using ToolKitBlock = Microsoft.Toolkit.Parsers.Markdown.Blocks.MarkdownBlock;
using ToolKitDocument = Microsoft.Toolkit.Parsers.Markdown.MarkdownDocument;
using OwnMdDocument = OwnTeditor.Models.MarkdownDocument;
using OwnTeditor.Models.Markdown.Blocks;

namespace OwnTeditor.Mappers
{
    public class MarkdownDocumentMapper : ITextDocumentMapper<ToolKitDocument, ToolKitBlock>, ITextDocumentMapper
    {
        public TextDocument MapDocument(ToolKitDocument toMap)
        {
            OwnMdDocument resultDocument = new OwnMdDocument();
            foreach (var block in toMap.Blocks)
            {
                // временный костыль
                if (block.Type == MarkdownBlockType.Header)
                    resultDocument.Add(new Header().SetValue(block.ToString()));
                if (block.Type == MarkdownBlockType.Paragraph)
                    resultDocument.Add(new Paragraph().SetValue(block.ToString()));
            }
            return resultDocument;
        }

        public TextDocument MapDocument<TOuterDoc>(TOuterDoc toMap) => MapDocument(toMap);

        public DocItem MapItem(ToolKitBlock toMap)
        {
            throw new System.NotImplementedException();
        }

        public DocItem MapItem<TOuterItem>(TOuterItem toMap) => MapItem(toMap);
    }
}
