using System;

namespace design_patterns
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>
            (() => new Singleton(0), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication); //<1>

        public static Singleton Instance { get { return lazy.Value; } }

        private int number;

        public int Number
        {
            get { return number; }
            set { lock (Instance) { number = value; } } //<2>
        }

        private Singleton(int number) //<3>
        { this.number = number; }
    }
}
