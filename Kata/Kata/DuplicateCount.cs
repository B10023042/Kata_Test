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
            if (String.IsNullOrEmpty(str)) return 0;
            str = str.ToLower();
            var duplicateCount = 0;
            duplicateCount = str.GroupBy(g => g).Count(y => y.Count() > 1);
            return duplicateCount;
        }
    }
}
