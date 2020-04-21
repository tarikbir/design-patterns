namespace BuilderExample
{
    class MilagroBuilder : CombotBuilder
    {
        public MilagroBuilder()
        {
            combot = new Combot("Stefan");
        }

        public override void BuildArm()
        {
            combot["rightArm"] = "Hammer Hand";
            combot["leftArm"] = "Gatling Gun";
        }

        public override void BuildLegs()
        {
            combot["legs"] = "Strength";
        }

        public override void BuildTorso()
        {
            combot["torso"] = "Howitzer";
        }
    }
}
