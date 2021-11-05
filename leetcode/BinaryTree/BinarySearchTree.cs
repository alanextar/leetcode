using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
	public class BinarySearchTree
	{
		public TreeNode SortedArrayToBST(int[] nums)
		{
			return SortedArrayToBSTUtil(nums, 0, nums.Length - 1);
		}

		TreeNode SortedArrayToBSTUtil(int[] nums, int left, int right)
		{
			if (left > right)
			{
				return null;
			}
			if (left == right)
			{
				return new TreeNode(nums[left]);
			}

			var middle = (int)Math.Ceiling(((decimal)right + left)/2);

			var treeNode = new TreeNode(nums[middle]);

			treeNode.left = SortedArrayToBSTUtil(nums, left, middle - 1);
			treeNode.right = SortedArrayToBSTUtil(nums, middle + 1, right);

			return treeNode;
		}
	}
}
 