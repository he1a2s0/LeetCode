
using System;

namespace _011.Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            for (int i = 0, j = height.Length - 1; i < j;)
            {
                var area = Math.Min(height[i], height[j]) * (j - i);
                if (area > maxArea)
                    maxArea = area;

                if (height[i] > height[j])
                    j--;
                else
                    i++;
            }

            return maxArea;
        }
    }
}