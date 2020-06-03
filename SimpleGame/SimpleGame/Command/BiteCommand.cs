using SimpleGame.Decorator;
using SimpleGame.Units;
using System;

namespace SimpleGame.Command
{
    class BiteCommand : Command
    {
        public Unit target;
        public BiteCommand(Unit unit, Unit target) : base(unit)
        {
            this.target = target;
        }
        public override void Execute()
        {
            try
            {
                ((Mutant) unitToExecuteCommandFor).Bite(target);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}
