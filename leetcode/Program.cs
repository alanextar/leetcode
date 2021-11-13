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
			var nums1 = new int[] { 0 };
			var nums2 = new int[] { 1 };
			var sln2 = new Merge_Sorted_Array();
			sln2.Merge(nums1, 0, nums2, nums2.Length);

			Console.WriteLine("Hello World!");
		}
	}
	
}
