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
			var arr1 = new int[] {0, 1, 2, 3, 4, 5};
			var mergeTreeSln = new BinarySearchTree();
			var merged = mergeTreeSln.SortedArrayToBST(arr1);


			Console.WriteLine("Hello World!");
		}
	}
	
}
