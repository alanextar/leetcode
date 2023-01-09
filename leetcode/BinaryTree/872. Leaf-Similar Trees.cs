using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree.LeafSimilarTrees
{
    internal class _872
    {
        List<int> Leaves1 { get; set; } = new();
        List<int> Leaves2 { get; set; } = new();

        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            TraverseTree(root1, Leaves1);
            TraverseTree(root2, Leaves2);

            return Enumerable.SequenceEqual(Leaves1, Leaves2);
        }

        private void TraverseTree(TreeNode root, List<int> leaves)
        {
            if (root == null)
            {
                return;
            }

            TraverseTree(root.left, leaves);

            if (root.left == null && root.right == null)
            {
                leaves.Add(root.val);
            }
            

            TraverseTree(root.right, leaves);
        }
    }

     public static class Program_872
     {
        public static void Main_872(string[] args)
        {
            var s = new _872();

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
            s.LeafSimilar(tree1, tree2);
        }
     }
}
