using System;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var lazyObserverA = new Lazy<ConcreteObserverA>();
            var lazyObserverB = new Lazy<ConcreteObserverB>();

            subject.Attach(lazyObserverA.Value);
            subject.Attach(lazyObserverB.Value);

            subject.Notify();

            subject.Detach(lazyObserverB.Value);

            subject.Notify();
        }
    }
}
