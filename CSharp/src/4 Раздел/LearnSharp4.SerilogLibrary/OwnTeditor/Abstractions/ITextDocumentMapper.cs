using OwnTeditor.Models.Markdown;

namespace OwnTeditor.Abstractions
{
    public interface ITextDocumentMapper<TOuterDoc, TOuterItem> : ITextDocumentMapper
    {
    }

    public interface ITextDocumentMapper
    {
        public TextDocument MapDocument<TOuterDoc>(TOuterDoc toMap);
        public DocItem MapItem<TOuterItem>(TOuterItem toMap);
    }
}
