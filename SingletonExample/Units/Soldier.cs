namespace design_patterns.Units
{
    class Soldier : Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Soldier()
        {
            Name = "Soldier";
            Health = 6;
        }
        public void Destroy()
        {
            //Code
        }

        public void Shoot()
        {
            //Code
        }
    }
}
