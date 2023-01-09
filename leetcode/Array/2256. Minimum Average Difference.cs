using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    //https://leetcode.com/problems/minimum-average-difference/discussion/

    public class _2256
    {
        public int MinimumAverageDifference(int[] nums) {
            if (nums.Length == 1)
            {
                return 0;
            }

            long minAvg = 0;
            int res = 0;
            long wholeSum = nums.Sum(n => (long)n);
            long leftPartSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                leftPartSum += nums[i];
                var temp = Math.Abs(leftPartSum/(i + 1) - (wholeSum - leftPartSum)/(i == (nums.Length - 1) ? 1 : (nums.Length - i - 1)));
                if (i == 0)
                {
                    minAvg = temp;
                }

                if (temp < minAvg)
                {
                    res = i;
                    minAvg = temp;
                };
            }

            return res;
        }
    }

    public static class Program2256
    {
        public static void Main2256(string[] args)
        {
            var s = new _2256();

            Assert.AreEqual(0, s.MinimumAverageDifference(new int[] {1,2,3,4,5}));
            Assert.AreEqual(3, s.MinimumAverageDifference(new int[] {2,5,3,9,5,3}));
            Assert.AreEqual(0, s.MinimumAverageDifference(new int[] {0}));
        }
    }
}
