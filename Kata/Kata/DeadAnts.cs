using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {

        public static int DeadAntCount(string input)
        {
            if (String.IsNullOrEmpty(input)) 
            { 
                return 0; 
            }
            input = input.Replace("ant", string.Empty);
            var targetString = "ant";
            var maxNum = 0;
            foreach (var subTarget in targetString.ToCharArray())
            {
                var count = input.Count(x => x == subTarget);
                if (maxNum < count)
                {
                    maxNum =count;
                }
            }
            return maxNum;
        }           

    }
}
