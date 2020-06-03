using SimpleGame.Classes;

namespace SimpleGame.Units
{
    class Swordsman : Unit
    {
        private int armor = 4;

        public Swordsman(string name, Position position)
            : base(name, 50, position, 10) { }

        public override void DealDamage(int damage)
        {
            Health -= (damage - (int)(armor*0.8f)); //<1>
        }
    }
}
