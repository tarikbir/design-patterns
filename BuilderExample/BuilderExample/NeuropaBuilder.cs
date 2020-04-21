namespace BuilderExample
{
    class NeuropaBuilder : CombotBuilder
    {
        public NeuropaBuilder()
        {
            combot = new Combot("Jonus");
        }

        public override void BuildArm()
        {
            combot["rightArm"] = "Electro Grip";
            combot["leftArm"] = "K-Shield";
        }

        public override void BuildLegs()
        {
            combot["legs"] = "Speed Legs";
        }

        public override void BuildTorso()
        {
            combot["torso"] = "Camo";
        }
    }
}
