using System;

namespace _003.Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var s = "abcabc";
            Console.WriteLine(s);
            Console.WriteLine(solution.LengthOfLongestSubstring(s));

            s = "bbbb";
            Console.WriteLine(s);
            Console.WriteLine(solution.LengthOfLongestSubstring(s));

            s = "aab";
            Console.WriteLine(s);
            Console.WriteLine(solution.LengthOfLongestSubstring(s));

            s = "dvdf";
            Console.WriteLine(s);
            Console.WriteLine(solution.LengthOfLongestSubstring(s));

            s = "pwwkew";
            Console.WriteLine(s);
            Console.WriteLine(solution.LengthOfLongestSubstring(s));
        }
    }
}
