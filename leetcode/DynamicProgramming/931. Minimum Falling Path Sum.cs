using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DynamicProgramming
{
    internal class _931
    {
        public int MinFallingPathSum(int[][] matrix) {
            int n = matrix.Length;
            for (int i = 1; i<n; i++)
            {
                matrix[i][0] += Math.Min(matrix[i - 1][0],matrix[i - 1][1]);
                for (int j = 1; j < n - 1; j++)
                    matrix[i][j] += Math.Min(matrix[i - 1][j - 1],Math.Min(matrix[i - 1][j],matrix[i - 1][j + 1]));
                matrix[i][n - 1] += Math.Min(matrix[i - 1][n - 1], matrix[i - 1][n - 2]);
            }
            return matrix[n - 1].Min();
        }
    }

    public static class Program_931
    {
        public static void Main_931(string[] args)
        {
            var s = new _931();
            s.MinFallingPathSum(new int[][] {
                new int[] {2,1,3},
                new int[] {6,5,4},
                new int[] {7,8,9}
            });
        }
    }
}
