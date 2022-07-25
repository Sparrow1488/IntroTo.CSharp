using LearnSharp4.TestableLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class ContextTests
    {
        public TestContext TestContext { get; set; }

        public ContextTests()
        {
            Debug.WriteLine(Directory.GetCurrentDirectory());
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine($"{TestContext.CurrentTestOutcome}");
            TestContext.WriteLine($"{TestContext.DeploymentDirectory}");
            TestContext.WriteLine($"{TestContext.TestName}");
        }

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        //            "test-data.xml",
        //            "User",
        //            DataAccessMethod.Sequential)]
        //[TestMethod]
        //public void AddUserTests()
        //{
        //    string name = TestContext.DataRow["Name"].ToString();
        //    string mail = TestContext.DataRow["Mail"].ToString();

        //    new UserManager().AddUser(name, mail);

        //    Assert.IsTrue(true);
        //}

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        //            "test-data.xml",
        //            "User",
        //            DataAccessMethod.Sequential)]
        //[TestMethod]
        //public void TryAddUserTests()
        //{
        //    string name = TestContext.DataRow["Name"].ToString();
        //    string mail = TestContext.DataRow["Mail"].ToString();

        //    var result = new UserManager().TryAddUser(name, mail);

        //    Assert.IsTrue(result);
        //}
    }
}
