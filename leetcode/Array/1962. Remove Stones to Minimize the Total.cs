using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    internal class _1962
    {
        public int MinStoneSum(int[] piles, int k) {
            System.Array.Sort(piles, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++)
            {
                piles[0] = piles[0] - piles[0]/2;

                if (i == k-1)
                {
                    continue;
                }

                var j = 0;
                int index = LeftSegmentIndex(piles, j+1, piles.Length - j - 1, piles[j]);
                while (j < piles.Length - 1 && piles[j] < piles[j+1])
                {
                    var temp = piles[j];
                    piles[j] = piles[j+1];
                    piles[j+1] = temp;
                    j++;
                }
            }

            return piles.Sum();
        }

        private static int LeftSegmentIndex(System.Array array, int start, int length, int t)
        {
            int index = System.Array.BinarySearch(array, start, length, t);
            if (index < 0)
            {
                index = ~index - 1;
            }
            return Math.Min(Math.Max(index, 0), array.Length - 2);
        }

        public int MinStoneSum_Try(int[] piles, int k) {
            if (piles.Length == 1)
            {
                for (int i = 0; i < k; i++)
                {
                    piles[0] = piles[0] - (int)Math.Floor(piles[0]/2.0);
                }

                return piles[0];
            }

            System.Array.Sort(piles, (a, b) => b.CompareTo(a));
            var savedPile = 0;
            var lastVisitedPile = 0;

            for (int i = 0, s = 0; s < k; s++)
            {
                if (i == piles.Length)
                {
                    i = 0;
                }

                //if (i != 0 && piles[lastVisitedPile] > piles[i])
                //{
                //    i = lastVisitedPile;
                //}

                if (i == 0 || piles[i] > piles[savedPile])
                {
                    var grabPile = piles[i] - (int)Math.Floor(piles[i]/2.0);
                    savedPile = grabPile > piles[savedPile] ? i : savedPile;
                    piles[i] = grabPile;
                    i++;
                }
                else
                {
                    piles[savedPile] = piles[savedPile] - (int)Math.Floor(piles[savedPile]/2.0);
                    lastVisitedPile = i;
                    i = savedPile + 1;
                }
            }

            return piles.Sum();
        }
    }

    public static class Program_1962
    {
        public static void Main_1962(string[] args)
        {
            var s = new _1962();

            Assert.AreEqual(13867, s.MinStoneSum(new int[] {7481,7973,3635,5320,2721,4394,7861}, 10));
            Assert.AreEqual(8768, s.MinStoneSum(new int[] {7057,6448}, 4));
            Assert.AreEqual(8768, s.MinStoneSum(new int[] {4122,9928,3477,9942}, 6));
            Assert.AreEqual(12, s.MinStoneSum(new int[] {5,4,9}, 2));
            Assert.AreEqual(12, s.MinStoneSum(new int[] {4,3,6,7}, 3));
        }
    }
    
}
