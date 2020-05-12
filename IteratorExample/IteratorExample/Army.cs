using System.Collections;
using System.Collections.Generic;

namespace IteratorExample
{
    public class Army: IEnumerable
    {
        private List<Unit> army = new List<Unit>();

        public Army()
        {
            army.Add(new Unit { Name = "Commander", Amount = 1, Type = Unit.TypeEnum.Soldier });
        }

        public void AddSoldiers(string name, int amount)
        {
            army.Add(new Unit { Name = name, Amount = amount, Type = Unit.TypeEnum.Soldier });
        }

        public void AddLandcrafts(string name, int amount)
        {
            army.Add(new Unit { Name = name, Amount = amount, Type = Unit.TypeEnum.Landcraft });
        }

        public void AddAircrafts(string name, int amount)
        {
            army.Add(new Unit { Name = name, Amount = amount, Type = Unit.TypeEnum.Aircraft });
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Unit unit in army)
            {
                yield return $"{unit.Amount} {unit.Name} ({unit.Type})"; // yield return thread-safe'tir.
            }
        }

        private class Unit
        {
            public enum TypeEnum { Soldier, Landcraft, Aircraft }

            public string Name { get; set; }
            public int Amount { get; set; }
            public TypeEnum Type { get; set; }
        }
    }
}
