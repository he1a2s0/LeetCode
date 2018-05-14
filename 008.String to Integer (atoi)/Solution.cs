using System;

namespace _008.String_to_Integer__atoi_
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;

            var digitChars = new System.Collections.Generic.List<char>();
            var sign = 0;

            for (var i = 0; i < str.Length; i++)
            {
                var ch = str[i];

                if (digitChars.Count == 0 && sign == 0 && (ch == '+' || ch == '-'))
                {
                    sign = ch == '+' ? 1 : -1;
                    continue;
                }
                var isDigit = char.IsDigit(ch);
                if (isDigit && sign == 0) sign = 1;

                if (digitChars.Count == 0 && ch == '0') continue;

                if (digitChars.Count == 0 && sign == 0 && ch == ' ') continue; //空格相比0要多加一个判断：未设置符号（即前面未出现过 +/-/数字）

                if (!isDigit)
                    break;

                digitChars.Add(ch);
            }

            if (digitChars.Count > 10) return sign == 1 ? int.MaxValue : int.MinValue;

            var sum = 0L;
            var numOfDigits = digitChars.Count;
            for (var i = 0; i < numOfDigits; i++)
            {
                var digit = (int)digitChars[i] - 48;
                if (numOfDigits == 2 && digit == 10) return int.MaxValue;

                sum += digit * (long)Math.Pow(10, numOfDigits - i - 1);

                if (sum > int.MaxValue) return sign == 1 ? int.MaxValue : int.MinValue;
            }
            return sign * (int)sum;
        }
    }
}
