using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Graph
{
    public static class Program1971
    {
        public static void Main_1971(string[] args)
        {
            var s = new _1971();
            var edges = new int[][] {
                    new int[] {0,1},
                    new int[] {0,2},
                    new int[] {3,5},
                    new int[] {5,4},
                    new int[] {4,3},
                };
            var res = s.ValidPath(3, edges, 0, 5);

            Console.WriteLine("Hello World!");
        }
    }

    internal class _1971
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination) {
            var dest = source;
            var vertex1 = destination;
            var vertex2 = destination;
            var sourceVertex = new Vertex(source);
            var current = sourceVertex;

            for (int i = 0; i < edges.Length; i++)
            {
                if (edges[i][0] == source)
                {
                    dest = edges[i][1];
                    sourceVertex.Dest1 = new Vertex(edges[i][1]);
                }
                else if(edges[i][0] == source)
                {
                    sourceVertex.Dest2 = new Vertex(edges[i][0]);
                }

                if (sourceVertex.Dest1.Val == edges[i][0])
                {
                    sourceVertex.Dest1.Dest1 = new Vertex(edges[i][1]);
                }
                else if(sourceVertex.Dest2.Val == edges[i][1])
                {
                    sourceVertex.Dest2 = new Vertex(edges[i][0]);
                }
            }

            return false;
        }
    }

    public class Vertex
    {
        public int Val { get; set; }
        public Vertex Dest1 { get; set; }
        public Vertex Dest2 { get; set; }

        public Vertex(int val)
        {
            this.Val = val;
        }
    }
}
