using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class StringAverage
    {
        static void Main(string[] args)
        {
        }
        static string[] TranslastionList = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public static string AverageString(string input)
        {
            var inputFormatError = -999;
            var result = Sum(input.Split());
            return (result != inputFormatError) ? Average(result, input) : "n/a";

        }
        private static string Average(int result, string input)
        {
            try
            {
                return TranslastionList[result / input.Split().Length];
            }
            catch
            {
                return "n/a";
            }
        }

        public static int Sum(String[] input)
        {
            var sumNum = 0;
            foreach (var i in input)
            {
                if (Array.IndexOf(TranslastionList, i) == -1) return -999;
                sumNum += Array.IndexOf(TranslastionList, i);
            }
            return sumNum;
        }
    }
}
