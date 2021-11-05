using leetcode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
	public class MergeBinaryTrees
	{
		static TreeNode mergedTree = new TreeNode();

		public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
		{
			return MergeTreesUtil(root1, root2, new TreeNode());
		}

		public TreeNode MergeTreesUtil(TreeNode root1, TreeNode root2, TreeNode mergedNode)
		{

			if (root1 == null && root2 == null)
			{
				return mergedNode;
			}

			if (root1 == null)
			{
				mergedNode = root2;
			}
			else if (root2 == null)
			{
				mergedNode = root1;
			}
			else
			{
				mergedNode ??= new TreeNode();
				mergedNode.val = root1.val + root2.val;
				var mergedLeft = MergeTreesUtil(root1?.left, root2?.left, mergedNode.left);
				var mergedRight = MergeTreesUtil(root1?.right, root2?.right, mergedNode.right);
				mergedNode.left = mergedLeft;
				mergedNode.right = mergedRight;
			}

			return mergedNode;
		}
	}
}
