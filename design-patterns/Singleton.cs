using System;

namespace design_patterns
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>
            (() => new Singleton()); //<1>

        public int number { get; set; } //<2>

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton() //<3>
        { }
    }
}
