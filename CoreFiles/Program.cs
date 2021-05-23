using Game.GameLogic;
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
            IBoard board = Manager.InitializeBoard(numberOfPlayers);
            List<string> listOfNames = Manager.InputNames(numberOfPlayers);
            List<IPlayer> players = Manager.InitializePlayers(listOfNames);
            IGameInstance newGame = Manager.InitializeGame(victoryPointTotal, numberOfPlayers, players, board, DateTime.Now);
            IGameInstance completedGame = Manager.StartGame(newGame);
            //Debug board initialization:

            /*foreach (Tile tile in board)
            {
                Console.WriteLine(tile.ToString());
            }*/


        }
    }
}
