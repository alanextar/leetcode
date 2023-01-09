using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    internal class _1339
    {
        long max = 0;
        public int MaxProduct(TreeNode root) {
            FindMax(root, FindTotal(root));
            return (int)(max % 1_000_000_007);
        }

        // find total sum of the tree
        private long FindTotal(TreeNode root){
            if(root == null) return 0;
            return FindTotal(root.left) + FindTotal(root.right)+root.val;
        }

        // do postorder, find localSum for each subtree and calculate product
        private long FindMax(TreeNode root, long sum){
            if(root == null) return 0;
            long localSum = FindMax(root.left, sum)+FindMax(root.right, sum)+root.val;
            max = Math.Max(max, localSum*(sum-localSum));
            return localSum;
        }
    }

    public static class Program_1339
    {
        public static void Main_1339(string[] args)
        {
            var s = new _1339();

            var tree1 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 3
                    },
                    right = new TreeNode()
                    {
                        val = 4
                    }
                },
                right = new TreeNode()
                {
                    val = 5
                },
            };

            var tree2 = new TreeNode()
            {
                val = 10,
                left = new TreeNode()
                {
                    val = 5,
                    left = new TreeNode()
                    {
                        val = 3,
                        left = new TreeNode()
                        {
                            val = 1
                        }
                    },
                    right = new TreeNode()
                    {
                        val = 7,
                        left = new TreeNode()
                        {
                            val = 6
                        }
                    }
                },
                right = new TreeNode()
                {
                    val = 15,
                    left = new TreeNode()
                    {
                        val = 13
                    },
                    right = new TreeNode()
                    {
                        val = 18
                    }
                },
            };

            s.MaxProduct(tree1);
            //Assert.AreEqual(32, s.RangeSumBST(tree1, 7, 15));
        }
    }
}
