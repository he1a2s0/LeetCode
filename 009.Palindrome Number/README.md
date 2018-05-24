
# Palindrome Number (atoi) (Difficulty: **_Easy_**)

link: https://leetcode.com/problems/palindrome-number

Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1:

    Input: 121
    Output: true

Example 2:

    Input: -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

    Input: 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

Follow up:

Coud you solve it without converting the integer to a string?

----

输入：任意整数。

输出：整数的数字是否组成回文，是则输出true，否则输出false。


## 思路：

+ 负数不可能为回文
+ 逐位取数字到列表
+ 判断列表数字是否为回文，两侧向里判断

----------------