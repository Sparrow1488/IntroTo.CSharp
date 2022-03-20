using OwnTeditor.Enums;

namespace OwnTeditor.Abstractions
{
    public abstract class TextDocument
    {
        internal TextDocument() { }

        public abstract TextDocumentType Type { get; }

        public T As<T>()
            where T : TextDocument => this as T;
    }
}
