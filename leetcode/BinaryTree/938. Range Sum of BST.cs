using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree.RangeOfSum
{
     public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
             this.val = val;
             this.left = left;
             this.right = right;
         }
     }

    internal class _938
    {
        private int sumNodesInInclusiveRange = 0;

        public int RangeSumBST(TreeNode root, int low, int high) {
            if (root == null)
            {
                return sumNodesInInclusiveRange;
            }

            RangeSumBST(root.left, low, high);

            if (Math.Clamp(root.val, low, high) == root.val)
            {
                sumNodesInInclusiveRange += root.val;
            }

            RangeSumBST(root.right, low, high);

            return sumNodesInInclusiveRange;
        }
    }

    public static class Program_938
    {
        public static void Main_938(string[] args)
        {
            var s = new _938();

            var tree1 = new TreeNode()
            {
                val = 10,
                left = new TreeNode()
                {
                    val = 5,
                    left = new TreeNode()
                    {
                        val = 3
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                },
                right = new TreeNode()
                {
                    val = 15,
                    right = new TreeNode()
                    {
                        val = 18
                    }
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

            //Assert.AreEqual(32, s.RangeSumBST(tree1, 7, 15));
            Assert.AreEqual(23, s.RangeSumBST(tree2, 6, 10));
        }
    }
}
