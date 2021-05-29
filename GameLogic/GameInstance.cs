using System;
using System.Collections.Generic;
using Game.CoreFiles;
using Game.References;
using static Game.References.UtilityFunctions;

namespace Game.GameLogic
{
    public class GameInstance : IGameInstance
    {
        public GameInstance(int victoryPointTotal, int numberOfPlayers, List<IPlayer> players, IBoard board, DateTime timeStarted)
        {
            VictoryPointTotal = victoryPointTotal;
            NumberOfPlayers = numberOfPlayers;
            Players = players;
            FirstPlayer = Players[0]; //At some point add some logic for this?
            Board = board;
            TimeStarted = timeStarted;
            TurnNumber = 0;
        }

        public int TurnNumber { get; set; }
        public int NumberOfPlayers { get; set; }
        public int VictoryPointTotal { get; set; }
        public bool VictoryConditionMet { get; set; }
        public List<IPlayer> Players { get; set; }
        public IPlayer FirstPlayer { get; set; }
        public IBoard Board { get; set; }
        public DateTime TimeStarted { get; set; }
        public List<ITurn> ListOfTurns { get; set; }
        public void DisplayBoardOnConsole(IBoard board)
        {
            for (int i = 0; i < board.NumberOfRows; i++)
            {
                for (int j = 0; j < board.NumberOfColumns; j++)
                {
                    Console.Write(board.ListOfTiles[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void RunTurn()
        {
            TurnNumber++;
            for (int i = 0; i < Players.Count; i++)
            {
                IPlayer activePlayer = Players[i];
                DisplayBoardOnConsole(Board);
                DisplayActionsOnConsole(activePlayer);
                int decision = InputInteger(1, ActionProperties.ListOfActions.Count);
                string action = ActionProperties.ListOfActions[i - 1];
                Player.Action(action);
            }
        }

        private void DisplayActionsOnConsole(IPlayer activePlayer)
        {
            for (int i = 1; i <= ActionProperties.ListOfActions.Count; i++)
            {
                Console.WriteLine($"{i}: {ActionProperties.ListOfActions[i - 1]}");
            };
        }
    }
}
