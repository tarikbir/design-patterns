using System;

namespace ObserverExample
{
    class ConcreteObserverA: IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("ConcreteObserverA: Updated.");
        }
    }
}
