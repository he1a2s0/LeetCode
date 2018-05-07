using System;
using System.Collections.Generic;

namespace _001.Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>(); // num : index

            for (var i = 0; i < nums.Length; i++)
            {
                var remainder = target - nums[i];
                if(dict.ContainsKey(remainder))
                    return new []{ dict[remainder],i};

                if(dict.ContainsKey(nums[i]))
                    continue;

                dict.Add(nums[i],i); //no same element
            }
            throw new Exception();
        }
    }
}
