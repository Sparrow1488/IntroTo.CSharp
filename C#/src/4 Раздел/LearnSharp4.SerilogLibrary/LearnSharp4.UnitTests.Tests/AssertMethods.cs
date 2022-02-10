using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class AssertMethods
    {
        [TestMethod]
        public void IsPasswordEqualsTest()
        {
            const string a = "1234";
            const string b = "1234";

            Assert.AreEqual(a, b, $"Password '{a}' should be equals '{b}'!"); // смотрим в логах теста
        }

        [TestMethod]
        public void StringAreEqualsTest()
        {
            const string a = "Hello";
            const string b = "HELLO";

            Assert.AreEqual(a, b, true); // true - Игнорируем регистр
        }

        [TestMethod]
        public void NumbersAreEqualsTest()
        {
            const int a = 1;
            const int b = 1;

            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void ReferencesAreSameTest()
        {
            const string a = "Value";
            const string b = "Value";

            Assert.AreSame(a, b); // сравнивает ссылки
        }

        
    }
}
