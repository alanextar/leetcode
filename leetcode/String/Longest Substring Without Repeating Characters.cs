using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public int LongestSubstringWithoutRepeatingCharacters(string s)
        {
            var chars = new Dictionary<char, int>();
            int l = 0, r = 0;
            int maxCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], i);
                }
                else
                {
                    if (chars[s[i]] >= l)
                    {
                        maxCount = Math.Max(maxCount, i - l);
                        l = chars[s[i]] + 1;
                    }

                    chars[s[i]] = i;
                }
            }

            return Math.Max(maxCount, s.Length - l);
        }
    }
}
