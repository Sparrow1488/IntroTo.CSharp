using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualRenamer.Files
{
    public class TagCollection
    {
        public static List<TagCollection> allCollections = new List<TagCollection>();
        public List<MyTag> collection = new List<MyTag>();

        public string name;
        public TagCollection(MyTag[] baseTags, string name)
        {
            if (baseTags.Length <= 0 && string.IsNullOrEmpty(name))
                throw new ArgumentException("Пустые данные");

            this.name = name;
            allCollections.Add(this);
            var findCol = FindCollectionByName(name);
            AddTags(baseTags, findCol);
        }
        public TagCollection(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Пустые данные");

            this.name = name;
            allCollections.Add(this);
        }
        private void AddTags(MyTag[] tags, TagCollection collection)
        {
            if (tags.Length <= 0)
                throw new ArgumentException("Вы пытаетесь добавить пустое кол-во тегов");
            foreach (var tag in tags)
                collection.collection.Add(tag);
        }
        public static TagCollection FindCollectionByName(string name)
        {
            foreach (var collection in allCollections)
            {
                if (collection.name.Equals(name))
                    return collection;
            }
            return null;
        }
        public static void ShowAll(ListBox lb)
        {
            lb.Items.Clear();
            foreach (var col in allCollections)
                lb.Items.Add(col.name);
        }
        public static void Add(TagCollection collection, MyTag tag)
        {
            if (collection == null)
                throw new ArgumentException("Вы передали пустую коллекцию");
            if(tag == null)
                throw new ArgumentException("Вы передали несуществующий тег");
            collection.collection.Add(tag);
        }
    }
}
