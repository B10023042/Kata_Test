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
            try
            {
                input = input.Replace("ant", "");
                var head = input.Count(x => x == 'a');
                var body = input.Count(x => x == 'n');
                var end = input.Count(x => x == 't');
                return getMaxDeadAnt(head, body, end);
            }
            catch
            {
                return 0;
            }
        }

        private static int getMaxDeadAnt(int head, int body, int end)
        {
            var maxDeadAnt = Math.Max(head, body);
            maxDeadAnt = Math.Max(maxDeadAnt, end);
            return maxDeadAnt;
        }
    }
}
