using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class DuplicateCount
    {
        public static int countDuplicate(string str)
        {
            str = str.ToLower();
            var duplicateCount = 0;
            foreach (var t in str)
            {
                var duplicateTimes = str.Count(x => x == t);
                str = str.Replace(t.ToString(), "");
                if (duplicateTimes > 1) duplicateCount++;
            }

            return duplicateCount;
        }
    }
}
