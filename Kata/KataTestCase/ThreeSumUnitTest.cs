using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace KataTestCase
{
    [TestClass]
    public class ThreeSumUnitTest
    {
        [TestMethod]
        public void intput__1_0_1_2__1__4_shouldReturn_2set()
        {
            var inputNum = new int[] { -1, 0, 1, 2, -1, -4 };
            ArrayList targetList = new ArrayList();
            targetList.Add(new int[] { -1, 0, 1 });
            targetList.Add(new int[] { -1, -1, 2 });
            var actual = ThreeSum.calThreeSum(inputNum);
            var comparer = Comparer<object>.Create((a, b) => ((int[])a).SequenceEqual((int[])b) ? 0 : 1);

            CollectionAssert.AreEqual(targetList, actual, comparer);
                     
        }

        [TestMethod]
        public void intput__2_0_0_2_2_shouldReturn_1set()
        {
            var inputNum = new int[] { -2, 0, 0, 2, 2 };
            ArrayList targetList = new ArrayList();
            targetList.Add(new int[] { -2,0,2});
            var actual = ThreeSum.calThreeSum(inputNum);
            var comparer = Comparer<object>.Create((a, b) => ((int[])a).SequenceEqual((int[])b) ? 0 : 1);

            CollectionAssert.AreEqual(targetList, actual, comparer);

        }
    }
}
