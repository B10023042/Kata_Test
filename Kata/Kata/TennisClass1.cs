using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class TennisClass1
    {
        private static Player _playerA;
        private static Player _playerB;
        enum PointsDescribed
        {
            Love = 0, Fifteen, Thirty, Forty
        }
        public static void NewGame()
        {
            _playerA = new Player("PlayerA");
            _playerB = new Player("PlayerB");
        }

        public static void PlayerWinBall(string playerName)
        {
            if (HasAdvantage()) CancelAdvantage();
            if (IsDeuce()) GetPlayer(playerName).GetAdvantage();
            GetPlayer(playerName).WinTheBall();
        }

        private static void CancelAdvantage()
        {
            if (_playerA.IsAdvantage) _playerA.IsAdvantage = false;
            if (_playerB.IsAdvantage) _playerB.IsAdvantage = false;
        }

        private static Player GetPlayer(string playerName)
        {
            return playerName.Equals("PlayerA") ? _playerA : _playerB;
        }

        private static bool IsDeuce()
        {
            return _playerA.Score >= (int)PointsDescribed.Forty && _playerB.Score == _playerA.Score;
        }

        public static string GetResult()
        {
            if (IsDeuce()) return "Deuce";
            if (HasAdvantage()) return $"{ Winner().PlaylerName} Advantage";
            if (HasWinner()) return $"{ Winner().PlaylerName} Win";
            return $"{ (PointsDescribed)Winner().Score} {(PointsDescribed)Loser().Score}";
        }

        private static Player Loser()
        {
            return _playerA.Score < _playerB.Score ? _playerA : _playerB;
        }

        private static Player Winner()
        {
            return _playerA.Score > _playerB.Score ? _playerA : _playerB;
        }
        private static bool HasWinner()
        {
            return (Winner().Score > (int)PointsDescribed.Forty);
        }

        private static bool HasAdvantage()
        {
            return _playerA.IsAdvantage || _playerB.IsAdvantage;
        }

        private class Player
        {
            public string PlaylerName { get; set; }
            public int Score { get; private set; }
            public bool IsAdvantage { get; set; }
            public Player(string playerName)
            {
                this.PlaylerName = playerName;
                this.Score = 0;
                this.IsAdvantage = false;
            }
            internal void WinTheBall()
            {
                this.Score = this.Score + 1;
            }

            internal void GetAdvantage()
            {
                this.IsAdvantage = true;
            }
        }
    }
}
