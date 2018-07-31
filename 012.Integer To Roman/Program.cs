using System;

namespace _012.Integer_To_Roman
{
    class Program
    {
        private static readonly Solution _solution = new Solution();

        static void Main(string[] args)
        {
             Assert(1, "I");
             Assert(3, "III");
             Assert(4, "IV");
             Assert(9, "IX");
             Assert(58, "LVIII");
             Assert(1994, "MCMXCIV");
        }

        static void Assert(int number, string expected)
        {
            var actual = _solution.IntToRoman(number);

            Console.WriteLine("{0}\t\t=>\t{1}\t{2}\t{3}", number, actual, expected, actual == expected ? "√" : "x");
        }
    }
}
