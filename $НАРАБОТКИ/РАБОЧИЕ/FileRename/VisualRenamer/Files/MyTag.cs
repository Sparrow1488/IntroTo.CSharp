using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VisualRenamer.Files
{
    public class MyTag
    {
        public static List<MyTag> tagsList = new List<MyTag>();

        public string name;

        public MyTag(string tagName)
        {
            name = tagName;
            tagsList.Add(this);
        }
        public static MyTag[] CreateStandartTags()
        {
            string path = @"G:\фильмс\sfm\$отдельно sfm\отсторт";
            DirectoryInfo[] directs = new DirectoryInfo(path).GetDirectories();
            var tagArr = new MyTag[directs.Length];

            for (int i = 0; i < directs.Length; i++)
            {
                tagArr[i] = new MyTag($"[{directs[i].Name}]");
            }
            return tagArr;
        }
        
        public static bool HasTag(string tagName)
        {
            foreach (var tag in tagsList)
            {
                if (tag.Equals(tagName))
                    return true;
            }
            return false;
        }
        public static void ShowTagCollection(ListBox tagsList, TagCollection collection)
        {
            if (collection == null)
                throw new ArgumentException("Вы пытаетесь найти несуществующую коллекцию");

            tagsList.Items.Clear();
            foreach (var tag in collection.collection)
                tagsList.Items.Add(tag.name);
        }
        public static void ShowAllTags(ListBox tagsLB)
        {
            tagsLB.Items.Clear();
            foreach (var tag in tagsList)
                tagsLB.Items.Add(tag.name);
        }
        public static void Delete(string tagName) //TODO: не работает delete
        {
            foreach (var tag in tagsList)
            {
                if (tag.name.Equals(tagName))
                    tagsList.Remove(tag);
            }
        }
    }
}
