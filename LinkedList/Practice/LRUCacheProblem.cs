
namespace LinkedList.Practice
{
    internal class LRUCacheProblem
    {
        int capacity;
        Dictionary<int, LinkedListNode<CacheItem>> cacheMap;
        LinkedList<CacheItem> cacheList;
        public LRUCacheProblem(int capacity)
        {
            this.capacity = capacity;
            cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>();
            cacheList = new LinkedList<CacheItem>();

        }

        public int Get(int key)
        {
            if (cacheMap.ContainsKey(key))
            {
                LinkedListNode<CacheItem> node = cacheMap[key];
                cacheList.Remove(node);
                cacheList.AddFirst(node);
                return node.Value.Value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (cacheMap.ContainsKey(key))
            {
                LinkedListNode<CacheItem> node = cacheMap[key];
                cacheList.Remove(node);
                cacheList.AddFirst(node);
            }
            else
            {
                if(cacheMap.Count >= capacity)
                {
                    var lastNode = cacheList.Last;
                    cacheMap.Remove(lastNode.Value.Value);
                    cacheList.RemoveLast();
                }
                var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
                cacheMap[key] = newNode;
                cacheList.AddFirst(newNode);
            }
        }

        private class CacheItem
        {
            public int Key { get; }
            public int Value { get; set; }

            public CacheItem(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}
