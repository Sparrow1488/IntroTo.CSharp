using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class CollectionsAssertMethods
    {
        private static List<string> _names;

        [ClassInitialize]
        public static void NamesInitialize()
        {
            _names = new List<string>()
            {
                "Иван",
                "Петр",
                "Ефим",
                "Егор",
                "Степан"
            };
        }

        [TestMethod]
        public void AllItemsAreNotNullTest()
        {
            CollectionAssert.AllItemsAreNotNull(_names);
        }
    }
}
