using LearnSharp4.TestableLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnSharp4.UnitTests.Tests
{
    [TestClass]
    public class CalcTests
    {
        // name convension - [CurrentMethod _ act _ returned]
        [TestMethod]
        public void Sum_5plus6_11returned()
        {
            // arrange
            var values = new int[] { 5, 6 };
            int excepted = 11;

            // act
            var calc = new Calc();
            var sum = calc.Sum(values);

            // assert
            Assert.AreEqual(excepted, sum);
        }

        [TestMethod]
        public void Sum_null_exceptionReturned()
        {
            int[] values = null;

            var calc = new Calc();

            Assert.ThrowsException<NullReferenceException>(() => calc.Sum(values));
        }
    }
}
