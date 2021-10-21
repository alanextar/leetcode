using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
            //root = [3, 9, 20, null, null, 15, 7]
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            TreeNode root1 = new TreeNode(3);
            root1.right = new TreeNode(2);

            TreeNode root2 = null;

            var s = new Solution();
            var maxDepth1 = s.MaxDepth(root);
            var maxDepth2 = s.MaxDepth(root1);
            var maxDepth3 = s.MaxDepth(root2);

			Console.WriteLine("Hello World!");
		}
	}

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            TreeNode currentNode = root;
            Stack<TreeNode> nextNodes = new Stack<TreeNode>();
            Dictionary<TreeNode, int> depthDictionary = new Dictionary<TreeNode, int>();
            int maxDepth = 1;
            int depth = 1;
            depthDictionary.Add(currentNode, depth);

            while (currentNode != null)
            {
                var isRightNodeExists = currentNode.right != null;
                var isLeftNodeExists = currentNode.left != null;
                depth = depthDictionary[currentNode] + 1;
                if (isRightNodeExists)
                {
                    nextNodes.Push(currentNode.right);
                    depthDictionary.Add(currentNode.right, depth);
                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }
                if (isLeftNodeExists)
                {
                    nextNodes.Push(currentNode.left);
                    depthDictionary.Add(currentNode.left, depth);
                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }

                if (nextNodes.Any())
                {
                    currentNode = nextNodes.Pop();
                }
                else
                    break;
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
