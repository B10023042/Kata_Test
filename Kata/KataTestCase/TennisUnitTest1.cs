using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
namespace KataTestCase
{
    [TestClass]
    public class TennisUnitTest1
    {
        [TestMethod]
        public void newGame_Return_Love_And_Love()
        {
            TennisClass1.NewGame();

            var expect = "Love Love";
            var actual = TennisClass1.GetResult();
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void PlayerA_WinBall_Return_Fifteen_And_Love()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "Fifteen Love";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PlayerB_WinBall_Return_Fifteen_And_Love()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "Fifteen Love";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Both_WinBall_Return_Fifteen_And_Fifteen()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "Fifteen Fifteen";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PlayerA_WinBall_Twice_And_PlayerB_WinBall_Once_Return_Thirty_And_Fifteen()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "Thirty Fifteen";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PlayerA_WinBall_3times_And_PlayerB_WinBall_Once_Return_Forty_And_Fifteen()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "Forty Fifteen";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PlayerA_WinBall_4times_And_PlayerB_WinBall_Once_Return_PlayerAWin()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerA Win";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PlayerB_WinBall_4times_And_PlayerA_WinBall_Once_Return_PlayerBWin()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerB Win";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void Both_WinBall_3times_Return_Deuce()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "Deuce";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AfterDeuce_PlayerAWinBall_Return_PlayerA_Advantage()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            var actual = TennisClass1.GetResult();
            var expect = "PlayerA Advantage";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void AfterDeuce_PlayerBWinBall_Return_PlayerB_Advantage()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            var actual = TennisClass1.GetResult();
            var expect = "PlayerB Advantage";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AfterDeuce_BothWinBall_Return_Deuce()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "Deuce";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void AfterDeuce_BothWinBall_Return_Deuce_2()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "Deuce";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void AfterTwiceDeuce_PlayerA_WinBalll_Return_PlayerA_Advantage()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerA Advantage";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void AfterTwiceDeuce_PlayerA_WinBalll_Return_PlayerB_Advantage()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerB Advantage";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AfterTwiceDeuce_Both_WinBalll_Return_Deuce()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "Deuce";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void AfterDeuce_PlayerA_WinBall_Twice_Return_PlayerAWin()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerA Win";
            Assert.AreEqual(expect, actual);
        }



        [TestMethod]
        public void AfterDeuce_PlayerB_WinBall_Twice_Return_PlayerBWin()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerB Win";
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void AfterTwiceDeuce_PlayerB_WinBall_Twice_Return_PlayerBWin()
        {
            TennisClass1.NewGame();
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerA");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");
            TennisClass1.PlayerWinBall("PlayerB");

            var actual = TennisClass1.GetResult();
            var expect = "PlayerB Win";
            Assert.AreEqual(expect, actual);
        }
    }
}
