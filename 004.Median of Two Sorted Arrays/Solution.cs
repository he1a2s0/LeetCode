using System;

namespace _004.Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length, n = nums2.Length;
            var len = m+n;
            if(len == 0) return 0;

            var k = (len+1)/2;
            //k从1开始
            // 当len为奇数时，求第k小的数(k=len+1/2)
            if(len % 2 ==1)
                return GetKth(nums1, 0, nums2, 0, k);

            //当len为偶数时，求第k,k+1小的两个数据的均值
            return (GetKth(nums1, 0, nums2, 0, k) + GetKth(nums1, 0, nums2, 0, k+1)) / 2;
        }

        private double GetKth(int[] nums1, int start1, int[] nums2, int start2, int k)
        {
            if (start1 > nums1.Length - 1) return nums2[start2 + k - 1];
            if (start2 > nums2.Length - 1) return nums1[start1 + k - 1];

            if (k == 1) return Math.Min(nums1[start1], nums2[start2]);

            int mid1 = int.MaxValue, mid2 = int.MaxValue;

            // 从start1,start2开始找 nums1,nums2 中第k小的数，分别取两个数组的第 start1 + k/2, start1 + k/2 小的值(如果索引存在)
            if (start1 + k / 2 - 1 < nums1.Length) mid1 = nums1[start1 + k / 2 - 1];
            if (start2 + k / 2 - 1 < nums2.Length) mid2 = nums2[start2 + k / 2 - 1];

            //如果mid1 < mid2，那么 nums1[start1, start1 + k/2 - 1] 之间的数都应排除
                // 可假设合并nums1[start1,start1+k-1]，nums2[start2,start2+k-1] 为 merged，那么nums1[start1, start1 + k/2 - 1]中的数必定都是小于merged的第k小的值的
                // 排除 nums1[start1, start1 + k/2 - 1] （将nums1的开始索引指向start1' = start1+k/2）；然后从start1',start2开始找nums1,nums2中找第 k-k/2 小的数（因为已经排除了k/2个数，接下来只用找第k-k/2小的数）
            if (mid1 < mid2)
                return GetKth(nums1, start1 + k / 2, nums2, start2, k - k / 2);
            else
                return GetKth(nums1, start1, nums2, start2 + k / 2, k - k / 2);
        }
    }
}
