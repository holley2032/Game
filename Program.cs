using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players will there be in this game?");
            bool validPlayers = false;
            int numberOfPlayers = 0;
            while (validPlayers is false)
            {
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());
                    if (numberOfPlayers >= 2 && numberOfPlayers <= 6)
                    {
                        validPlayers = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 2 and 6, inclusive.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 2 and 6, inclusive.");
                }
            }
            //If we want to make the number of players arbitrary:
            /*bool validPlayers = false;
            while (validPlayers is false)
            {
                validPlayers = int.TryParse(Console.ReadLine(), out int numberOfPlayers);
            }*/

            ProgramManager Manager = new ProgramManager();
            List<Tile> board = Manager.InitializeBoard(numberOfPlayers);
            
            //Debug board initialization:

            foreach(Tile tile in board)
            {
                Console.WriteLine(tile.ToString());
            }


        }
    }
}
