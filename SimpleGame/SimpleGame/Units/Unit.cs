using SimpleGame.Classes;

namespace SimpleGame.Units
{
    abstract class Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public Position Position { get; set; }
        public int Damage { get; set; }

        protected Unit(string name, int maxHealth, Position position, int damage)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = MaxHealth;
            Position = position;
            Damage = damage;
        }

        public abstract void DealDamage(int damage); //<1>

        public virtual void Move(Position position)
        {
            Position = new Position(position);
            System.Console.WriteLine($"{Name} ({GetType().Name}): Moved to {position}.");
        }

        public virtual void Attack(Unit target)
        {
            target.DealDamage(Damage);
            System.Console.WriteLine($"{Name} ({GetType().Name}): Attacking {target} ({target.GetType().Name}) for {Damage}. ({target.Health}/{target.MaxHealth})");
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public string GetPrintStatus()
        {
            return $"--- {Name} ({GetType().Name}) ---\nHealth: {Health}/{MaxHealth}\nPosition: {Position}\nDamage: {Damage}";
        }
    }
}
