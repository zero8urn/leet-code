using System.Text.RegularExpressions;

namespace DSA.Problems.Arrays;

public static class FindClosestNumber
{
    public class Solution
    {
        /// <summary>
        /// Given an integer array nums of size n,
        /// return the number with the value closest to 0 in nums.
        /// If there are multiple answers, return the number with the largest value.
        /// https://leetcode.com/problems/find-closest-number-to-zero/description/
        /// </summary>
        /// <param name="nums">Description of input parameter</param>
        /// <param name="targetNumber"></param>
        /// <returns>Description of return value</returns>
        public int Solve(int[] nums)
        {
            int targetNumber = 0;
            return nums.FindDistance(targetNumber)
                .Select(x => (x, Math.Abs(x)))
                .OrderBy(x => x.Item2 )
                .ThenByDescending(x => x.Item1)
                .FirstOrDefault().Item1;
        }
    }

    private static IEnumerable<int> FindDistance(this int[] source, int target)
    {
        return source.Select(i => i - target);
    }
}