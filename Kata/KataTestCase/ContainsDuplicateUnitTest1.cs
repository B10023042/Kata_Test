using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class ContainsDuplicateUnitTest1
    {
        [TestMethod]
        public void inputEmpty_and0_should_return_false()
        {
            ContainsDuplicateUnitTestClass(
                new int[] {},
                0,
                false);
        }

        [TestMethod]
        public void input1_and0_should_return_false()
        {
            ContainsDuplicateUnitTestClass(
                new int[] {1},
                0,
                false);
        }

        [TestMethod]
        public void input2_2_and3_should_return_true()
        {
            ContainsDuplicateUnitTestClass(
                new int[] { 2,2 },
                3,
                true);
        }

        [TestMethod]
        public void input1_2_1_and0_should_return_false()
        {
            ContainsDuplicateUnitTestClass(
                new int[] { 1,2,1 },
                0,
                false);
        }


        [TestMethod]
        public void input2_3_4_5_3_1_and3_should_return_true()
        {
            ContainsDuplicateUnitTestClass(
                new int[] { 2, 3, 4, 5, 3, 1 },
                3,
                true);
        }


        [TestMethod]
        public void input2_3_4_5_3_1_and2_should_return_false()
        {
            ContainsDuplicateUnitTestClass(
                new int[] { 2, 3, 4, 5, 3, 1 },
                2,
                false);
        }


        [TestMethod]
        public void input99_99_and2_should_return_true()
        {
            ContainsDuplicateUnitTestClass(
                new int[] {99,99},
                2,
                true);
        }


        private static void ContainsDuplicateUnitTestClass(int[] inputNums,int k, bool expect)
        {            
            var actual = ContainsDuplicateClass.containsDuplicate(inputNums, k);
            Assert.AreEqual(expect, actual);
        }
    }
}
