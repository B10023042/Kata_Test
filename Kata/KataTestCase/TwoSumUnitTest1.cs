using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class TwoSumUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var targetNum = 9;
            var target = new int[] { 0, 1 };
            var actual = TwoSum.calTwoSum(nums,targetNum);
            CollectionAssert.AreEqual(target, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var targetNum = 18;
            var target = new int[] { 1, 2 };
            var actual = TwoSum.calTwoSum(nums, targetNum);
            CollectionAssert.AreEqual(target, actual);
        }


        [TestMethod]
        public void TestMethod3()
        {
            var nums = new int[] {3,2,4};
            var targetNum = 6;
            var target = new int[] { 1, 2 };
            var actual = TwoSum.calTwoSum(nums, targetNum);
            CollectionAssert.AreEqual(target, actual);
        }
    }
}
