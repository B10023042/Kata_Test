using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KataTestCase
{
    [TestFixture]
    public class Rot13UnitTest1
    {
        [TestCase(" ", " ")]
        [TestCase("oBB", "bOO")]
        [TestCase("o", "b")]
        [TestCase("ROT13 example.", "EBG13 rknzcyr.")]
        public void TestMethod1(string input, string expectValue)
        {
            var rot13helper = new Rot13();
            var expect = expectValue;
            Assert.AreEqual(expect, rot13helper.Translate(input));
        }
    }
}
