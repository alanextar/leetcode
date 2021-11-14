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

			for (int i = 0; i < nums.Length - 2; i++)
			{
				if (i > 0 && nums[i] == nums[i - 1])
				{
					continue;
				}
				var l = i + 1;
				var r = nums.Length - 1;

				while (l < r)
				{
					var target = -nums[i];
					var twoSum = nums[l] + nums[r];
					if (twoSum == target)
					{
						var newDecision = new List<int> { nums[i], nums[l], nums[r] };
						result.Add(newDecision);
					}
					else if (twoSum < target)
					{
						while (l < r && nums[l] == nums[l + 1])
						{
							l++;
						}
						l++;
						continue;
					}

					while (r > l && nums[r] == nums[r - 1])
					{
						r--;
					}
					r--;
				}
			}

			return result;
		}
	}
}
