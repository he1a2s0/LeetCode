using System;

namespace _014.Longest_Common_Prefix
{
    class Program
    {
        private readonly static Solution _solution = new Solution();

        static void Main(string[] args)
        {
            Assert(new string[] { "flower", "flow", "flight" }, "fl");
            Assert(new string[] { "dog", "rececar", "car" }, "");
            Assert(new string[0], "");
        }

        static void Assert(string[] strs, string expected)
        {
            var actual = _solution.LongestCommonPrefix(strs);

            Console.WriteLine("[{0}]\t\t=>\t{1}\t{2}\t{3}", string.Join(",", strs), actual, expected, actual == expected ? "√" : "x");
        }
    }
}
