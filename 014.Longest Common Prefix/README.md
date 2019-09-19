
# Longest Common Prefix (Difficulty: **_Easy_**)

link: https://leetcode.com/problems/longest-common-prefix 

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

**Example 1:**

    Input: ["flower","flow","flight"]
    Output: "fl"

**Example 2:**

    Input: ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.

**Note:**

All given inputs are in lowercase letters `a-z`.

----

输入：字符串数组。

输出：最长的公共前缀子串。


## 思路：

* 逐个比较每个字符串同一位置上的字符。
* 直到遇到 不相同的字符 或 某个字符串的结尾。

----------------

[submission detail on leetcode](https://leetcode.com/submissions/detail/262301797/)