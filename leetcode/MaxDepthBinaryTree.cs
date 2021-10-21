using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public static class MaxDepthSolutions
	{
        public static TreeNode InitTestCase1()
        {
            //root = [3, 9, 20, null, null, 15, 7]
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            return root;
        }

        public static TreeNode InitTestCase2()
        {
            TreeNode root = new TreeNode(3);
            root.right = new TreeNode(2);

            return root;
        }

        public static TreeNode InitTestCase3()
        {
            return null;
        }
    }

	class MaxDepthBinaryTree
	{
        int max = 0;

        public int MaxDepth(TreeNode root)
        {
            Dfs(root, 1);
            return max;
        }

        void Dfs(TreeNode node, int level)
        {

            if (node == null)
            {
                max = Math.Max(level - 1, max);
                return;
            }

            Dfs(node.left, level + 1);
            Dfs(node.right, level + 1);
        }
    }

	class MaxDepthBinaryTreeMySolution
	{
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var nodesStack = new Stack<TreeNode>();
            var depthDictionary = new Dictionary<TreeNode, ushort>();
            ushort maxDepth = 1;
            ushort depth = 1;
            depthDictionary.Add(root, depth);

            while (root != null)
            {
                var isRightNodeExists = root.right != null;
                var isLeftNodeExists = root.left != null;
                depth = ++depthDictionary[root];

                if (isRightNodeExists)
                {
                    nodesStack.Push(root.right);
                    depthDictionary.Add(root.right, depth);

                }
                if (isLeftNodeExists)
                {
                    nodesStack.Push(root.left);
                    depthDictionary.Add(root.left, depth);
                }
                if (isRightNodeExists || isLeftNodeExists)
                {
                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }

                if (nodesStack.Any())
                {
                    root = nodesStack.Pop();
                }
                else
                {
                    nodesStack = null;
                    root = null;
                }

            }

            return maxDepth;
        }
    }

    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
