using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class CollectionsAssertMethods
    {
        private static List<string> _names;

        public CollectionsAssertMethods()
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

        [TestMethod]
        public void AllItemsAreEqualTest()
        {   
            var employees = new List<string>()
            {
                "Иван",
                "Петр",
                "Ефим",
                "Егор",
                "Степан"
            };

            // учитывает последовательность в коллекции
            CollectionAssert.AreEqual(_names, employees, "Not equals");
        }

        [TestMethod]
        public void AllItemsAreEquivalentTest()
        {
            var employees = new List<string>()
            {
                "Петр",
                "Иван",
                "Ефим",
                "Степан",
                "Егор"
            };

            CollectionAssert.AreEquivalent(_names, employees, "Not equivalent");
        }

        [TestMethod]
        public void ItemsSubsetTest()
        {
            var employees = new List<string>()
            {
                "Петр",
                "Иван"
            };

            CollectionAssert.IsSubsetOf(employees, _names);
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            CollectionAssert.AllItemsAreUnique(_names);
        }

    }
}
