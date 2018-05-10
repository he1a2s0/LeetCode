using System;

namespace _005.Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (s == null) return null;
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            var len = s.Length;

            if (len == 1) return s;
            if (len == 2) return s[0] == s[1] ? s : s[0].ToString();

            int start, end;
            string result = string.Empty;

            //长度为奇数的回文（以i为中心向两侧扩展）
            for (var i = 1; i < len - 1; i++)
            {
                start = end = i;
                result = FindLongestPalindromeInternal(s, start, end, result);
            }

            //长度为偶数的回文（以i,i+1为中心向两侧扩展
            for (var i = 0; i < len - 1; i++)
            {
                start = i;
                if (s[start] != s[start + 1])
                    continue;

                end = start + 1;

                result = FindLongestPalindromeInternal(s, start, end, result);
            }

            return result;
        }

        private string FindLongestPalindromeInternal(string s, int start, int end, string lastResult)
        {
            while (start > 0 && end < s.Length - 1)
            {
                if (s[start - 1] == s[end + 1])
                {
                    start--;
                    end++;
                }
                else
                    break;
            }
            var len = end - start + 1;
            if (len > lastResult.Length)
                return s.Substring(start, end - start + 1);

            return lastResult;
        }
    }
}
