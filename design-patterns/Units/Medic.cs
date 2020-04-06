namespace design_patterns.Units
{
    class Medic : Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Medic()
        {
            Name = "Medic";
            Health = 3;
        }
        public void Destroy()
        {
            //Code
        }

        public void Heal()
        {
            //Code
        }
    }
}
