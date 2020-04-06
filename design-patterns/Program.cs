using design_patterns.Units;
using System;
using System.Collections.Generic;
using System.Linq;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.Instance; //<1>

            instance.number = 3; //<2>

            Console.WriteLine($"Singleton instance number is: {instance.number}");

            UnitFactory factory = new UnitFactory();

            List<Unit> units = new List<Unit>();
            units.Add(factory.Create("Soldier"));
            units.Add(factory.Create("Soldier"));
            units.Add(factory.Create("Medic")); //<3>

            Console.WriteLine($"Factory created units: {String.Join(' ', units.Select((u) => u.Name)) }");
        }
    }
}
