using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems
{
    public class LRUCache
    {
        #region topic
        /*
        Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

        Implement the LRUCache class:
            1. LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
            2. int get(int key) Return the value of the key if the key exists, otherwise return -1.
            3. void put(int key, int value) Update the value of the key if the key exists. 
               Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
        
        The functions get and put must each run in O(1) average time complexity.

        Example 1:

        Input
        ["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
        [[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
        Output
        [null, null, null, 1, null, -1, null, -1, 3, 4]

        Explanation
        LRUCache lRUCache = new LRUCache(2);
        lRUCache.put(1, 1); // cache is {1=1}
        lRUCache.put(2, 2); // cache is {1=1, 2=2}
        lRUCache.get(1);    // return 1
        lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
        lRUCache.get(2);    // returns -1 (not found)
        lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
        lRUCache.get(1);    // return -1 (not found)
        lRUCache.get(3);    // return 3
        lRUCache.get(4);    // return 4

        Constraints:
            1 <= capacity <= 3000
            0 <= key <= 104
            0 <= value <= 105
            At most 2 * 105 calls will be made to get and put.
         */
        #endregion
        public class Node
        {
            public Node() { }
            public Node(int key, int value)
            {
                this.key = key;
                this.value = value;
            }
            public int key;
            public int value;
            public Node next;
            public Node prev;
        }
        private readonly int _capacity = 0;
        private readonly Dictionary<int, Node> _dict = new Dictionary<int, Node>();
        private readonly Node _head = new Node();
        private readonly Node _tail = new Node();
        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _head.next = _tail;
            _tail.prev = _head;
        }
        public int Get(int key)
        {
            if (_dict.ContainsKey(key))
            {
                MoveToHead(_dict[key]);
                return _dict[key].value;
            }
            return -1;
        }
        public void Put(int key, int value)
        {
            if (_dict.ContainsKey(key))
            {
                _dict[key].value = value;
                MoveToHead(_dict[key]);
                return;
            }
            else if (_dict.Count == _capacity)
                InsertToHeadAndRemoveLast(new Node(key, value));
            else
                InsertToHead(new Node(key, value));
        }
        private void InsertToHeadAndRemoveLast(Node node)
        {
            // get last one and remove
            var last = _tail.prev;
            _dict.Remove(last.key);
            _tail.prev = last.prev;
            last.prev.next = _tail;

            // add new one to first
            InsertToHead(node);
        }
        public void MoveToHead(Node node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
            node.next = _head.next;
            _head.next.prev = node;
            _head.next = node;
            node.prev = _head;
        }
        private void InsertToHead(Node node)
        {
            _head.next.prev = node;
            node.next = _head.next;
            _head.next = node;
            node.prev = _head;
            _dict.Add(node.key, node);
        }
    }
}
