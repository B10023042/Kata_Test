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

            permute("", "123");
            ////List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////foreach (var item in numList)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.ReadLine();


            //Stack<double> DoubleNumbers = new Stack<double>();
            //DoubleNumbers.Push(3.14);
            //DoubleNumbers.Push(3.1415);
            //DoubleNumbers.Push(3.141592);
            //DoubleNumbers.Push(3.14159261);


            //foreach (var item in DoubleNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            ////string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            ////foreach (var item in weekDays)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.ReadLine();
            Console.ReadLine();

            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic.Add("Unknown", 0);
            dic.Add("Baccarat", 1);
            dic.Add("Roulette", 3);
            dic.Add("SicBo", 5);


            foreach (KeyValuePair<string, int> item in dic)
            {
                Console.WriteLine(string.Format("{0} : {1}", item.Key, item.Value));
            }

            Console.ReadLine();
        }

        static void permute(string result, string now)
        {
            if (now == "")
            {
                Console.WriteLine(result);
            }
            else
            {
                for (int i = 0; i < now.Length; i++)
                {
                    permute(result + now[i], now.Substring(0, i) + now.Substring(i + 1));
                    Console.WriteLine();
                }
            }
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
