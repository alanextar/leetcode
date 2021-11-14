using leetcode.Array;
using leetcode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			//var arr1 = new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 };
			//var arr2 = new int?[] { -2, null, -3 };
			//var tree = new TreeNode(arr1);
			//var tree2 = new TreeNode(arr2);
			//var sln = new PathSum();
			//var hasPathSum = sln.HasPathSum(tree, 22);

			//var nums1 = new int[] { 5, 6, 9, 0, 0, 0 };
			//var nums2 = new int[] { 2, 3, 8 };
			//var nums1 = new int[] { 3, 6, 8, 0, 0, 0, 0, 0 };
			//var nums2 = new int[] { 1, 5, 7, 9, 15 };
			//var nums1 = new int[] { 0 };
			//var nums2 = new int[] { 1 };
			//var sln2 = new Merge_Sorted_Array();
			//sln2.Merge(nums1, 0, nums2, nums2.Length);

			var nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
			var nums2 = new int[] { -7, -5, -3, -2, 0, 0, 0, 1, 2, 5 };
			var nums3 = new int[] { 0, 0, 0 };
			var nums4 = new int[] { -1, 0, 1, 0 };
			var nums5 = new int[0];
			var nums6 = new int[] { -2, 0, 1, 1, 2 };
			var nums7 = new int[]{4, -2, -9, 9, 7, 9, 10, -15, 4, -9, -9, 8, -6, 7, -7, -2, 4, -9, -7, -11, 13, 9, 5, -8, 10, 8, -6, -1, -2, -6, 6, -12, 7, 4, 4, -9, -1, -1, -8, 10, 5, -10, -5, 7, 12, 4, 12, -6, 10, -10, -2, 8, 7, 10, 7, 2, -5, 9, -14, 9, -12, -1, 4, 2, 11, -15, 9, -13, -1, -14, 4, 12, -9, -15, -4, 10, 4, -7, -11, -9, -1, -6, 14, -9, -10, -1, 0, -8, -7, -6, 8, -12, 0, -3, 5, -4, -11, -1, -10, 4, -8, 10, -7, -10, 2, 4, -14};
			var nums8 = new int[] { 0, 0, 0, 0 };
			var sln = new Sum3();
			var treeSum1 = sln.ThreeSum(nums1);
			var treeSum2 = sln.ThreeSum(nums2);
			var treeSum3 = sln.ThreeSum(nums3);
			var treeSum4 = sln.ThreeSum(nums4);
			var treeSum5 = sln.ThreeSum(nums5);
			var treeSum6 = sln.ThreeSum(nums6);
			var treeSum7 = sln.ThreeSum(nums7);
			var treeSum8 = sln.ThreeSum(nums8);

			Console.WriteLine("Hello World!");
		}
	}
	
}
