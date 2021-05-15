using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ProgramManager
    {
        public int InputNumberOfPlayers()
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
            return numberOfPlayers;
        }

        public List<string> InputNames(int numberOfPlayers)
        {
            List<string> listOfNames = new List<string>(numberOfPlayers);
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.WriteLine($"Please input the name of Player {numberOfPlayers}");
                listOfNames.Add(Console.ReadLine());
                //Would like to add some confirmation message here.
            }
            return listOfNames;
        }
        //Could combine this method and InputNumberOfPlayers into a more generic InputInteger method.
        public int InputVictoryPointTotal()
        {
            bool validInt = false;
            int victoryPointTotal = 0;
            while (validInt is false)
            {
                try
                {
                    victoryPointTotal = int.Parse(Console.ReadLine());
                    if (victoryPointTotal >= 1 && victoryPointTotal <= 50)
                    {
                        validInt = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 and 50, inclusive.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 and 50, inclusive.");
                }
            }
            return victoryPointTotal;
        }
        public List<Tile> InitializeBoard(int numberOfPlayers)
        {
            List<Tile> board = new List<Tile>(capacity: BoardProperties.PlayersToTiles.GetValueOrDefault(numberOfPlayers));
            List<string> tiles = new List<string>(capacity: board.Capacity);
            int tilesLeft = tiles.Capacity;
            while (tilesLeft > BoardProperties.TileTypeList.Count)
            {
                foreach(string tile in BoardProperties.TileTypeList)
                {
                    tiles.Add(tile);
                }
                tilesLeft -= 10;
            }
            Random randomNumber = new Random();
            while (tilesLeft > 0)
            {
                int location = randomNumber.Next(0, 10);
                tiles.Add(BoardProperties.TileTypeList[location]);
                tilesLeft--;
            }
            for (int i = 0; i < board.Capacity; i++)
            {
                int tileLocation = randomNumber.Next(0, tiles.Count);
                board.Add(new Tile(tiles[tileLocation]));
                tiles.RemoveAt(tileLocation);
            }
            return board;
        }
        public List<Player> InitializePlayers(List<string> listOfNames)
        {
            List<Player> players = new List<Player>(listOfNames.Count);
            for (int i = 1; i <= listOfNames.Count; i++)
            {
                players.Add(new Player(listOfNames[i], i));
            }
            return players;
        }
        public GameInstance InitializeGame(int victoryPointTotal, int numberOfPlayers, List<Player> players, List<Tile> board, DateTime timeStarted)
        {
            //Can add validation that this game is valid.
            GameInstance NewGame = new GameInstance(victoryPointTotal, numberOfPlayers, players, board, timeStarted);
            return NewGame;
        }
        public FinishedGame StartGame(GameInstance newGame)
        {
            return new FinishedGame();
        }
    }
}
