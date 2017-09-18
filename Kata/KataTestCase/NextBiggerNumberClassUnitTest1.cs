using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class NextBiggerNumberClassUnitTest1
    {
        [TestMethod]
        public void input12_ShouleReturn_21()
        {
            NextBiggerNumberTestCase(12,21);
        }

        [TestMethod]
        public void input513_ShouleReturn_531()
        {
            NextBiggerNumberTestCase(513, 531);
        }


        [TestMethod]
        public void input2017_ShouleReturn_2071()
        {
            NextBiggerNumberTestCase(2017, 2071);
        }

        [TestMethod]
        public void input9_ShouleReturn__1()
        {
            NextBiggerNumberTestCase(9, -1);
        }

        [TestMethod]
        public void input111_ShouleReturn__1()
        {
            NextBiggerNumberTestCase(111, -1);
        }

        [TestMethod]
        public void input531_ShouleReturn__1()
        {
            NextBiggerNumberTestCase(531, -1);
        }
        private static void NextBiggerNumberTestCase(long input, long target)
        {          
            var actual = NextBiggerNumberClass.NextBiggerNumber(input);
            Assert.AreEqual(target, actual);
        }
    }
}
