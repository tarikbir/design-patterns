using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExample
{
    class Unit : UnitPrototype
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int Health { get; set; }

        public Unit(string name, string title, int health)
        {
            Name = name;
            Title = title;
            Health = health;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Title: {Title}, HP: {Health}";
        }

        public override UnitPrototype Clone()
        {
            return (Unit) MemberwiseClone(); // Creates a shallow copy.
        }

        public Unit DeepClone()
        {
            Unit deep = (Unit) MemberwiseClone();
            deep.Name = new string(Name);
            deep.Title = new string(Title);
            return deep; //Creates a deep copy.
        }
    }
}
