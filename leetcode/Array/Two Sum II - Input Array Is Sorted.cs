using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
	public class Two_Sum_II___Input_Array_Is_Sorted
	{
		public int[] TwoSum_Brute(int[] numbers, int target)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (target == numbers[i] + numbers[j])
					{
						return new int[] { i + 1, j + 1 };
					}
				}
			}

			return new int[0];
		}
	}
}
