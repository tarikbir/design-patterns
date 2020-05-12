using System;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();

            army.AddSoldiers("Infantry", 50000);
            army.AddSoldiers("Sniper", 1000);
            army.AddLandcrafts("Matilda II", 200);
            army.AddAircrafts("Boeing B-29", 2);

            foreach (var unit in army)
            {
                Console.WriteLine(unit);
            }
        }
    }
}
