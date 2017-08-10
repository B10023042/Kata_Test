using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class BandNameGenerator
    {

        public static string getNewName(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return "";
            }

            var firstCharUpperString = getFirstCharUpperString(input);

            if (checkFormat(input))
            {
                return getAddTheString(firstCharUpperString);
            }
            else
            {
                return getCombinedString(input, firstCharUpperString);
            }
         
        }

        private static string getCombinedString(string input, string firstCharUpperString)
        {
            var namePart = input.Substring(1);
            return firstCharUpperString + namePart;
        }

        private static string getAddTheString(string firstCharUpperString)
        {
            var namePart = "The ";
            return namePart + firstCharUpperString;
        }

        private static bool checkFormat(string input)
        {
            return input[0] != input[input.Length - 1];
        }

        private static string getFirstCharUpperString(string input)
        {
            return input.Substring(0, 1).ToUpper()+input.Substring(1);
        }
    }
}
