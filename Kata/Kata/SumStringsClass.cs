using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class SumStringsClass
    {
        public static string sumString(string inputA, string inputB)
        {
          
            var numAarray = transformInputToIntArray(inputA);
            var numBarray = transformInputToIntArray(inputB);
          
            var longArray = (numAarray.Length < numBarray.Length)? numBarray : numAarray;
            var shortArray = (numAarray.Length < numBarray.Length) ? numAarray : numBarray;

            var answer = "";
            var carryNum = 0;
            for (var i = 0; i < longArray.Length; i++)
            {
                if (i < shortArray.Length)
                {
                    var num = longArray[i] + shortArray[i] + carryNum;
                    carryNum = 0;
                    if (num > 9)
                    {
                        carryNum = 1;
                        num = num - 10;
                    }
                    answer = string.Format("{0}{1}", num.ToString(), answer);
                }
                else if(longArray[i]!=0)
                {
                    answer = string.Format("{0}{1}", (longArray[i] + carryNum).ToString(), answer);
                    carryNum = 0;
                }
            }
            if(carryNum!=0)
                answer = string.Format("{0}{1}", 1.ToString(), answer);
            if (answer.Substring(0, 1) == "0") answer = answer.Substring(1, answer.Length - 1);
            return answer;
        }

        private static int[] transformInputToIntArray(string input)
        {
            var intArray = input.ToCharArray().Select(c => Convert.ToInt32(c.ToString())).ToArray();
            Array.Reverse(intArray);
            return intArray;
        }
    }
}
