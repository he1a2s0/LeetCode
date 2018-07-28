
# Regular Expression Matching (Difficulty: **_Easy_**)

link: https://leetcode.com/problems/regular-expression-matching

Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*'.

    '.' Matches any single character.
    '*' Matches zero or more of the preceding element.

The matching should cover the entire input string (not partial).

Note:

    s could be empty and contains only lowercase letters a-z.
    p could be empty and contains only lowercase letters a-z, and characters like . or *.

Example 1:

    Input:
    s = "aa"
    p = "a"
    Output: false
    Explanation: "a" does not match the entire string "aa".

Example 2:

    Input:
    s = "aa"
    p = "a*"
    Output: true
    Explanation: '*' means zero or more of the precedeng element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".

Example 3:

    Input:
    s = "ab"
    p = ".*"
    Output: true
    Explanation: ".*" means "zero or more (*) of any character (.)".

Example 4:

    Input:
    s = "aab"
    p = "c*a*b"
    Output: true
    Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore it matches "aab".

Example 5:

    Input:
    s = "mississippi"
    p = "mis*is*p*."
    Output: false


----

输入：字符串s 和 字符串p。s仅包含小写字母，可以为空；p仅包含小写字母、符号.和*，可以为空。

输出：s 是否匹配 p 所代表的简单正则表达式。


## 思路：

动态规划实现，完全参考了： https://leetcode.com/problems/regular-expression-matching/discuss/5651/Easy-DP-Java-Solution-with-detailed-Explanation

初始化矩阵（二维数组或jagged数组）dp，i范围0~s.Length+1，j范围0~p.Length+1
i,j可以看作字符间隙的索引

dp[i][j]表示p的子串(0~j-1)是否匹配s的子串(0~i-1)

1. 显然dp[0][0] = true
2. 初始化dp[0]，即i=0的行（相当于用p去匹配空串（s的子串
    + 循环 0 ~ j
    + p[j] == '*' 且 dp[0][j-1] 为 true 时将 dp[0][j+1] 也设为 true。(注意因p不允许以*开头，此时j必定>0)(
    + 解释：i,j可看作字符间隙的索引。对...<sub>[j-1]</sub>*\<char\><sub>[j+1]</sub>...，如果0~j-1匹配，且p[j]为*，则


----------------