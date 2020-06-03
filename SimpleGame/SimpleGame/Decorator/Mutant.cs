using SimpleGame.Units;
using System.Collections.Generic;

namespace SimpleGame.Decorator
{
    class Mutant : UpgradedUnit
    {
        public Mutant(Unit unit) : base(unit)
        {
            Damage += 4;
        }

        public void Bite(Unit target)
        {
            target.DealDamage(Damage);
            System.Console.WriteLine($"{Name} ({GetType().Name}): Biting {target} for {Damage}. ({target.Health}/{target.MaxHealth})");
        }

        public override void DealDamage(int damage)
        {
            Health -= damage*2;
        }
    }
}
