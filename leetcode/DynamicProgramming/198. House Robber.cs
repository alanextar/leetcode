using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DynamicProgramming
{
    //48 test cases passed but failed

    internal class _198
    {
        public int Rob(int[] nums) {
            int rob = 0;
            int notrob = 0;

            for(int i=0; i < nums.Length; i++) {
                int currob = notrob + nums[i];
                notrob = Math.Max(notrob, rob);
                rob = currob;
            }

            return Math.Max(rob, notrob);
        }
    }

    public static class Program_198
    {
        public static void Main_198(string[] args)
        {
            int[] nums4 = new int[] {2,4,8,9,9,3};
            int[] nums1 = new int[] {1,2,3,1};
            int[] nums2 = new int[] {2,7,9,3,1};
            int[] nums3 = new int[] {1,1,1,2};
            int[] nums5 = new int[] {2,1,1,2};

            var s = new _198();

            Assert.AreEqual(4, s.Rob(nums5));
            Assert.AreEqual(19, s.Rob(nums4));
            Assert.AreEqual(4, s.Rob(nums1));
            Assert.AreEqual(12, s.Rob(nums2));
            Assert.AreEqual(3, s.Rob(nums3));
        }
    }
}
