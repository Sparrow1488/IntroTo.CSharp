using OwnTeditor.Enums;

namespace OwnTeditor.Models.Markdown
{
    public abstract class DocItem
    {
        public abstract DocItemType Type { get; }
        public string Value { get; private set; }

        public DocItem SetValue(string value)
        {
            if (value == null)
                Value = string.Empty;
            else Value = value;
            return this;
        }
    }
}
