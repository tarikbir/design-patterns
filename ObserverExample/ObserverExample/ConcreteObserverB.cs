using System;

namespace ObserverExample
{
    class ConcreteObserverB: IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("ConcreteObserverB: Updated.");
        }
    }
}
