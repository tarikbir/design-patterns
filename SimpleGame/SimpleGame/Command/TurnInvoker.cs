using System.Collections.Generic;
using System.Threading;

namespace SimpleGame.Command
{
    class TurnInvoker
    {
        private List<Command> startOfTurn;
        private List<Command> Turn;
        private List<Command> endOfTurn;

        public TurnInvoker()
        {
            startOfTurn = new List<Command>();
            Turn = new List<Command>();
            endOfTurn = new List<Command>();
        }

        public void AddStartOfTurnCommand(Command cmd)
        {
            startOfTurn.Add(cmd);
        }

        public void AddTurnCommand(Command cmd)
        {
            Turn.Add(cmd);
        }

        public void AddEndOfTurnCommand(Command cmd)
        {
            endOfTurn.Add(cmd);
        }

        public void ExecuteTurn()
        {
            System.Console.WriteLine("[TurnInvoker] Executing start of turn commands.");
            ExecuteStartOfTurnCommands();
            System.Console.WriteLine("[TurnInvoker] Executing turn commands.");
            ExecuteTurnCommands();
            System.Console.WriteLine("[TurnInvoker] Executing end of turn commands.");
            ExecuteEndOfTurnCommands();
        }

        private void ExecuteStartOfTurnCommands()
        {
            foreach (var command in startOfTurn)
            {
                command.Execute();
                Thread.Sleep(300);
            }
        }

        private void ExecuteTurnCommands()
        {
            foreach (var command in Turn)
            {
                command.Execute();
                Thread.Sleep(300);
            }
        }

        private void ExecuteEndOfTurnCommands()
        {
            foreach (var command in endOfTurn)
            {
                command.Execute();
                Thread.Sleep(300);
            }
        }
    }
}
