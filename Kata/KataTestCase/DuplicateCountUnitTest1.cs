using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class DuplicateCountUnitTest1
    {
        [TestMethod]
        public void inputEmptyShouldReturn0()
        {
            DuplicataCount("",  0);
        }

        [TestMethod]
        public void inputNullShouldReturn0()
        {
            DuplicataCount(null, 0);
        }

        [TestMethod]
        public void inputNoDuplicataShouldReturn0()
        {
            DuplicataCount("abcde", 0);
        }

        [TestMethod]
        public void input_aabbcde_ShouldReturn2()
        {
            DuplicataCount("aabbcde", 2);
        }

        [TestMethod]
        public void inputOneDuplicataShouldReturn()
        {
            DuplicataCount("aacde", 1);
        }
        private static void DuplicataCount(string input, int expect)
        {
            var actual = DuplicateCount.countDuplicate(input);
            Assert.AreEqual(expect, actual);
        }
    }
}
