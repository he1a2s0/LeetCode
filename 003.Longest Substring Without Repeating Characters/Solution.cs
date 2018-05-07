using System;

namespace _003.Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var occurenceTable = new bool[128];
            int start = 0, maxLength = 0, index = 0;
            char ch = char.MinValue;
            while (index < s.Length)
            {
                ch = s[index];
                if (!occurenceTable[ch])
                {
                    occurenceTable[ch] = true;
                }
                else
                {
                    var subLength = index - start;
                    maxLength = Math.Max(maxLength, subLength);
                    for (var j = start; j < index; j++)
                    {
                        if (s[j] == ch)
                        {
                            start = j + 1;
                            break;
                        }
                    }
                }
                index++;
            }
            return Math.Max(maxLength, index - start);
        }
    }
}
