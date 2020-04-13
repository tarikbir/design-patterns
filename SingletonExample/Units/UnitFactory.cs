namespace design_patterns.Units
{
    class UnitFactory
    {
        public UnitFactory()
        { }

        public Unit Create(string type)
        {
            if (type == null) return null; //<1>

            return type switch
            {
                "Soldier" => new Soldier(),
                "Medic" => new Medic(),
                _ => new Soldier(), //<2>
            };
        }
    }
}
