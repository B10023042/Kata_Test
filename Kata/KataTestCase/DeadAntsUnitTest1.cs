using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class DeadAntsUnitTest1
    {
        [TestMethod]
        public void emptyInputShouldReturnZero()
        {
            deadAntsTestCase(0, "");
        }
        [TestMethod]
        public void nullInputShouldReturnZero()
        {
            deadAntsTestCase(0, null);
        }
        [TestMethod]
        public void foutAntsInputShouldReturnZero()
        {
            deadAntsTestCase(0, "ant ant ant ant");
        }
        [TestMethod]
        public void oneDeadAntsInputShouldReturnOne()
        {
            deadAntsTestCase(1, "ant ant .... a nt");
        }
        [TestMethod]
        public void twoDeadAntsInputShouldReturnTwo()
        {
            deadAntsTestCase(2, "ant anantt aantnt");
        }

        protected void deadAntsTestCase(int expect, string input)
        {
            var actual = DeadAnts.DeadAntCount(input);
            Assert.AreEqual(expect, actual);
        }
    }
}
