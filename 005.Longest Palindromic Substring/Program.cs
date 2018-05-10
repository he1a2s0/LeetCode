using System;

namespace _005.Longest_Palindromic_Substring
{
    class Program
    {
        private static readonly Solution solution = new Solution();

        static void Main(string[] args)
        {
            Assert(null, null);
            Assert(string.Empty, string.Empty);
            Assert("", string.Empty);
            Assert(" ", string.Empty);

            Assert("a", "a");

            Assert("ab", "a");
            Assert("bb", "bb");

            Assert("bba", "bb");
            Assert("bab", "bab");
            Assert("aaa", "aaa");

            Assert("baba", "bab");
            Assert("baab", "baab");

            Assert("babad", "bab");

            Assert("1baabcddcbaab2", "baabcddcbaab");

            Assert("aaabaaaa","aaabaaa");
        }

        static void Assert(string str, string expected)
        {
            var actual = solution.LongestPalindrome(str);

            Console.WriteLine("string: {0}, expected: {1}, actual: {2}, {3}", str, expected, actual, string.CompareOrdinal(expected, actual) == 0 ? "√" : "x");
        }
    }
}
