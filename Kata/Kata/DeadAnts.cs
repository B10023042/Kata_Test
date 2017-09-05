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
            if (String.IsNullOrEmpty(input)) return 0;
            input = input.Replace("ant", string.Empty);
            var head = input.Count(x => x == 'a');
            var body = input.Count(x => x == 'n');
            var end = input.Count(x => x == 't');
            return getMaxDeadAnt(head, body, end);
        }
           

        private static int getMaxDeadAnt(int head, int body, int end)
        {
            if (head==0 && body ==0 && end==0) return 0;
            var maxDeadAnt = Math.Max(head, body);
            maxDeadAnt = Math.Max(maxDeadAnt, end);
            return maxDeadAnt;
        }
    }
}
