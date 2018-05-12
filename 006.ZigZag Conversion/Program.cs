using System;

namespace _006.ZigZag_Conversion
{
    class Program
    {
        private static  readonly Solution _solution = new Solution();

        static void Main(string[] args)
        {
            var s = "PAYPALISHIRING";
            Assert(s, 3, "PAHNAPLSIIGYIR");

            Assert(s, 4, "PINALSIGYAHRPI");
        }

        static void Assert(string s, int numRows, string expected)
        {
            var actual = _solution.Convert(s, numRows);

            Console.WriteLine("s={0}, numRows={1}, output={2}, expected={3}\t{4}", s, numRows, actual, expected, string.CompareOrdinal(actual,expected)==0? "√" : "x");
        }
    }
}
