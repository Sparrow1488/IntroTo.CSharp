using LearnSharp4.TestableLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class HtmlBuilderTest
    {
        [DeploymentItem("Files\\template.txt")]
        [DeploymentItem("Files\\result.txt")]
        [TestMethod]
        public void CreateTextBlockTest()
        {
            var builder = new HtmlBuilder();
            string text = "Крутой текст";
            var date = new DateTime(2022, 2, 12);
            var expected = File.ReadAllText("./result.txt");

            builder.CreateBlockWithText(text, date);
            var result = builder.Build();

            Assert.AreEqual(result, expected);

        }
    }
}
