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
		public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
		{
			if (root1 == null && root2 == null)
			{
				return null;
			}

			var mergedNode = new TreeNode();
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
				mergedNode.val = root1.val + root2.val;
				mergedNode.left = MergeTrees(root1?.left, root2?.left);
				mergedNode.right = MergeTrees(root1?.right, root2?.right);
			}

			return mergedNode;
		}
	}
}
