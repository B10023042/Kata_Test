using Kata;
using NUnit.Framework;

namespace KataTestCase
{
    [TestFixture]
    public class ContainsDuplicateIIIUnitTest1
    {

        [TestCase(new int[0], 0, 0, false)]
        public void TestEmptyArray(int[] nums, int k, int t, bool expected)
        {
            ContainsDuplicateIIIUnitTestCase(nums, k, t, expected);
        }
        [TestCase(new[] { -1, -1 }, 1, 0, true)]
        [TestCase(new[] { 1, 3, 1 }, 2, 1, true)]
        [TestCase(new[] { 1, 3, 1 }, 1, 1, false)]
        [TestCase(new[] { 1, 2 }, 0, 1, false)]
        [TestCase(new[] { 7, 1, 3 }, 2, 3, true)]
        [TestCase(new[] { 4,2}, 2, 1, false)]
        [TestCase(new[] { -3,3}, 2, 4, false)]
        [TestCase(new[] { 4, 1, -1, 6, 5 }, 3, 1, true)]
        [TestCase(new[] { -1,-1 }, 1, -1, false)]
        public void Input2NumArray(int[] nums, int k, int t, bool expected)
        {
            ContainsDuplicateIIIUnitTestCase(nums, k, t, expected);
        }


        [TestCase(new[] { -1, 2147483647 }, 1, 2147483647, false)]
        public void specialCase(int[] nums, int k, int t, bool expected)
        {
            ContainsDuplicateIIIUnitTestCase(nums, k, t, expected);
        }
        private void ContainsDuplicateIIIUnitTestCase(int[] nums, int k,int t, bool expect)
        {
            var actual = ContainsDuplicateIII.ContainsDuplicate(nums,k,t);
            Assert.AreEqual(expect, actual);
        }
    }
}
