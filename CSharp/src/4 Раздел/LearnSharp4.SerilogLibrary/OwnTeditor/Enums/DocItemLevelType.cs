namespace OwnTeditor.Enums
{
    public class DocItemLevelType
    {
        internal DocItemLevelType(string levelName)
        {
            LevelName = levelName;
        }

        public readonly string LevelName;

        public static DocItemLevelType Block = new DocItemLevelType(nameof(Block));
        public static DocItemLevelType Inline = new DocItemLevelType(nameof(Inline));
        /// позиционирует себя как блок, но не может хранить в себе другие элементы
        public static DocItemLevelType SealedBlock = new DocItemLevelType(nameof(SealedBlock)); 
    }
}
