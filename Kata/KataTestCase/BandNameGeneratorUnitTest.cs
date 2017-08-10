using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class BandNameGeneratorUnitTest
    {
        [TestMethod]
        public void inputEmptyShouldBeEmpty()
        {
            var input = "";
            var expect = "";
            BandNameGeneratorTestCase(input,expect);
        }
        [TestMethod]
        public void input_knife_ShouldBeThe_Knife()
        {
            var input = "knife";
            var expect = "The Knife";
            BandNameGeneratorTestCase(input, expect);
        }
        [TestMethod]
        public void input_tart_ShouldBeTartart()
        {
            var input = "tart";
            var expect = "Tartart";
            BandNameGeneratorTestCase(input, expect);
        }

        private static void BandNameGeneratorTestCase(string input,string expect)
        {
            var actual = BandNameGenerator.getNewName(input);
            Assert.AreEqual(actual, expect);
        }
    }
}
