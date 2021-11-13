using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
	public class PathSum
	{
		public bool HasPathSum(TreeNode root, int targetSum)
		{
			if (root == null)
			{
				return false;
			}

			if (root.left == null && root.right == null)
			{
				return targetSum - root.val == 0;
			}

			if (root.left != null)
			{
				if(HasPathSum(root.left, targetSum - root.val))
				{
					return true;
				}
			}

			if(root.right != null)
			{
				if (HasPathSum(root.right, targetSum - root.val))
				{
					return true;
				}
			}

			return false;
		}
	}
}
