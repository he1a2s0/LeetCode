using System;

namespace _010.Regular_Expression_Matching
{
    class Program
    {
        private static readonly Solution _solution = new Solution();
        static void Main(string[] args)
        {
            Assert(null, null, false);
            Assert(string.Empty, string.Empty, false);
            Assert("str",null, false);

            Assert("str","str", true);

            Assert("aa","a",false);
            Assert("aa","a*",true);
            Assert("ab",".*",true);
            Assert("aab","c*a*b",true);
            Assert("mississippi", "mis*is*p*.",false);
            Assert("mississippi", "mis*is*ip*.",true);

            Assert("ab","*.c", false); //不允许以*开头，这里返回false
            Assert("ab",".*c", false);

            Assert("aaa","ab*ac*a", true);

            Assert("aaa","a*a", true);
        }

        static void Assert(string str, string pattern, bool expected)
        {
            var actual = _solution.IsMatch(str, pattern);

            Console.WriteLine("string: {0}, pattern: {1}\t\t=>\t{2}\t{3}\t{4}", str, pattern, actual, expected, actual == expected ? "√" : "x");
        }
    }
}
