using design_patterns.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Singleton.Instance.Number = 5,
                () => Singleton.Instance.Number = 4
            ); // <1>

            Console.WriteLine($"Singleton instance number is: {Singleton.Instance.Number}"); //<2>

            UnitFactory factory = new UnitFactory();

            List<Unit> units = new List<Unit>();
            units.Add(factory.Create("Soldier"));
            units.Add(factory.Create("Soldier"));
            units.Add(factory.Create("Medic")); //<3>

            Console.WriteLine($"Factory created units: {String.Join(' ', units.Select((u) => u.Name)) }");
        }
    }
}
