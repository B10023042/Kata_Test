using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class MumblingUnitTest1
    {
        [TestMethod]
        public void inputEmptyShouldReturnEmpty()
        {
            string input=string.Empty;
            string expect = string.Empty;
            MumblingTestCase(input,expect);
        }

        [TestMethod]
        public void inputOneLowerCharShouldReturnUpperChar()
        {
            string input = "a";
            string expect = "A";
            MumblingTestCase(input, expect);
        }

        [TestMethod]
        public void inputOneUpperCharShouldReturnUpperChar()
        {
            string input = "B";
            string expect = "B";
            MumblingTestCase(input, expect);
        }

        [TestMethod]
        public void inputTwoCharShouldReturnRightFormat()
        {
            string input = "Cd";
            string expect = "C-Dd";
            MumblingTestCase(input, expect);
        }

        [TestMethod]
        public void inputThreeCharShouldReturnRightFormat()
        {
            string input = "aCd";
            string expect = "A-Cc-Ddd";
            MumblingTestCase(input, expect);
        }

        private static void MumblingTestCase(string input, string expect)
        {
            var actual = Mumbling.Accum(input);
            Assert.AreEqual( expect,actual);
        }
    }
}
