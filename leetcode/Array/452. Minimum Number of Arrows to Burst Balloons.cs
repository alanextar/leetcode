using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    public static class Program_452
    {
        public static void Main_452(string[] args)
        {
            var s = new _452();

            Assert.AreEqual(2, s.FindMinArrowShots(new int[][] {
                    new int[] {3,9}, 
                    new int[] {7,12}, 
                    new int[] {3,8}, 
                    new int[] {6,8},
                    new int[] {9,10},
                    new int[] {2,9},
                    new int[] {0,9},
                    new int[] {3,9},
                    new int[] {0,6},
                    new int[] {2,8},
                }
            ));
            Assert.AreEqual(4, s.FindMinArrowShots(new int[][] {new int[] {1, 2}, new int[] {3,4}, new int[] {5,6}, new int[] {7,8}}));
        }
    }

    internal class _452
    {
        public int FindMinArrowShots(int[][] points) {
            System.Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));
            var intersection = points[0];
            var res = 1;

            //start1 <= end2 && start2 <= end1
            for (int i = 1; i < points.Length; i++)
            {
                if (intersection[0] <= points[i][1] && points[i][0] <= intersection[1])
                {
                    intersection[0] = Math.Max(points[i][0], intersection[0]);
                    intersection[1] = Math.Min(points[i][1], intersection[1]);
                }
                else
                {
                    res++;
                    intersection = points[i];
                }
            }

            return res;
        }
    }
}
