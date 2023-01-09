using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    internal class _1833
    {
        public int MaxIceCream(int[] costs, int coins) {
            var count = 0;
            System.Array.Sort(costs, (a, b) => a.CompareTo(b));

            for (int i = 0; i < costs.Length; i++)
            {
                if (costs[i] > coins)
                {
                    break;
                }

                coins -= costs[i];
                count++;
            }

            return count;
        }
    }

    public static class Program_1833
    {
        public static void Main_1833(string[] args)
        {
            var s = new _1833();

            Assert.AreEqual(4, s.MaxIceCream(new int[] {1,3,2,4,1}, 7));
        }
    }
}
