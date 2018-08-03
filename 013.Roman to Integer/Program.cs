using System;

namespace _013.Roman_to_Integer
{
    class Program
    {
        private readonly static Solution _solution = new Solution();

        static void Main(string[] args)
        {
             Assert("I",1);
             Assert("III",3);
             Assert("IV",4);
             Assert("IX",9);
             Assert("LVIII",58);
             Assert("MCMXCIV",1994);
        }

        static void Assert(string str, int expected)
        {
            var actual = _solution.RomanToInt(str);

            Console.WriteLine("{0}\t\t=>\t{1}\t{2}\t{3}", str, actual, expected, actual == expected ? "√" : "x");
        }
    }
}
