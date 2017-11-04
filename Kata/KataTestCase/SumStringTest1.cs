using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class SumStringTest1
    {
        [TestMethod]
        public void Given1And2Returns3()
        {
            var expect = "3";
            var actual = SumStringsClass.sumString("1","2");
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Given21And2Returns23()
        {
            var expect = "23";
            var actual = SumStringsClass.sumString("21", "2");
            Assert.AreEqual(expect, actual);
        }
       
        [TestMethod]
        public void Given21And24Returns45()
        {
            var expect = "45";
            var actual = SumStringsClass.sumString("21", "24");
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void GivenEmptyAnd5Returns5()
        {
            var expect = "5";
            var actual = SumStringsClass.sumString("", "5");
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Given00103And08567Returns5()
        {
            var expect = "8670";
            var actual = SumStringsClass.sumString("00000103", "08567");
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Given712569312664357328695151392And8100824045303269669937Returns712577413488402631964821329()
        {
            var expect = "712577413488402631964821329";
            var actual = SumStringsClass.sumString("712569312664357328695151392", "8100824045303269669937");
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Given81055900096023504197206408605And0095301248058391139327916261Returns131151201344081895336534324866()
        {
            var expect = "131151201344081895336534324866";
            var actual = SumStringsClass.sumString("81055900096023504197206408605", "50095301248058391139327916261");
            Assert.AreEqual(expect, actual);
        }
    }
}
