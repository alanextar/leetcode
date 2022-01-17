using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    public class BinaryTreeInorderTraversal
    {
        private static List<int> inorderTraversalList = new ();

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return inorderTraversalList;
            }

            InorderTraversal(root.left);
            inorderTraversalList.Add(root.val);
            InorderTraversal(root.right);

            return inorderTraversalList;
        }

    }
}
