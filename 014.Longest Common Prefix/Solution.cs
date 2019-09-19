namespace _014.Longest_Common_Prefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length==0) return string.Empty;
            if(strs.Length==1) return strs[0];
        
            int i = 0;
            while (true)
            {
                char ch = char.MinValue;
                for (int c = 0; c < strs.Length; c++)
                {
                    if (strs[c].Length <= i || (ch != char.MinValue && ch != strs[c][i]))
                    {
                        return strs[c].Substring(0, i);
                        break;
                    }

                    ch = strs[c][i];
                }

                i++;
            }
        }
    }
}