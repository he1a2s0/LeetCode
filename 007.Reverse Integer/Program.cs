using System;

namespace _007.Reverse_Integer
{
    class Program
    {
        private static readonly Solution _solution = new Solution();

        static void Main(string[] args)
        {
            Assert(23, 32);
            Assert(230, 32);
            Assert(-23,-32);

            Assert(-2147483648,0);
            Assert(1534236469, 0);
        }

        static void Assert(int original, int expected)
        {
            var result = _solution.Reverse(original);
            Console.WriteLine("{0} -> {1}\t\t{2}", original, result, result == expected ? "√" : "x");
        }
    }
}
