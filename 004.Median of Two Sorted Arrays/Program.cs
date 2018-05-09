using System;

namespace _004.Median_of_Two_Sorted_Arrays
{
    class Program
    {
        private static readonly Solution solution = new Solution();

        static void Main(string[] args)
        {
            var nums1 = new []{ 1,3};
            var nums2 = new []{2};

            SolveAndPrint(nums1, nums2);

            nums2 = new []{2,4};

            SolveAndPrint(nums1, nums2);

            nums1 = new []{ 1,4,9,15};
            nums2 = new [] { 21,30,50};

            SolveAndPrint(nums1, nums2);

            nums1 = new []{ 4,9,15};
            SolveAndPrint(nums1, nums2);

            nums1 = new int[]{};
            nums2 = new int[]{1};
            SolveAndPrint(nums1, nums2);

            nums1 = new int[]{1};
            nums2 = new int[]{};
            SolveAndPrint(nums1, nums2);

            nums1 = new int[]{};
            SolveAndPrint(nums1, nums2);

            nums2 = new int[]{2,3};
            SolveAndPrint(nums1, nums2);

            nums2 = new int[]{1,2,3,4};
            SolveAndPrint(nums1, nums2);

        }

        static void SolveAndPrint(int[] nums1, int[] nums2){
            var result = solution.FindMedianSortedArrays(nums1,nums2);
            Console.WriteLine("[{0}], [{1}] => {2:F3}", string.Join(",",nums1), string.Join(",",nums2), result);
        }
    }
}
