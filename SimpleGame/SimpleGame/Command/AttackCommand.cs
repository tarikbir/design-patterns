using SimpleGame.Units;

namespace SimpleGame.Command
{
    class AttackCommand : Command
    {
        public Unit target;
        public AttackCommand(Unit unit, Unit target) : base(unit)
        {
            this.target = target;
        }
        public override void Execute()
        {
            unitToExecuteCommandFor.Attack(target);
        }
    }
}
