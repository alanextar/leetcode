using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
	public class Merge_Sorted_Array
	{
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			if (n == 0)
			{
				return;
			}
			if (m == 0)
			{
				System.Array.Copy(nums2, 0, nums1, 0, n);
				return;
			}

			if (nums2[n - 1] > nums1[m - 1])
			{
				nums1[m + n - 1] = nums2[n - 1];
				n--;
			}
			else
			{
				nums1[m + n - 1] = nums1[m - 1];
				m--;
			}

			Merge(nums1, m, nums2, n);
		}
	}
}
