using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KataTestCase
{
    [TestFixture]
    public class CellOfConwayUnitTest1
    {
        [TestCase(0, StateOfCell.Dead)]
        [TestCase(1, StateOfCell.Dead)]
        [TestCase(2, StateOfCell.Alive)]
        [TestCase(3, StateOfCell.Alive)]
        [TestCase(4, StateOfCell.Dead)]
        [TestCase(5, StateOfCell.Dead)]
        [TestCase(6, StateOfCell.Dead)]
        [TestCase(7, StateOfCell.Dead)]
        [TestCase(8, StateOfCell.Dead)]
        public void SelfIsAliveTest(int amoutOfAliveNeighbours, StateOfCell expectState)
        {
            var cellOfConway = new CellOfConway();
            var expected = expectState;
            var actual = cellOfConway.CheckCheckState(StateOfCell.Alive, amoutOfAliveNeighbours);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, StateOfCell.Dead)]
        [TestCase(1, StateOfCell.Dead)]
        [TestCase(2, StateOfCell.Dead)]
        [TestCase(3, StateOfCell.Alive)]
        [TestCase(4, StateOfCell.Dead)]
        [TestCase(5, StateOfCell.Dead)]
        [TestCase(6, StateOfCell.Dead)]
        [TestCase(7, StateOfCell.Dead)]
        [TestCase(8, StateOfCell.Dead)]
        public void SelfIsDeadTest(int amoutOfAliveNeighbours, StateOfCell expectState)
        {
            var cellOfConway = new CellOfConway();
            var expected = expectState;
            var actual = cellOfConway.CheckCheckState(StateOfCell.Dead, amoutOfAliveNeighbours);
            Assert.AreEqual(expected, actual);
        }
    }
}
