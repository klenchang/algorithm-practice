using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.Tests
{
    [TestClass()]
    public class LRUCacheTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.AreEqual(1, cache.Get(1));
            cache.Put(3, 3);
            cache.Put(3, 5);
            Assert.AreEqual(-1, cache.Get(2));
            cache.Put(4, 4);
            Assert.AreEqual(-1, cache.Get(1));
            Assert.AreEqual(5, cache.Get(3));
            Assert.AreEqual(4, cache.Get(4));
        }
    }
}