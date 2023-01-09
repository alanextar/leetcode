using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.BinaryTree
{
    public static class BFS
    {
        public static int BFS_BasedOnQueue(TreeNode root, TreeNode target)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int step = 0;
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                // iterate the nodes which are already in the queue
                int size = queue.Count();
                for (int i = 0; i < size; ++i)
                {
                    var cur = queue.Peek();
                    Console.WriteLine(cur.val);

                    if (cur == target)
                    {
                        return step;
                    }

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                    
                    queue.Dequeue();
                }

                step = step + 1;
            }

            return -1;
        }

        /**
         * Return the length of the shortest path between root and target node.
         */
        public static int BFS_AssertThatNoCycles(TreeNode root, TreeNode target) {
            Queue<TreeNode> queue = new();  // store all nodes which are waiting to be processed
            HashSet<TreeNode> visited = new();  // store all the nodes that we've visited
            int step = 0;       // number of steps neeeded from root to current node
            // initialize
            queue.Enqueue(root);
            visited.Add(root);
            // BFS
            while (queue.Count != 0) {
                // iterate the nodes which are already in the queue
                int size = queue.Count;
                for (int i = 0; i < size; ++i)
                {
                    var cur = queue.Peek();
                    Console.WriteLine(cur.val);

                    if (cur == target)
                    {
                        return step;
                    }

                    if (cur.left != null && visited.Add(cur.left))
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null && visited.Add(cur.right))
                    {
                        queue.Enqueue(cur.right);
                    }
                    
                    queue.Dequeue();
                }

                step = step + 1;
            }
            return -1;          // there is no path from root to target
        }
    }

    public static class Program_BFS
     {
        public static void Main_BFS(string[] args)
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

            BFS.BFS_BasedOnQueue(tree1, new TreeNode());
        }
     }
}


///**
// * Return the length of the shortest path between root and target node.
// */
//int BFS(Node root, Node target) {
//    Queue<Node> queue;  // store all nodes which are waiting to be processed
//    int step = 0;       // number of steps neeeded from root to current node
//    // initialize
//    add root to queue;
//    // BFS
//    while (queue is not empty) {
//        // iterate the nodes which are already in the queue
//        int size = queue.size();
//        for (int i = 0; i < size; ++i) {
//            Node cur = the first node in queue;
//            return step if cur is target;
//            for (Node next : the neighbors of cur) {
//                add next to queue;
//            }
//            remove the first node from queue;
//        }
//        step = step + 1;
//    }
//    return -1;          // there is no path from root to target
//}