
# Median of Two Sorted Arrays (Difficulty: **_Medium_**)

link: https://leetcode.com/problems/longest-palindromic-substring

Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:

    Input: "babad"
    Output: "bab"
    Note: "aba" is also a valid answer.

Example 2:

    Input: "cbbd"
    Output: "bb"

----

输入：最大长度为1000的字符串

输出：最长的回文子串（正序和倒序读是一样的串）

---

## 思路：

+ 长度为1，返回字符串
+ 长度为2，判断两个字符是否相同
+ 长度>2，分两种查找方式
    + 奇数长度的回文（比如...aba...）。从索引i向两侧扩展
    + 偶数长度的回文（比如...abba...）。从i,i+1向两侧扩展

---

设字符串长度为n，此方法需要分两次遍历字符串（范围：1 到 n-2），每次遍历又需要对每个索引做向外扩展（循环），最终是两个串行的嵌套循环，时间复杂度是 O(n^2)