using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class ContainsDuplicateClass
    {
        public static bool containsDuplicate(int[] nums, int k)
        {
            if (isInputWorngFormat(nums, k)) return false;   
        
            var maxValue = nums.Length/k;
            for (var i = 0; i <= maxValue; i++)
            {
                var firstValue = nums[i];
                for (var j = 1; j <= k; j++)
                {
                    var secondValueIndex = i + j;
                    if (secondValueIndex < nums.Length)
                    {
                        var secondValue = nums[secondValueIndex];
                        if (firstValue == secondValue) return true;
                    }                    
                }        
            }
                return false;
        }
        private static bool isInputWorngFormat(int[] nums, int k)
        {
            if (nums.Length <= 1) return true;
            if (k == 0) return true;
            return false;
        }
    }
}
