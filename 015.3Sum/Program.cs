using System;
using System.Collections.Generic;
using System.Linq;

namespace _015._3Sum
{
    class Program
    {
        private readonly static Solution _solution = new Solution();

        static void Main(string[] args)
        {
            Assert(
                new int[] { -1, 0, 1, 2, -1, -4 },
                new List<IList<int>>{
                    new List<int>{-1,-1,2},
                    new List<int>{-1,0,1}
                }
                );
        }

        static void Assert(int[] nums, IList<IList<int>> expected)
        {
            var actual = _solution.ThreeSum(nums);

            var eq = NestedListsEquals(actual, expected);
            Console.WriteLine(
                "[{0}]\t\t=>\t{1}\t{2}",
                string.Join(",", nums),
                eq ? "√" : "x",
                !eq ?
                    "[" + string.Join("],[", actual.Select(_ => string.Join(",", _))) + "]" :
                    string.Empty);
        }

        private static bool NestedListsEquals(IList<IList<int>> actual, IList<IList<int>> expected)
        {
            if (actual.Count != expected.Count) return false;
            for (var i = 0; i < actual.Count; i++)
            {
                if (!actual[i].SequenceEqual(expected[i]))
                    return false;
            }
            return true;
        }
    }
}
