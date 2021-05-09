using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramManager Manager = new ProgramManager();
            List<Tile> board = Manager.InitializeBoard(2);
            //Console.WriteLine($"You have created a new game with a victory point total of {NewGame.VictoryPointTotal} and {NewGame.NumberOfPlayers} players");
            foreach(Tile tile in board)
            {
                Console.WriteLine(tile.ToString());
            }
        }
    }
}
