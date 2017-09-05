using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class TwoSum
    {
        public static int[] calTwoSum(int[] nums, int target)
        {
            foreach (var num in nums)
            {
                var reduceNum = target - num;
                var numIndex =  Array.IndexOf(nums, num);
                if (Array.IndexOf(nums, reduceNum, numIndex+1) >= 0)
                {
                    int[] answerList = new int[2];
                    answerList[0] = numIndex;
                    answerList[1] = Array.IndexOf(nums, reduceNum);
                    return answerList;
                }
            }
            return new int [] {0,0};
        }
    }
}
