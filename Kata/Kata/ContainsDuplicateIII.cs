using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kata
{
    public class ContainsDuplicateIII
    {
        public static bool ContainsDuplicate(int[] nums, int k, int t)
        {
            if (IsInputWorngFormat(nums, k, t)) return false;

            for (var i = 0; i < nums.Length-1; i++)
            {
                var firstValue = nums[i];

                if (t == 0)
                {
                    return IsHasDuplicate(nums);
                }
                var searchRange = nums.Skip(i + 1).Take(k);
               
                if  (searchRange.
                    Any(x => DifferenceValue(firstValue, x) <= t))
                    {
                        return true;
                    }
               }
            return false;
        }

        private static long DifferenceValue(int firstValue, int x)
        {
            return Math.Abs(((long)firstValue - (long)x));
        }

        private static bool IsHasDuplicate(int[] nums)
        {
            return nums
                .GroupBy(item => item)
                .Select(item => item.Count())
                .Any(item => item > 1);
        }

        private static bool IsInputWorngFormat(int[] nums, int k, int t)
        {
            return nums.Length <= 1;
        }

    }
}
