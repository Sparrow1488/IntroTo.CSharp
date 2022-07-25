using OwnTeditor.Enums;

namespace OwnTeditor.Models.Markdown.Blocks
{
    public class Header : BlockItem
    {
        public override DocItemType Type => DocItemType.Header;
    }
}
