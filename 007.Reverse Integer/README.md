
# Reverse Integer (Difficulty: **_Easy_**)

link: https://leetcode.com/problems/reverse-integer

Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

    Input: 123
    Output: 321

Example 2:

    Input: -123
    Output: -321

Example 3:

    Input: 120
    Output: 21

### **Note**:

Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2<sup>31</sup>,  2<sup>31</sup> − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

----

输入：整数。范围在[−2<sup>31</sup>,  2<sup>31</sup> − 1]之间。

输出：按位反转整数数字后的新整数。（符号要一致；超出范围[−2<sup>31</sup>,  2<sup>31</sup> − 1]时输出0）


## 思路：
+ 逐位取单个数字，添加到列表
+ 列表逐项乘上反转的 10<sup>n</sup> （n=列表项数-索引-1）后相加

---------------------------------------------------------------------------------------

