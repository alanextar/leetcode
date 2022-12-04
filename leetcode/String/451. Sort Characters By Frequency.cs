using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String
{
    public class _451
    {
        public string FrequencySort(string s) {
            var charFrequency = s.GroupBy(c => c, el => 1, (c, col) => new { Key = c, Count = col.Sum()})
                .OrderByDescending(g => (int)g.Count).Select(g => string.Join("", Enumerable.Repeat(g.Key, g.Count)));

            return string.Join("", charFrequency);
        }

        public static void Main451(string[] args)
        {
            var s = new _451();
            Assert.AreEqual("eert", s.FrequencySort("tree"));
            Assert.AreEqual("aaaccc", s.FrequencySort("cccaaa"));
            Assert.AreEqual("bbAa", s.FrequencySort("Aabb"));
        }
    }
}
