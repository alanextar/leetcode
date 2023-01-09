using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String
{
    internal class _944
    {
        public int MinDeletionSize(string[] strs) {
            char prev = default(char);
            var res = 0;

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (j > 0 && prev > strs[j][i])
                    {
                        res++;
                        break;
                    }

                    prev = strs[j][i];
                }
            }

            return res;
        }
    }

    public static class Program_944
    {
        public static void Main_944(string[] args)
        {
            var s = new _944();
            Assert.AreEqual(2, s.MinDeletionSize(new string[] {"rrjk","furt","guzm"}));
            Assert.AreEqual(1, s.MinDeletionSize(new string[] {"cba","daf","ghi"}));
            Assert.AreEqual(3, s.MinDeletionSize(new string[] {"zyx","wvu","tsr"}));
        }
    }
}
