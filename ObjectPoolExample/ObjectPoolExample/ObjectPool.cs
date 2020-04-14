using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ObjectPoolExample
{
    public class ObjectPool<T>
    {
        private ConcurrentBag<T> Pool;
        private Func<T> ObjectGenerator;
        public int MaxSize = 0;

        public ObjectPool(Func<T> objectGenerator)
        {
            if (objectGenerator == null) throw new ArgumentNullException("Provide an expression to generate an object!");
            Pool = new ConcurrentBag<T>();
            ObjectGenerator = objectGenerator;
        }

        public T GetObject()
        {
            if (Pool.TryTake(out T item)) return item;
            Interlocked.Increment(ref MaxSize);
            return ObjectGenerator();
        }

        public void PutObject(T item)
        {
            Pool.Add(item);
        }
    }
}