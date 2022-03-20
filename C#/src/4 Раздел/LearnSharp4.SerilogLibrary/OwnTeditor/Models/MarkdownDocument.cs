using OwnTeditor.Abstractions;
using OwnTeditor.Enums;
using OwnTeditor.Helpers;
using OwnTeditor.Models.Markdown;
using System.Collections.Generic;

namespace OwnTeditor.Models
{
    public class MarkdownDocument : TextDocument
    {
        public override TextDocumentType Type => TextDocumentType.Markdown;
        public IEnumerable<DocItem> Includes { get; }
        private List<DocItem> _includes = new List<DocItem>();

        public MarkdownDocument Add(DocItem item)
        {
            Ex.ThrowIfNullObject(item);
            _includes.Add(item);
            return this;
        }
    }
}
