using OwnTeditor.Enums;
using OwnTeditor.Helpers;
using System.Collections.Generic;

namespace OwnTeditor.Models.Markdown.Blocks
{
    public class Paragraph : BlockItem
    {
        public IEnumerable<DocItem> Includes { get => _includes; }
        public override DocItemType Type => DocItemType.Paragraph;

        private List<DocItem> _includes = new List<DocItem>();

        public Paragraph Add(DocItem docItem)
        {
            Ex.ThrowIfNullObject(docItem);
            _includes.Add(docItem);
            return this;
        }

        public override string ToString() => string.Join("", _includes);
    }
}
