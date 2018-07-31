
# Regular Expression Matching (Difficulty: **_Medium_**)

link: https://leetcode.com/problems/container-with-most-water

Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.

![illustration](https://s3-lc-upload.s3.amazonaws.com/uploads/2018/07/17/question_11.jpg)

The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

Example:

    Input: [1,8,6,2,5,4,8,3,7]
    Output: 49

----

输入：仅包含非负整数的数组，长度>=2。

输出：以索引作为x，以元素值作为y，求能装最多水的两个元素组成的容器的面积。


## 思路：

* 最外侧两个元素级成容器，逐个元素的从两侧向内迭代
* 选取组成当前容器的两个元素中较小的的索引，向较大的一方移动一格，判断新的容器面积是否大于旧容器，更新最大面积的值
* 重复上述步骤，直到两个元素索引碰面


----------------