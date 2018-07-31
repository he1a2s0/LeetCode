using System;

namespace _011.Container_With_Most_Water
{
    class Program
    {
        private static readonly Solution _solution  = new Solution();

        static void Main(string[] args)
        {
            var maxArea = _solution.MaxArea(new []{ 1,8,6,2,5,4,8,3,7});

            Console.WriteLine(maxArea);
        }
    }
}
