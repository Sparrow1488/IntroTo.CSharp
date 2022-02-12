using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class ContextTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine($"{TestContext.CurrentTestOutcome}");
            TestContext.WriteLine($"{TestContext.DeploymentDirectory}");
            TestContext.WriteLine($"{TestContext.TestName}");
        }
    }
}
