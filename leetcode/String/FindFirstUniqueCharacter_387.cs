using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String
{
    public class Solution_387
    {
        public int FirstUniqChar(string s)
        {
            var set = new Hashtable();
            set.Add(1, 1);
            set.Add(1, 2);
            var index = -1;

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (set.ContainsKey(ch))
                {
                    set[ch] = -1;
                }
                else
                {
                    set.Add(ch, i);
                }
                    
            }

            foreach (DictionaryEntry item in set)
            {
                var i = (int)item.Value;
                if (i == -1)
                    continue;

                index = index == -1 ? i : Math.Min(index, i);
            }

            return index;
        }
    }

    public static class Program387
    {
        public static void MainP387(string[] args)
        {
            var sln = new Solution_387();
            var res = sln.FirstUniqChar("abcba");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
