using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.String
{
    internal class Determine_if_Two_Strings_Are_Close
    {
        public bool CloseStrings(string word1, string word2) {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            word1 = string.Join("", word1.OrderByDescending(ch => (int)ch));
            word2 = string.Join("", word2.OrderByDescending(ch => (int)ch));

            var charCountGr1 = word1.GroupBy(c => c, el => 1, (c, col) => new { Key = c, Count = col.Sum()}).OrderBy(g => (int)g.Key);
            var charCountGr2 = word2.GroupBy(c => c, el => 1, (c, col) => new { Key = c, Count = col.Sum()}).OrderBy(g => (int)g.Key);

            return charCountGr1.Select(g => g.Key).SequenceEqual(charCountGr2.Select(g => g.Key)) && 
                charCountGr1.Select(g => g.Count).OrderBy(v => v).SequenceEqual(charCountGr2.Select(g => g.Count).OrderBy(v => v));
        }

        public static void Maind(string[] args)
        {
            var s = new Determine_if_Two_Strings_Are_Close();
            Assert.AreEqual(true, s.CloseStrings("cabbba", "abbccc"));
            Assert.AreEqual(false, s.CloseStrings("a", "aa"));
            Assert.AreEqual(true, s.CloseStrings("abc", "bca"));
            Assert.AreEqual(false, s.CloseStrings("abbzzca", "babzzcz"));
        }
    }
}
