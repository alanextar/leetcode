using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Design
{
    public class MyHashSet {
        private int _divider = 1000;

        private List<int>[] Buckets { get; set; }

        public MyHashSet() {
            Buckets = new List<int>[_divider];
        }
    
        public void Add(int key) {
            if (Buckets[key % _divider] == null || Buckets[key % _divider].Count == 0)
            {
                var l = new List<int>() { key };
                Buckets[key % _divider] = l;

                return;
            }

            if (Buckets[key % _divider].Contains(key))
            {
                return;
            }

            Buckets[key % _divider].Add(key);
        }
    
        public void Remove(int key) {
            Buckets[key % _divider]?.Remove(key);
        }
    
        public bool Contains(int key) {
            return Buckets[key % _divider] != null && Buckets[key % _divider].Contains(key);
        }
    }

    public static class Program_705
    {
        public static void Main(string[] args)
        {
            var s = new MyHashSet();
            s.Add(1);
            s.Add(1);
            s.Add(1001);
            s.Contains(3);
            s.Remove(3);
            Assert.AreEqual(true ,s.Contains(1));
            Assert.AreEqual(false ,s.Contains(3));
        }
    }
}
