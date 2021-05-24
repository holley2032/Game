using System;
using System.Collections.Generic;

namespace Game.GameLogic
{
    public class GameInstance : IGameInstance
    {
        public GameInstance(int victoryPointTotal, int numberOfPlayers, List<IPlayer> players, IBoard board, DateTime timeStarted)
        {
            VictoryPointTotal = victoryPointTotal;
            NumberOfPlayers = numberOfPlayers;
            Players = players;
            Board = board;
            TimeStarted = timeStarted;
        }

        public int TurnNumber { get; set; }
        public int NumberOfPlayers { get; set; }
        public int VictoryPointTotal { get; set; }
        public bool VictoryConditionMet { get; set; }
        public List<IPlayer> Players { get; set; }
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
    }
}
