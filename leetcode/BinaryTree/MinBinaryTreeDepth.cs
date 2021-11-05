using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
	public class MinimumDepthBinaryTree
	{
		private Queue<(TreeNode, int)> que = new Queue<(TreeNode, int)>();

		public int MinDepth(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}

			return MinDepthUtil(root, 0);
		}

		int MinDepthUtil(TreeNode currentNode, int depth)
		{
			if (currentNode.left == null && currentNode.right == null)
			{
				return depth;
			}

			if (currentNode.left != null)
			{
				que.Enqueue((currentNode.left, depth + 1));
			}
			if (currentNode.right != null)
			{
				que.Enqueue((currentNode.right, depth + 1));
			}

			var dq = que.Dequeue();
			return MinDepthUtil(dq.Item1, dq.Item2);
		}
	}
}
