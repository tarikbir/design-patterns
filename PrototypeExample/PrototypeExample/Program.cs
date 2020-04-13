using System;
using System.Collections.Generic;

namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Unit("Irvine", "The Soldier", 10));
            units.Add(new Unit("Yuna", "The Healer", 8));
            units.Add(new Unit("Tidus", "The Fighter", 9));
            units.Add(new Unit("Squall", "The Swordsman", 12));
            units.Add(new Unit("Cloud", "The Swordsman", 11));

            Unit unit1 = (Unit) units[3].Clone(); // Shallow copies unit 3.
            Unit unit2 = (Unit) units[3].DeepClone(); // Deep copies unit 3.

            units[3].Name = "Rinoa";
            // Since C# strings behave like value type but are reference type,
            // MemberwiseClone() shallow copies also copy strings so this example does not work.
            // Any other reference type variable should work when cloning objects.

            Console.WriteLine(unit1);
            Console.WriteLine(unit2);
        }
    }
}
