using System;
using System.Threading.Tasks;

namespace ObjectPoolExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<Unit> pool = new ObjectPool<Unit>(() => new Unit());

            Parallel.For(0, 1000, (i, loopState) =>
            {
                Unit unit = pool.GetObject();
                Console.CursorLeft = 0;
                Console.WriteLine(unit.Name);

                pool.PutObject(unit);
            });

            Console.WriteLine($"Maximum pool size: {pool.MaxSize}");

            Console.ReadKey();
        }
    }
}
