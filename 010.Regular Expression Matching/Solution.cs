using System;

namespace _010.Regular_Expression_Matching
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (s ==null || p==null) return false;
            if(p.Length>0 && p[0] == '*') return false;

            var dp = new bool[s.Length + 1][];
            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new bool[p.Length + 1];
            }

            dp[0][0] = true;
            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] == '*' && dp[0][j - 1])
                {
                    dp[0][j + 1] = true;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == '.' || p[j] == s[i])
                    {
                        dp[i + 1][j + 1] = dp[i][j];
                    }
                    if (p[j] == '*')
                    {
                        if (p[j - 1] != s[i] && p[j - 1] != '.')
                        {
                            dp[i + 1][j + 1] = dp[i + 1][j - 1];
                        }
                        else
                        {
                            dp[i + 1][j + 1] = (dp[i + 1][j] || dp[i][j + 1] || dp[i + 1][j - 1]);
                        }
                    }
                }
            }
            return dp[s.Length][p.Length];
        }
    }
}