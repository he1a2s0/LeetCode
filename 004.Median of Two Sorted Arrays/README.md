
# Median of Two Sorted Arrays (Difficulty: **_Hard_**)

link: https://leetcode.com/problems/median-of-two-sorted-arrays

There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be **O(log (m+n))**.

Example 1:

    nums1 = [1, 3]
    nums2 = [2]

    The median is 2.0

Example 2:

    nums1 = [1, 2]
    nums2 = [3, 4]

    The median is (2 + 3)/2 = 2.5
----

输入：两个已排序的数组

输出：两个数组所有数的中值

---

## 思路：

( 参考了：https://leetcode.com/problems/median-of-two-sorted-arrays/discuss/2496/Concise-JAVA-solution-based-on-Binary-Search )

    len = nums1.Length + nums2.Length;
    k = (len + 1)/2; //k从1开始算
    
+ 可以看作是求解：
    + 当len为奇数时，第k小的值
    + 当len为偶数量，第k,k+1小的两个值的均值

+ 具体思路是将两个数组多次从中分割，判断中值后排除其中一个数组的一半，然后查找第 k-k/2 小的值

---

设 m=nums1.Lenght, n=nums2.Length, k=(len+1)/2

对m+n个数来说，递归调用每次排除k/2，然后k=k-k/2，因此最终执行次数为 log(k), 即 log((m+n+1)/2)，因此算法复杂度为 O(log(m+n))

