
# Longest Substring Without Repeating Characters (Difficulty: **_Medium_**)

link: https://leetcode.com/problems/longest-substring-without-repeating-characters

Given a string, find the length of the longest substring without repeating characters.

Examples:

    Given "abcabcbb", the answer is "abc", which the length is 3.

    Given "bbbbb", the answer is "b", with the length of 1.

    Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

----

输入：字符串

输出：字符串中最长的无重复字符的串的长度。

---

## 思路：

+ 设为字符串s(假设仅包含ascii字符), 声明一个128长度的bool数组occurenceTable，用来表示字符是否出现过。数组下标等于字符十进制值。
+ 声明一个start整形变量，用于存储当前搜寻起点，其初始值为0；一个maxLength整形变量，用于存储最大长度；一个index整形变量，用于索引字符串的字符。
+ 遍历字符串的字符ch
    + 若遇到重复字符(occurenceTable[ch]为true)，则统计之前的start到当前index之前的串的长度，更新之前的maxLength值（取两者中较大的）
        + 并将start置为ch上次出现位置的后一位
	+ 否则将 occurenceTable[ch]设为true
+ 遍历结束后，返回max(maxLength,index-start)

