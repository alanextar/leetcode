using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    internal class _144
    {
        private List<int> Result { get; set; } = new List<int>(101);

        public IList<int> PreorderTraversal(TreeNode root) {
            if (root == null)
            {
                return Result;
            }
            
            Result.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
            
            return Result;
        }

        public List<int> PreorderMorrisTraversal(TreeNode root) {
            List<int> answer = new List<int>();
            TreeNode curr = root, last;
        
            while (curr != null) {
                // If there is no left child, go for the right child.
                // Otherwise, find the last node in the left subtree. 
                if(curr.left == null) {
                    answer.Add(curr.val);
                    curr = curr.right;
                } else {
                    last = curr.left;
                    while (last.right != null && last.right != curr) {
                        last = last.right;
                    }

                    // If the last node is not modified, we let 
                    // 'curr' be its right child. Otherwise, it means we 
                    // have finished visiting the entire left subtree.
                    if (last.right == null) {
                        answer.Add(curr.val);
                        last.right = curr;
                        curr = curr.left;
                    } else {
                        last.right = null;
                        curr = curr.right;
                    }
                }
            }
        
            return answer;
        }
    }

    public static class Program_144
    {
        public static void Main_144(string[] args)
        {
            var s = new _144();

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
            
            CollectionAssert.AreEqual(new List<int>() {1,2,3,4,5}, s.PreorderMorrisTraversal(tree1));
            CollectionAssert.AreEqual(new List<int>() {1,2,3,4,5}, s.PreorderTraversal(tree1));
        }
    }
}
