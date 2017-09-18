using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class NextBiggerNumberClass
    {
        public static List<long> numberList = new List<long>(); 
        public static long NextBiggerNumber(long n)
        {
            numberList = new List<long>();
            getOtherComposeNumber("",n.ToString());         
            var answer = getNextBiggerNumber(numberList, n);
            return answer == n ? -1 : answer;
        }

   

        private static long getNextBiggerNumber(List<long> numberList,long n)
        {
            long min = numberList.Max() ;
            long answer = n;
            for (var i = 0; i < numberList.Count; i++)
            {

                var distance = numberList[i]-n;
                if (min > distance && distance > 0 && n != numberList[i])
                {
                    min = distance;
                    answer = numberList[i];
                }

            }
            return answer;
        }


        static void getOtherComposeNumber(string result, string now)
        {
            if (now == "")
            {             
                numberList.Add(Convert.ToInt64(result));              
            }
            else
            {
                for (int i = 0; i < now.Length; i++)
                {
                    getOtherComposeNumber(result + now[i], now.Substring(0, i) + now.Substring(i + 1));
                }
            }
        }
    }
}
