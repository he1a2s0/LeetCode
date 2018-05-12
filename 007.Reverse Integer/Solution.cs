using System;

namespace _007.Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if(x == int.MinValue) return 0;

            var digits = new System.Collections.Generic.List<int>();

            var negative = x < 0;
            var abs = Math.Abs(x);
            while (abs > 10)
            {
                digits.Add(abs%10);

                abs = abs/10;
            }
            digits.Add(abs);

            long result = 0;
            for (var i = 0; i < digits.Count; i++)
            {
                var digit = digits[i];
                if (digit == 0) continue;

                result += (long)(digit * Math.Pow(10, digits.Count - i - 1));
            }
            if(result > int.MaxValue) return 0;

            return negative ? (int)-result : (int)result;
        }
    }
}
