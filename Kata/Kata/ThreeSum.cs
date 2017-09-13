using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class ThreeSum
    {
        public static ArrayList calThreeSum(int[] inputNum)
        {
            ArrayList answerList = new ArrayList();
          
            foreach (var num in inputNum)
            {
                int[] answerArray = new int[3];
                var shouldBeReduceNum = num;
                var numbersNoContainShouldReduceNum = inputNum.Where(val => val != num).ToArray();
                var negativeNumberOfShouldReduceNumArray = calTwoSum(numbersNoContainShouldReduceNum, num * -1);
                if (negativeNumberOfShouldReduceNumArray.Sum() + shouldBeReduceNum == 0)
                {
                    answerArray[0] = shouldBeReduceNum;
                    answerArray[1] = negativeNumberOfShouldReduceNumArray[0];
                    answerArray[2] = negativeNumberOfShouldReduceNumArray[1];
                    Array.Sort(answerArray);

                    if (checkNotDuplicate(answerList, answerArray))
                    {
                         answerList.Add(answerArray);       
                    }                            
                }
            }
            return answerList;
        }
        public static bool checkNotDuplicate(ArrayList answerList, int[] answerArray)
        {
            foreach (int[] subAnwser in answerList)
            {
                if (answerArray.SequenceEqual(subAnwser))
                    return false;
            }
            return true;
        }
        public static int[] calTwoSum(int[] nums, int target)
        {
            foreach (var num in nums)
            {
                var reduceNum = target - num;
                var numIndex = Array.IndexOf(nums, num);
                if (Array.IndexOf(nums, reduceNum, numIndex + 1) >= 0)
                {
                    int[] answerList = new int[2];
                    answerList[0] = num;
                    answerList[1] = reduceNum;
                    return answerList;
                }
            }
            return new int[] { 0, 0 };
        }
    }
  }
