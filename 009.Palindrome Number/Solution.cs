using System;

namespace _009.Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;
            if (x < 100) return x / 10 == x % 10;

            var digits = new System.Collections.Generic.List<int>();
            var temp = x;
            while (temp > 0)
            {
                var remainder = temp % 10;
                digits.Add(remainder);
                temp = temp / 10;
            }

            for (var i = 0; i <= (digits.Count - 1) / 2; i++)
            {
                if (digits[i] != digits[digits.Count - i - 1])
                    return false;
            }

            return true;
        }
    }
}