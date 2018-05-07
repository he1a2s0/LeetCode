
# Two Sum (Difficulty: **_Easy_**)

link: https://leetcode.com/problems/two-sum/

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].

----

输入：整数数组array，整数sum

输出：整数数组中 和等于sum 的两个数在数组中的 索引。


## 思路：
	声明一个字典Dictionary<int,int>，并遍历数组每一项：
		1.用sum减去此项得到reminder，如果字典中有此键，则已找到结果，直接返回reminder值对应的索引和当前项的索引即可；如无，则转2。
		2.判断字典中是否有以当前整数为键的项，有则跳过，无则添加

---------------------------------------------------------------------------------------

循环内用了两次字典的ContainsKey方法，不过Dictionary类似Hash表，ContainsKey是时间复杂度为O(1)的方法，因此此答案时间复杂度为O(n)
