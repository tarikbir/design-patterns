using SimpleGame.Classes;

namespace SimpleGame.Units
{
    class Archer : Unit
    {
        public Archer(string name, Position position) 
            : base(name, 30, position, 12){ }

        public override void DealDamage(int damage)
        {
            Health -= damage;
        }
    }
}
