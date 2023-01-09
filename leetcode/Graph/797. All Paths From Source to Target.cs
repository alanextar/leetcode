using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Graph
{
    public static class Program_797
    {
        public static void Main_797(string[] args)
        {
            var s = new _797();
            var graph = new int[][] {
                    new int[] {1,2},
                    new int[] {3},
                    new int[] {3},
                    new int[] {},
                };
            var res = s.AllPathsSourceTarget(graph);

            Console.WriteLine("Hello World!");
        }
    }

    internal class _797
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph) 
        {
            IList<IList<int>> ans = new List<IList<int>>();
            int n = graph.Length;
            Backtrack(graph,0,new List<int>{0},ans);
            return ans;
        }
    
        private void Backtrack(int[][] graph, int node, IList<int> li, IList<IList<int>> ans)
        {
            if(node==graph.Length-1)
            {
                ans.Add(new List<int>(li));
                return;
            }
        
            for(int j=0; j<graph[node].Length; j++)
            {
                li.Add(graph[node][j]);
                Backtrack(graph,graph[node][j],li,ans);
                li.RemoveAt(li.Count-1);
            }
        
        }

        public IList<IList<int>> AllPathsSourceTarget2(int[][] graph) {
            var res = new List<IList<int>>();

            Queue<int> queue = new Queue<int>();
            int step = 0;
            queue.Enqueue(0);
            var target = graph.Length - 1;

            while (queue.Count != 0)
            {
                // iterate the nodes which are already in the queue
                int size = queue.Count();
                for (int i = 0; i < size; ++i)
                {
                    var cur = queue.Peek();

                    //if (cur == target)
                    //{
                    //    return res;
                    //}

                    for (int j = 0; j < graph[cur].Length; j++)
                    {
                        if (graph[cur].Count() != 0)
                        {
                            Console.WriteLine(graph[cur][j]);
                            queue.Enqueue(graph[cur][j]);
                        }
                    }
                    
                    queue.Dequeue();
                }

                step = step + 1;
            }

            return res;
        }

        public IList<IList<int>> AllPathsSourceTarget1(int[][] graph) {
            var res = new List<IList<int>>();

            for (int i = 0; i < graph[0].Length; i++)
            {
                res.Add(new List<int>() { 0 });
            }

            for (int i = 0; i < res.Count; i++)
            {
                var list = res.FirstOrDefault(r => r.Any(l => l == i));
                for (int j = 0; j < res[i].Count; j++)
                {
                    res[i].Add(res[i][j]);
                }
            }

            return res;
        }
    }
}
