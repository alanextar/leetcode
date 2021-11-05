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
			var arr1 = new int?[] { 1, 3, 2, 5 };
			var arr2 = new int?[] { 2, 1, 3, null, 4, null, 7 };
			var t1 = new TreeNode(arr1);
			var t2 = new TreeNode(arr2);
			var mergeTreeSln = new MergeBinaryTrees();
			var merged = mergeTreeSln.MergeTrees(t1, t2);


			Console.WriteLine("Hello World!");
		}
	}
	
}
