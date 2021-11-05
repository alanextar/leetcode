using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
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

		public TreeNode(int?[] arr)
		{
            var t = new TreeNode();
            t = t.InsertLevelOrder(arr, t, 0);
            this.val = t.val;
            this.left = t.left;
            this.right = t.right;

        }

        // Function to insert nodes in level order
        public TreeNode InsertLevelOrder(int?[] arr,
                                TreeNode root, int i)
        {
            // Base case for recursion
            if (i < arr.Length)
            {
                if (arr[i].HasValue)
				{
                    TreeNode temp = new TreeNode(arr[i].Value);
                    root = temp;

                    // insert left child
                    root.left = InsertLevelOrder(arr,
                                    root.left, 2 * i + 1);

                    // insert right child
                    root.right = InsertLevelOrder(arr,
                                    root.right, 2 * i + 2);
                }

            }
            return root;
        }
    }
}
