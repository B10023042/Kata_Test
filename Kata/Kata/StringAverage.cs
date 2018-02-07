using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class StringAverage
    {
        static void Main(string[] args)
        {

        }

        public enum Numbers
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine
        };
        public static int inputFormatError = -999;
        public static string AverageString(string input)
        {
            var numberList = getNumberList(input);
            if (numberList.Contains(inputFormatError))
            {
                return "n/a";
            }
            else
            {
                var average = (Numbers)numberList.Average();
                return average.ToString();
            }

        }

        private static List<int> getNumberList(string input)
        {

            var stringList = input.Split();
            List<int> numberList = new List<int>();
            foreach (var i in stringList)
            {
                Numbers num;
                if (Numbers.TryParse(i, out num))
                {
                    numberList.Add((int)num);
                }
                else
                {
                    numberList.Add(inputFormatError);
                }
            }
            return numberList;
        }
    }
}
