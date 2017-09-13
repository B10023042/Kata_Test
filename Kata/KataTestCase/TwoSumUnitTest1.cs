using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class TwoSumUnitTest1
    {
        [TestMethod]
        public void input_2_7_11_15_target_is_9_shouldReturn_0_1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var targetNum = 9;
            var target = new int[] { 0, 1 };
            var actual = TwoSum.calTwoSum(nums,targetNum);
            CollectionAssert.AreEqual(target, actual);
        }

        [TestMethod]
        public void inpur_2_7_11_15_target_is_18_shouldReturn_1_2()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var targetNum = 18;
            var target = new int[] { 1, 2 };
            var actual = TwoSum.calTwoSum(nums, targetNum);
            CollectionAssert.AreEqual(target, actual);
        }


        [TestMethod]
        public void input_3_2_4_target_is_6_shouldReturn_1_2()
        {
            var nums = new int[] {3,2,4};
            var targetNum = 6;
            var target = new int[] { 1, 2 };
            var actual = TwoSum.calTwoSum(nums, targetNum);
            CollectionAssert.AreEqual(target, actual);
        }
    }
}
