using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
	class Merge_Intervals
	{
		public static int[][] intervals1 = new int[][] { 
			new int[] {1, 3}, 
			new int[] {15, 18}, 
			new int[] {2, 6}, 
			new int[] {8, 10}, 
		};

		public static int[][] twoInterval = new int[][] { 
			new int[] {1, 4}, 
			new int[] {4, 5}
		};

		public static int[][] empty = new int[][] { };

		public int[][] MergeMySoultion(int[][] intervals)
		{
			var length = intervals.Length;
			var result = new int[length][];

			System.Array.Sort(intervals, new ArrayComparer());

			int[] mergeRequest = null;
			var isMerged = false;
			int[] f;
			int[] s;
			var k = 0;

			for (int i = 0; i < length; i++)
			{
				if (isMerged)
				{
					f = mergeRequest;
				}
				else
				{
					f = intervals[i];
				}

				if (i == length - 1)
				{
					result[k] = f;
					break;
				}

				s = intervals[i+1];

				if (f[1] >= s[0])
				{
					mergeRequest = new int[] { f[0], Math.Max(f[1], s[1]) };
					isMerged = true;
				}
				else
				{
					result[k++] = f;
					isMerged = false;
				}
			}

			return result.Where(r => r != null).ToArray();
		}

		public int[][] Merge(int[][] intervals)
		{
			intervals = intervals.OrderBy(interval => interval[0]).ToArray();

			var merged = new List<int[]>();

			foreach (var interval in intervals)
			{
				if (merged.Count == 0)
				{
					merged.Add(interval);
				}
				else if (interval[0] <= merged.Last()[1])
				{
					merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
				}
				else
				{
					merged.Add(interval);
				}
			}

			return merged.ToArray();
		}
	}

	class ArrayComparer : IComparer<int[]>
	{
		public int Compare(int[] x, int[] y)
		{
			return x[0].CompareTo(y[0]);
		}
	}
}

//var f = intervals[0];
//var s = intervals[1];

//if (f[1] >= s[0] && f[0] <= s[1])
//{
//	var merged = new int[] { Math.Min(f[0], s[0]), Math.Max(f[1], s[1]) };
//}