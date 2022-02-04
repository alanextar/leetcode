using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    public class BinaryTreeOutput
    {
        public static void FMain(string[] args)
        {
            var pi = Math.Acos(-1);
            var pi1 = PI();

            var arr1 = new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 };
            var tree = new TreeNode(arr1);
            var print = new BinaryTreeOutput();
            print.Print(tree, 0);
        }

        static double PI()
        {
            // Returns PI
            return 2 * F(1);
        }

        public static double F(int i)
        {
            if (i > 1)
            {
                return i;
            }

            var pi = 1 + i / (2.0 * i + 1) * F(i + 1);
            return pi;
        }

        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public BinaryTreeOutput()
        {
            
        }

        void Print(TreeNode node, int level = 0, bool isLeft = false)
        {
            if (node == null) return; // Empty subtree - do nothing
            var printStr = "";

            if (level == 0)
            {
                printStr += "@: ";
            }
            else if (isLeft)
            {
                printStr += "L: ";
            }
            else
            {
                printStr += "R: ";
            }

            Console.WriteLine(string.Empty.PadLeft(4*level) + printStr + node.val);       // Process root node
            level++;
            Print(node.left, level, isLeft: true);    // Process all nodes in left
            Print(node.right, level);   // Process all nodes in right
        }
    }
}
