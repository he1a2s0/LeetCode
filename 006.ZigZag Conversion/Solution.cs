using System;

namespace _006.ZigZag_Conversion
{
    public class Solution
    {
        private readonly Func<int, int, int, int> _indexCalculator1 = null;
        private readonly Func<int, int, int, int> _indexCalculator2 = null;
        private readonly Func<int, int, int, int> _indexCalculator3 = null;

        public Solution()
        {
            _indexCalculator1 = (numRows, row, col) => row + 2 * col * (numRows - 1); // 首行 和 尾行 的索引计算器
            _indexCalculator2 = (numRows, row, col) => (col + 1) * (numRows - 1) - row; // 中间行 的 列（索引为奇数）对应的字符索引计算
            _indexCalculator3 = (numRows, row, col) => col * (numRows - 1) + row; // 中间行 的 列（索引为偶数）对应的字符索引计算
        }
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrWhiteSpace(s) || numRows <= 1) return s;
            if(s.Length < numRows) return s;

            var index = 0;
            Func<int, int, int, int> indexCalculator = null;
            var sb = new System.Text.StringBuilder();
            for (var row = 0; row < numRows; row++)
            {
                var maxCol = GetMaximiumColumnOfRow(s.Length, numRows, row);
                for (var col = 0; col <= maxCol; col++)
                {
                    indexCalculator = GetIndexCalculator(numRows, row, col);
                    index = indexCalculator(numRows, row, col);
                    sb.Append(s[index]);
                }
            }
            return sb.ToString();
        }

        private int GetMaximiumColumnOfRow(int strLen, int numRows, int row)
        {
            // row+col*2*(numRows-1) <= strLen-1
            //  maxCol = DoExactDivision(strLen-row-1, 2 * (numRows-1))
            if (row == 0 || row == numRows - 1)
                return DoExactDivision(strLen - row - 1, 2 * (numRows - 1));

            /* 
             * 当maxCol为奇数时： (col+1)*(numRows-1) - row <= strLen-1
             *      maxOddCol = DoExactDivision(strLen+row-1, numRows-1) -1
             * 当col为偶数时： col * (numRows -1) + row <= strLen-1
             *      maxEvenCol = DoExactDivision(strLen-row-1, numRows-1)
             * 求出两个，取较大的
             */
            var maxOddCol = DoExactDivision(strLen + row - 1, numRows - 1) - 1;
            if(maxOddCol%2==0) maxOddCol--; //应为奇数
            var maxEvenCol = DoExactDivision(strLen - row - 1, numRows - 1);
            if(maxEvenCol%2==1) maxEvenCol--; //应为偶数

            return Math.Max(maxOddCol, maxEvenCol);
        }

        private int DoExactDivision(int dividend, int divisor)
        {
            return (dividend - dividend % divisor) / divisor;
        }

        private Func<int, int, int, int> GetIndexCalculator(int numRows, int row, int col)
        {
            if (row == 0 || row == numRows - 1)
                return _indexCalculator1;

            if (col % 2 == 0)
                return _indexCalculator3;

            return _indexCalculator2;
        }
    }
}
