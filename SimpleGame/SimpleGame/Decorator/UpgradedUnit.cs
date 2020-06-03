using SimpleGame.Units;

namespace SimpleGame.Decorator
{
    abstract class UpgradedUnit : Unit
    {
        protected Unit unit;

        public UpgradedUnit(Unit unit) : base(unit.Name, unit.MaxHealth, unit.Position, unit.Damage)
        {
            this.unit = unit;
        }

        public override void DealDamage(int damage)
        {
            unit.DealDamage(damage);
        }
    }
}
