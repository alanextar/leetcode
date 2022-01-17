using leetcode.Array;
using leetcode.BinaryTree;
using leetcode.LinkedList;
using leetcode.StackQueue;
using leetcode.String;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			//root = [3, 9, 20, null, null, 15, 7]
			//root = [1,null,2,null,3]
			TreeNode root = new TreeNode(0);
			root.left = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			root.right.right = new TreeNode(4);
			root.right.right.left = new TreeNode(5);
			root.right.right.left.left = new TreeNode(7);
			root.right.right.left.right = new TreeNode(8);
			root.right.right.right = new TreeNode(6);
			var sln = new BinaryTreeInorderTraversal();
			var traversal = sln.InorderTraversal(root);

			Console.WriteLine("Hello World!");
		}
	}
	
}
