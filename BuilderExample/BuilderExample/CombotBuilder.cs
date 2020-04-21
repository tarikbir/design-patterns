namespace BuilderExample
{
    abstract class CombotBuilder
    {
        protected Combot combot;
        public Combot Combot { get { return combot; } }

        public abstract void BuildTorso();
        public abstract void BuildLegs();
        public abstract void BuildArm();
    }
}
