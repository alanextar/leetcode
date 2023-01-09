using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DynamicProgramming
{
    internal class _70
    {
        public static List<IList<int>> result = new List<IList<int>>();
        public static int[] origin;

        public int ClimbStairs(int n)
        {
            int doubleStepsCount = n / 2;
            string originComb = new string(Enumerable.Repeat('2', n / 2).ToArray());
            if (n % 2 == 1)
            {
                originComb += '1';
            }

            var index = 0;
            int result = 1;
            while (index != doubleStepsCount)
            {
                var newComb = Enumerable.Repeat(2, n / 2 - 1).ToList();
                newComb.Add(1);
                newComb.Add(1);
                Permutation();

                index++;
            }

            return result;
        }

        private int Permutation()
        {
            int result = 0;

            return result;
        }
    }

    public static class Program_70
    {
        public static void Main_70(string[] args)
        {
            var s = new _70();
            s.ClimbStairs(3);
        }
    }
}
