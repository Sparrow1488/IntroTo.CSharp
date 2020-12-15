using System;
using System.Collections.Generic;
using ConsoleTagsSortApplication.Commands;

namespace ConsoleTagsSortApplication.Tags
{
    public abstract class Tag
    {
        public string tagName;
        public static List<Tag> tagsAll = new List<Tag>();
        public Tag()
        {
            if (!CheckTagNameInList(tagName))
                tagsAll.Add(this);
        }

        public static void ShowAllTags()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Все теги:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var tag in tagsAll)
            {
                Console.WriteLine(tag.tagName);
            }
        }
        public static Tag GetTag(string nameTag)
        {
            foreach (var tag in tagsAll)
            {
                if (tag.tagName == nameTag) return tag;
            }
            return null;
        }
        public static void CreateBase()
        {
            new Sport();
            new Polityc();
            new Games();
            new Funny();
            new Science();
            new ExitApplication();
        }
        public static bool CheckTagNameInList(string checkedName)
        {
            foreach (var tag in tagsAll)
            {
                if (checkedName == tag.tagName)
                    return true;
            }
            return false;
        }
        
    }
}
