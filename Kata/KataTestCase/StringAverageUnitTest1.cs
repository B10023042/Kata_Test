using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class StringAverageUnitTest1
    {
        [TestMethod]
        public void NullInputTest()
        {
            StringAverageTestCase("n/a", "");
        }
        [TestMethod]
        public void OneInputTest()
        {
            StringAverageTestCase("four", "four");
        }
        [TestMethod]
        public void InputZeroTest()
        {
            StringAverageTestCase("zero", "zero");
        }
        [TestMethod]
        public void TwoInputTest()
        {
            StringAverageTestCase("four", "five four");
        }
        [TestMethod]
        public void FourInputTest()
        {
            // StringAverageTestCase("four", "zero nine five two");
            StringAverageTestCase("n/a", "xxx six two three");
            //StringAverageTestCase("two", "one one eight one");
        }
        [TestMethod]
        public void SixInputTest()
        {
            StringAverageTestCase("three", "one two three four five");
        }
        private void StringAverageTestCase(string expect, string input)
        {
            var actual = StringAverage.AverageString(input);
            Assert.AreEqual(actual, expect);
        }
    }
}
