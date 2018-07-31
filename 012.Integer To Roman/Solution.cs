using System.Text;
using System;

namespace _012.Integer_To_Roman
{
    public class Solution{

        private static readonly string[][] _romanChars = new string[4][]{
            new []{string.Empty, "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
            new []{string.Empty, "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
            new []{string.Empty, "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
            new []{string.Empty, "M", "MM", "MMM" },
        };

        public string IntToRoman(int num) {
            var sb = new StringBuilder();

            var count = num.ToString().Length;
            while(count-- > 0){
                var divisor = (int)Math.Pow(10, count);
                var quotient = num / divisor;
                Console.WriteLine("count={0}, divisor={1}, quotient={2}", count, divisor, quotient);
                if(quotient >0){
                    num = num % divisor;
                }
                sb.Append(_romanChars[count][quotient]);
            }

            return sb.ToString();
        }
    }
}