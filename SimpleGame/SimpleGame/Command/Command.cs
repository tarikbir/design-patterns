using SimpleGame.Units;

namespace SimpleGame.Command
{
    abstract class Command
    {
        protected Unit unitToExecuteCommandFor;

        public Command(Unit unit)
        {
            unitToExecuteCommandFor = unit;
        }

        public abstract void Execute();
    }
}
