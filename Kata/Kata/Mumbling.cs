using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Mumbling
    {
        public static string Accum(string input)
        {
            if(string.IsNullOrEmpty(input)) return String.Empty;

            if (input.Length == 1)
            {
                return input.ToUpper();
            }
            else
            {
                input = input.ToLower();
                var firstChar = char.ToUpper(input[0]).ToString();
                for (var i =1; i < input.Length; i++)
                {
                    var upperString = char.ToUpper(input[i]);
                    var lowerString = new string( input[i],i );
                    var partString = upperString + lowerString;
                    firstChar = firstChar + "-" + partString;
                }

                return firstChar;
            }
            
         
        }
    }
}
