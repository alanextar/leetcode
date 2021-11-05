using leetcode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{

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

    /// <summary>
    /// решение с leetcode, почему то валится на последних тестах
    /// </summary>
	class MaxDepthBfs
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var que = new Queue<TreeNode>();
            que.Enqueue(root);
            int depth = 0;
            TreeNode node = root;

            while (que.Any())
            {
                for (int i = 0; i < que.Count; i++)
                {
                    node = que.Dequeue();

                    var isRightNodeExists = node.right != null;
                    var isLeftNodeExists = node.left != null;

                    if (isLeftNodeExists)
                    {
                        que.Enqueue(node.left);
                    }
                    if (isRightNodeExists)
                    {
                        que.Enqueue(node.right);

                    }
                }

                depth++;
            }

            return depth;
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
}
