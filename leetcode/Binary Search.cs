using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
	public class Binary_Search
	{
		public static int[] nums1 = { -1, 1, 3, 5, 9, 12 };
		public static int[] nums2 = { 2, 5 };
		public static int[] nums3 = { 5 };

		public int Search(int[] nums, int target)
		{
			return Search(0, nums.Length - 1, target, nums);
		}

		public int Search(int left, int right, int target, int[] nums)
		{
			if (left > right)
			{
				return -1;
			}
			var middleIndex = left + (right - left) / 2;

			if (nums[middleIndex] == target)
			{
				return middleIndex;
			}
			else if (nums[middleIndex] > target)
			{
				return Search(left, middleIndex - 1, target, nums);
			}
			else
			{
				return Search(middleIndex + 1, right, target, nums);
			}
		}
	}
}
