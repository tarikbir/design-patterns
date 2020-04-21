namespace BuilderExample
{
    class RimtechBuilder : CombotBuilder
    {
        public RimtechBuilder()
        {
            combot = new Combot("Diego");
        }

        public override void BuildArm()
        {
            combot["rightArm"] = "Laser Sword";
            combot["leftArm"] = "Energy Shield";
        }

        public override void BuildLegs()
        {
            combot["legs"] = "Blast Pulse";
        }

        public override void BuildTorso()
        {
            combot["torso"] = "Armor Torso";
        }
    }
}
