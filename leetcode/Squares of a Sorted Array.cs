using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
	//https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/
	public class Squares_of_a_Sorted_Array
	{
		public static int[] mixed = new int[] { -7, -3, 2, 3, 3, 11 };
		public static int[] allNegative = new int[] { -5, -3, -2, -1 };
		public static int[] allNegativeWithZero = new int[] { -5, -3, -2, 0 };
		public static int[] allPositive = new int[] { 1, 2, 3, 4 };
		public static int[] allPositiveWithZero = new int[] { 0, 1, 2, 3, 4 };
		public static int[] mixedWithDuplicates = new int[] { -10000, -9999, -7, -5, 0, 0, 10000 };
		public static int[] mixedWithManyDuplicates = new int[] { -10000, -9999, -7, -5, 0, 0, 10000 };
		public static int[] withOne = new int[] { -3, -3, -2, 1 };

		public int[] SortedSquares111(int[] nums)
		{
			var length = nums.Length;
			int j = length - 1;
			int i = 0;
			int z = i;
			var k = j;
			var sortedSquaredArr = new int[length];

			//if (nums[j] * nums[i] > 0)
			//{
			//	return SquaredSortedWithSameSign(nums);
			//}

			while (j >= i)
			{
				if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
				{
					nums.SwapValues(i, j);
				}

				sortedSquaredArr[j] = nums[j] * nums[j];
				sortedSquaredArr[i] = nums[i] * nums[i];
				if (j < length - 2)
				{
					while (sortedSquaredArr[j] > sortedSquaredArr[j + 1])
					{
						sortedSquaredArr.SwapValues(j, j + 1);
					}
				}

				if (i > 0)
				{
					while (sortedSquaredArr[i] < sortedSquaredArr[i - 1])
					{
						sortedSquaredArr.SwapValues(i - 1, i);
					}
					
				}

				j--;
			}

			return sortedSquaredArr;
		}

		public int[] SortedSquares(int[] nums)
		{
			var length = nums.Length;
			int j = length - 1;
			int i = 0;

			if (nums[j] * nums[i] > 0)
			{
				return SquaredSortedWithSameSign(nums);
			}

			while (j >= i)
			{
				if (i == j)
				{
					nums[j] = nums[j] * nums[j];
					break;
				}

				if (nums[i] == 0)
				{
					i++;
					continue;
				}

				if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
				{
					nums.SwapValues(i, j);
				}

				nums[j] = nums[j] * nums[j];
				j--;
			}

			return nums;
		}

		private int[] SquaredSortedWithSameSign(int[] nums)
		{
			int j = nums.Length - 1;
			var areAllNegativeNums = false;

			if (nums[j] < 0)
			{
				areAllNegativeNums = true;
			}

			for (int i = 0; i <= j; i++, j--)
			{
				nums[i] = nums[i] * nums[i];

				if (i != j)
				{
					nums[j] = nums[j] * nums[j];
					if (areAllNegativeNums)
					{
						nums.SwapValues(i, j);
					}
				}
			}

			return nums;
		}

		public int[] SortedSquaresTrivial(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] = nums[i] * nums[i];
			}

			Array.Sort(nums, 0, nums.Length);

			return nums;
		}

	}

	public static class ArrExtensions
	{
		public static void SwapValues<T>(this T[] source, long index1, long index2)
		{
			T temp = source[index1];
			source[index1] = source[index2];
			source[index2] = temp;
		}
	}
}
