using System;

namespace _001.Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new []{2, 7, 11, 15};
            var target = 9;

            var result = new Solution().TwoSum(nums, target);

            Console.WriteLine(string.Join(",",result));
        }
    }
}
