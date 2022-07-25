namespace OwnTeditor.Abstractions
{
    public interface ITextParserAdapter
    {
        TextDocument ParseDocument(string text);
    }
}
