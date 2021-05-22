using Game.GameLogic;
using Game.HistoricalData;
using System;
using System.Collections.Generic;

namespace Game.CoreFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramManager Manager = InstanceCreator.CreateProgramManager();
            int numberOfPlayers = Manager.InputNumberOfPlayers();
            int victoryPointTotal = Manager.InputVictoryPointTotal();
            Board board = Manager.InitializeBoard(numberOfPlayers);
            List<string> listOfNames = Manager.InputNames(numberOfPlayers);
            List<Player> players = Manager.InitializePlayers(listOfNames);
            GameInstance newGame = Manager.InitializeGame(victoryPointTotal, numberOfPlayers, players, board, DateTime.Now);
            FinishedGame completedGame = Manager.StartGame(newGame);
            //Debug board initialization:

            /*foreach (Tile tile in board)
            {
                Console.WriteLine(tile.ToString());
            }*/


        }
    }
}
