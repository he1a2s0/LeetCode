
# ZigZag Conversion (Difficulty: **_Medium_**)

link: https://leetcode.com/problems/zigzag-conversion

The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

    P   A   H   N
    A P L S I I G
    Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

    string convert(string s, int numRows);

Example 1:

    Input: s = "PAYPALISHIRING", numRows = 3
    Output: "PAHNAPLSIIGYIR"

Example 2:

    Input: s = "PAYPALISHIRING", numRows = 4
    Output: "PINALSIGYAHRPI"

    Explanation:

    P     I    N
    A   L S  I G
    Y A   H R
    P     I


----

输入：字符串str，行数numRows

输出：将str按行数排列成z字型，逐行逐字符拼接成的新字符串。

---

## 思路：

找寻规律：

+ 首行和末行，两个字符间索引总是相隔 2*(numRows - 1), 因此首行和末行 index(row,col) = row + col * 2 * (numrows - 1)
+ 中间行。见下表...

| 行索引 | 字符索引增量 |
|-------|-------------|
| 0 | row + 2*(numRows-1) |
| 1 | 下一索引为奇数：2(numRows-2)；为偶数 +2 |
| 2 | 下一索引为奇数：2(numRows-3)；为偶数 +4 |
| 3 | 下一索引为奇数：2(numRows-4)；为偶数 +6 |
|...| ... |

依此类推。行索引为 row 时，则索引按 2*(numRows-row-1) 和 2*row 交替增长。

即下一索引为奇数时，索引=前一索引+2*(numRows-row-1)，下一索引为偶数时，索引=前一索引+2*row

行索引为 row(>0) 时，列索引为 col 时:

(row, col) 处的字符在源字符串中的索引可以通过以下式子来求：

    // 索引 = 基数 + ((col+1)/2)个奇数增量 + (col/2)个偶数增量
    index(row,col) = row + ((col+1)/2) * 2 * (numRows-row-1) + (col/2) * 2 * row
    // (col+1) 和 col 总有一个无法被2整除，分两种情况简化：
        // col为奇数时： ((col+1)/2)*2 = col+1; (col/2)*2 = col-1：
            index(row,col) 
                = row + (col+1)*(numRows-row-1) + (col-1) * row
                = (col+1)*(numRows-1) - row
        // col为偶数时：((col+1)/2)*2  = col; (col/2) * 2 = col;
            index(row,col)
                = row + col * (numRows-row-1) + col * row
                = col * (numRows -1) + row 
    
说明：
+  range[1,col] 包含 (col+1)/2 个奇数索引，col/2 个偶数索引 (不包括 col=0。col=0时，index[row,0] == row，用作增长的基数)
+ 当col为奇数时，(col+1)/2 = col/2；当col为偶数时，(col+1)/2 = col/2 + 1

算法实现：

+ 循环 0 - row ：
+ 计算本行的列数  (index(row,col) <= str.length-1 时的col)
    + 循环 0 - col :
    + 计算索引 index(row,col)
    + 附加字符到结果

---
