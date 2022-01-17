using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    public class BalancedBinaryTree
    {
        private bool result = true;

        public bool IsBalanced(TreeNode root)
        {
            MaxDepth(root);
            return result;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int l = MaxDepth(root.left);
            int r = MaxDepth(root.right);
            if (Math.Abs(l - r) > 1)
                result = false;
            return 1 + Math.Max(l, r);
        }

    }
}
