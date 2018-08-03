
# Roman To Integer (Difficulty: **_Easy_**)

link: https://leetcode.com/problems/roman-to-integer 

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000

For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

+ I can be placed before V (5) and X (10) to make 4 and 9. 
+ X can be placed before L (50) and C (100) to make 40 and 90. 
+ C can be placed before D (500) and M (1000) to make 400 and 900.

Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

Example 1:

    Input: "III"
    Output: 3

Example 2:

    Input: "IV"
    Output: 4

Example 3:

    Input: "IX"
    Output: 9

Example 4:

    Input: "LVIII"
    Output: 58
    Explanation: C = 100, L = 50, XXX = 30 and III = 3.

Example 5:

    Input: "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

----

输入：表示罗马数字的字符串（表示的罗马数字在1-3999之间）。

输出：整数。


## 思路：

* 定义字符表，按顺序列出所有罗马数字可能出现的位置；并定义相应的值表。
* 对传入的字符串，逐字符由后向前。
* 设定一个字符表索引指针，对比字符表中当前字符 和 传入字符串的当前字符，按对比结果决定是否加上 值表 中对应的值。
    * 过程中需处理 I,X,C,M重复出现的情况。（I,X,C,M接连重复出现时，字符表索引指针不向前移）

----------------

[submission detail on leetcode](https://leetcode.com/submissions/detail/167376747/)