namespace design_patterns.Units
{
    interface Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public void Destroy() { }
    }
}
