using SimpleGame.Classes;
using SimpleGame.Units;

namespace SimpleGame.Command
{
    class MoveCommand : Command
    {
        public Position pos;
        public MoveCommand(Unit unit, Position pos) : base(unit)
        {
            this.pos = pos;
        }
        public override void Execute()
        {
            unitToExecuteCommandFor.Move(pos);
        }
    }
}
