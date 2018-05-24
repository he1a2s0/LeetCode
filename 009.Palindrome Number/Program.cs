using System;

namespace _009.Palindrome_Number
{
    class Program
    {
        private static readonly Solution _solution = new Solution();
        static void Main(string[] args)
        {
            Assert(-1,false);
            Assert(0,true);
            Assert(1,true);
            Assert(9,true);
            Assert(10,false);

            Assert(22,true);
            Assert(101,true);
            Assert(8008,true);

            Assert(50505,true);
            Assert(123454321,true);
        }

        static void Assert(int number, bool expected)
        {
            var actual = _solution.IsPalindrome(number);

            Console.WriteLine("{0}\t\t=>\t{1}\t{2}\t{3}", number, actual, expected, actual == expected ? "√" : "x");
        }
    }
}
