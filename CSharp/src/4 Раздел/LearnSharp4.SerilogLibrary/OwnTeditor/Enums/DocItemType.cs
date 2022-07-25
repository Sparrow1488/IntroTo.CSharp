namespace OwnTeditor.Enums
{
    public class DocItemType
    {
        internal DocItemType(string typeName, DocItemLevelType level)
        {
            Type = typeName;
            Level = level;
        }

        public readonly string Type;
        public readonly DocItemLevelType Level;

        public static DocItemType Bold = new DocItemType(nameof(Bold), DocItemLevelType.Inline);
        public static DocItemType Link = new DocItemType(nameof(Link), DocItemLevelType.Inline);
        public static DocItemType Default = new DocItemType(nameof(Default), DocItemLevelType.Inline);
        public static DocItemType Underline = new DocItemType(nameof(Underline), DocItemLevelType.Inline);

        public static DocItemType Header = new DocItemType(nameof(Header), DocItemLevelType.SealedBlock);
        public static DocItemType Paragraph = new DocItemType(nameof(Paragraph), DocItemLevelType.Block);
    }
}
