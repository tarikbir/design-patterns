using System;
using System.Collections.Generic;

namespace ObserverExample
{
    class Subject: ISubject
    {
        private readonly object objLock = new object();

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine($"Attached {observer}.");
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
            Console.WriteLine($"Detached {observer}.");
        }

        public void Notify()
        {
            Console.WriteLine("Updating observers...");
            lock(objLock)
            {
                foreach (var observer in observers)
                {
                    observer.Update(this);
                }
            }
        }
    }
}
