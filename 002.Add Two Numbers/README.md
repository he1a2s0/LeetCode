
# Add Two Numbers (Difficulty: **_Medium_**)

link: https://leetcode.com/problems/add-two-numbers

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
    Explanation: 342 + 465 = 807.

----

输入：两个链表，其节点的值为一位的非负数字（0-9)

输出：新链表，每个节点的值是给定的两个链表的节点值的和。

---

说明：
+ 如果和超过10，则取个位为结果，10作为进位1加到后一组节点的和上；（类似于整数加法进位，但进位方向相反）
+ 空节点（无节点视为空节点）其值视为0（即不用相加）

---

## 思路：

    使用循环来遍历两个链表，依次将节点的值相加，更新到目标链表，直到末尾（两个链表的下一个节点都为null)

	用carry记录上次相加的结果是否大于10，若大于10，则本次相加的结果应加上1（进位）

    注意，若末尾两节点的和大于10，则应在末尾再加一个值为1的节点
