using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Rot13
    {
        public string Translate(string input)
        {
            var ans = "";
            foreach (var s in input)
            {
                var asciiNum = Convert.ToInt32(s);
                const int rotNum = 13;
                if (IsFirstSectionAlphabet(asciiNum))
                {
                    asciiNum += rotNum;
                }
                else if (IsSecondSectionAlphabet(asciiNum))
                {
                    asciiNum -= rotNum;
                }

                var x = Convert.ToChar(asciiNum);
                ans += x.ToString();
            }
            return ans;

        }

        private static bool IsSecondSectionAlphabet(int asciiNum)
        {
            return (asciiNum >= Convert.ToInt32('N') && asciiNum <= Convert.ToInt32('Z') || (asciiNum >= Convert.ToInt32('n') && asciiNum <= Convert.ToInt32('z')));
        }

        private static bool IsFirstSectionAlphabet(int asciiNum)
        {
            return (asciiNum >= Convert.ToInt32('A') && asciiNum <= Convert.ToInt32('M') || (asciiNum >= Convert.ToInt32('a') && asciiNum <= Convert.ToInt32('m')));

        }
    }
}
