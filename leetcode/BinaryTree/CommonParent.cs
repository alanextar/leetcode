using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    public class Solution
    {
        Dictionary<TreeNode, TreeNode> parents = new ();
        HashSet<TreeNode> parentsSet = new();

        public static void MainF(string[] args)
        {
            var arr1 = new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 };
            //var tree = new TreeNode(arr1);
            //var sln = new Solution();
            //sln.LowestCommonAncestor(tree, tree.left, tree.left.right.right);

            var arr2 = new int?[] { 1, 2 };
            var tree2 = new TreeNode(arr2);
            var sln = new Solution();
            sln.LowestCommonAncestor(tree2, tree2.left, tree2);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode ans = null;
            parents.Add(root, null);
            SetParents(root);

            parentsSet.Add(p);
            while (p != null)
            {
                parentsSet.Add(parents[p]);
                p = parents[p];
            }

            while (q != null)
            {
                if (parentsSet.Contains(q))
                {
                    ans = q;
                    break;
                }
                else if (parentsSet.Contains(parents[q]))
                {
                    ans = parents[q];
                    break;
                }

                q = parents[q];
            }

            return ans;
        }

        void SetParents(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null)
            {
                parents.Add(node.left, node);
                SetParents(node.left);
            }

            if (node.right != null)
            {
                parents.Add(node.right, node);
                SetParents(node.right);
            }
        }
    }
}
