
namespace _013.Roman_to_Integer
{
    public class Solution
    {
        private readonly static char[] _chars = new [] {'I','V','I','X','I','X','L','X','C','X', 'C','D','C','M','C', 'M'}; //MCM, CXC, XIX
        private readonly static int[] _values = new []{ 1,5,-1,10,-1,10, 50,-10,100,-10,100, 500,-100,1000,-100, 1000};

        public int RomanToInt(string s) {
            var num = 0;

            var i = s.Length-1;
            var p = 0;

            while(i >= 0){
                var ch = s[i];
                System.Console.WriteLine("s={0}, ch={1}({2}), rune={3}({4}), num={5}", s, ch, i, _chars[p], p, num);
                if(ch != _chars[p]){
                    p++;
                    if(p>=_chars.Length)
                        break;
                    continue;
                }
                
                num += _values[p];
                
                if(i==0)
                    break;

                if(s[i-1] != ch)
                    p ++;
                i--;
            }

            return num;
        }
    }
}