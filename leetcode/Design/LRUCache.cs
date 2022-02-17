using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Design
{
    public class LRUCacheProgram
    {
        public static void LRUMain()
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(2, 1); // cache is {1=1}
            lRUCache.Put(1, 1); // cache is {1=1, 2=2}
            lRUCache.Get(2);    // return 1
            lRUCache.Put(4, 1); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            lRUCache.Get(1);    // returns -1 (not found)
            lRUCache.Get(2);
        }
    }

    public class CachedNode
    {
        public CachedNode(int key, int value)
        {
            this.key = key;
            this.value = value;
        }

        public int key;
        public int value;
    }

    public class LRUCache
    {
        private Dictionary<int, LinkedListNode<CachedNode>> _map;
        private LinkedList<CachedNode> _cache;

        private readonly int _capacity;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _map = new Dictionary<int, LinkedListNode<CachedNode>>();
            _cache = new LinkedList<CachedNode>();
        }

        public int Get(int key)
        {
            var isExist = _map.TryGetValue(key, out var node);
            if (!isExist)
                return -1;

            _cache.Remove(node);
            _cache.AddFirst(node);

            return node.Value.value;
        }

        public void Put(int key, int value)
        {
            if (_map.TryGetValue(key, out var node))
            {
                _cache.Remove(node);
                _cache.AddFirst(node);
                node.Value.value = value;
            }
            else
            {
                if (_cache.Count == _capacity)
                {
                    var l = _cache.Last;
                    _cache.Remove(l);
                    _map.Remove(l.Value.key);
                }
                
                node = new LinkedListNode<CachedNode>(new CachedNode(key, value));
                _cache.AddFirst(node);

                _map.Add(key, _cache.First);
            }
        }
    }
}
