using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
	public class Sum3
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			var result = new List<IList<int>>();
			if (nums.Length < 3)
			{
				return result;
			}
			System.Array.Sort(nums);

			var numsList = nums.ToList();
			for (int i = 0; i < nums.Length; i++)
			{
				TwoSumSortedAll(numsList, -nums[i], exclusion:i, result);
			}

			return result;
		}

		private void TwoSumSortedAll(List<int> nums, int target, int exclusion, List<IList<int>> result)
		{
			if (nums.Count < 2)
			{
				return;
			}

			var l = 0;
			var r = nums.Count - 1;

			while (r > l)
			{
				if (r == exclusion)
				{
					r--;
					continue;
				}
				if (l == exclusion)
				{
					l++;
					continue;
				}

				var twoSum = nums[l] + nums[r];
				if (twoSum == target)
				{
					var newDecision = new List<int> { nums[exclusion], nums[l], nums[r] };
					if (!result.Any(l => l.Except(newDecision).Count() == 0))
					{
						result.Add(newDecision);
					}

					l++;
				}
				else if (twoSum > target)
				{
					r--;
				}
				else
				{
					l++;
				}
			}

			return;
		}
	}
}
