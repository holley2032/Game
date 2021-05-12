using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we want to make the number of players arbitrary:
            /*bool validPlayers = false;
            while (validPlayers is false)
            {
                validPlayers = int.TryParse(Console.ReadLine(), out int numberOfPlayers);
            }*/

            ProgramManager Manager = new ProgramManager();
            int numberOfPlayers = Manager.InputNumberOfPlayers();
            List<Tile> board = Manager.InitializeBoard(numberOfPlayers);
            List<string> listOfNames = Manager.InputNames(numberOfPlayers);
            List<Player> players = Manager.InitializePlayers(listOfNames);
            GameInstance newGame = Manager.InitializeGame(7, numberOfPlayers, players, board, DateTime.Now);
            //Debug board initialization:

            foreach(Tile tile in board)
            {
                Console.WriteLine(tile.ToString());
            }


        }
    }
}
