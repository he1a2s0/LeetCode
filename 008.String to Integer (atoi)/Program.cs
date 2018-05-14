using System;

namespace _008.String_to_Integer__atoi_
{
    class Program
    {
        private static readonly Solution _solution = new Solution();
        static void Main(string[] args)
        {
            Assert(null, 0);
            Assert(string.Empty,0);
            Assert(" ",0);
            Assert("1",1);
            Assert(" 1",1);
            Assert("001",1);

            Assert("-123",-123);
            Assert(" -123", -123);

            Assert(" 12232werewg234", 12232);
            Assert("_1",0);

            Assert("-91283472332", int.MinValue);
            Assert("8463847412", int.MaxValue);
            Assert("-2147483648", int.MinValue);
        }

        static void Assert(string str, int expected)
        {
            var actual = _solution.MyAtoi(str);

            Console.WriteLine("string: {0}, expected: {1}, actual: {2}\t{3}", str, expected, actual, actual == expected ? "√" : "x");
        }
    }
}
