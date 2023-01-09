using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    internal class _1026
    {
        private int Diff { get; set; } = 0;

        public int MaxAncestorDiff(TreeNode root) {
            var max = int.MinValue;
            var min = int.MaxValue;
            TraverseTree(root, max, min);

            return Diff;
        }

        private void TraverseTree(TreeNode root, int maxVal, int minVal)
        {
            if (root == null)
            {
                return;
            }

            var curMax = Math.Max(maxVal, root.val);
            var curMin = Math.Min(minVal, root.val);
            Diff = Math.Max(Diff, curMax - curMin);
            TraverseTree(root.left, curMax, curMin);

            TraverseTree(root.right, curMax, curMin);
        }
    }

    public static class Program_1026
     {
        public static void Main_1026(string[] args)
        {
            var s = new _1026();

            var tree1 = new TreeNode()
            {
                val = 8,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode()
                    {
                        val = 1
                    },
                    right = new TreeNode()
                    {
                        val = 6,
                        left = new TreeNode()
                        {
                            val = 4
                        },
                        right = new TreeNode()
                        {
                            val = 7,

                        }

                    }
                },
                right = new TreeNode()
                {
                    val = 10,
                    right = new TreeNode()
                    {
                        val = 14,
                        right = new TreeNode()
                        {
                            val = 13
                        }
                    }
                },
            };

            var tree2 = new TreeNode()
            {
                val = 0,
                right = new TreeNode()
                {
                    val = 1,
                },
            };

            var tree3 = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                },
                right = new TreeNode()
                {
                    val = 4,
                },
            };

            var res = s.MaxAncestorDiff(tree2);
            Assert.AreEqual(1, res);
        }
     }
}
