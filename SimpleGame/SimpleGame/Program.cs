using SimpleGame.Classes;
using SimpleGame.Command;
using SimpleGame.Decorator;
using SimpleGame.Units;
using System;
using System.Collections.Generic;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> AllUnits = new List<Unit>();
            List<Unit> Player1_Units = new List<Unit>();
            List<Unit> Player2_Units = new List<Unit>();

            /* Mocked Game Logic */
            Player1_Units.Add(new Archer(RandomNamer.GetName(), new Position(10, 20))); //<1>
            Player1_Units.Add(new Archer(RandomNamer.GetName(), new Position(12, 26)));
            Player1_Units.Add(new Swordsman(RandomNamer.GetName(), new Position(11, 23)));
            Player2_Units.Add(new Archer(RandomNamer.GetName(), new Position(25, 43)));
            Player2_Units.Add(new Archer(RandomNamer.GetName(), new Position(26, 40)));
            Player2_Units.Add(new Swordsman(RandomNamer.GetName(), new Position(26, 41)));
            Player2_Units.Add(new Mutant(new Swordsman(RandomNamer.GetName(), new Position(28, 43)))); //<2>

            AllUnits.AddRange(Player1_Units);
            AllUnits.AddRange(Player2_Units);

            foreach (var item in AllUnits)
            {
                Console.WriteLine(item.GetPrintStatus());
            }

            //Take 1 turn
            TurnInvoker turn = new TurnInvoker();
            turn.AddStartOfTurnCommand(new AttackCommand(Player1_Units[2], Player2_Units[3]));
            turn.AddTurnCommand(new AttackCommand(Player1_Units[2], Player2_Units[0])); //<1>
            turn.AddTurnCommand(new AttackCommand(Player1_Units[0], Player2_Units[0]));
            turn.AddTurnCommand(new AttackCommand(Player1_Units[1], Player2_Units[2]));
            turn.AddTurnCommand(new BiteCommand(Player2_Units[3], Player1_Units[2]));
            turn.AddTurnCommand(new AttackCommand(Player2_Units[1], Player1_Units[2]));
            turn.AddEndOfTurnCommand(new MoveCommand(Player1_Units[0], new Position(8,12))); //<2>
            turn.ExecuteTurn();

            foreach (var item in AllUnits)
            {
                Console.WriteLine(item.GetPrintStatus());
            }
        }
    }
}
