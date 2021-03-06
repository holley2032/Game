using Game.GameLogic;
using Game.References;
using static Game.References.UtilityFunctions;
using System;
using System.Collections.Generic;

namespace Game.CoreFiles
{
    public class ProgramManager
    {
        public int InputNumberOfPlayers()
        {
            Console.WriteLine("How many players will there be in this game?");
            return InputInteger(GameConstants.minNumberOfPlayers, GameConstants.maxNumberOfPlayers);
        }

        public List<string> InputNames(int numberOfPlayers)
        {
            List<string> listOfNames = new List<string>(numberOfPlayers);
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.WriteLine($"Please input the name of Player {i}");
                listOfNames.Add(Console.ReadLine());
                //Would like to add some confirmation message here.
            }
            return listOfNames;
        }
        public int InputVictoryPointTotal()
        {
            Console.WriteLine("How many victory points should we play to?");
            return InputInteger(GameConstants.minNumberOfVictoryPoints, GameConstants.maxNumberOfVictoryPoints);
        }
        public IBoard InitializeBoard(int numberOfPlayers)
        {
            //Create individual rows and add them, instead of adding blank rows from beginning?
            IBoard board = InstanceCreator.CreateBoard(numberOfPlayers);
            List<ITile> listOfTiles = new List<ITile>(capacity: BoardProperties.PlayersToTiles.GetValueOrDefault(numberOfPlayers));
            List<string> tiles = new List<string>(capacity: BoardProperties.PlayersToTiles.GetValueOrDefault(numberOfPlayers));
            int tilesLeft = tiles.Capacity;
            while (tilesLeft > BoardProperties.TileTypeList.Count)
            {
                foreach (string tile in BoardProperties.TileTypeList)
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
            for (int i = 0; i < board.NumberOfRows; i++)
            {
                board.ListOfTiles.Add(new List<ITile>(capacity: board.NumberOfColumns));
                for (int j = 0; j < board.NumberOfColumns; j++)
                {
                    int tileLocation = randomNumber.Next(0, tiles.Count);
                    board.ListOfTiles[i].Add(InstanceCreator.CreateTile(tiles[tileLocation], j, i));
                    tiles.RemoveAt(tileLocation);
                }
            }
            return board;
        }
        public List<IPlayer> InitializePlayers(List<string> listOfNames)
        {
            List<IPlayer> players = new List<IPlayer>(listOfNames.Count);
            for (int i = 1; i <= listOfNames.Count; i++)
            {
                players.Add(InstanceCreator.CreatePlayer(listOfNames[i - 1], i));
            }
            return players;
        }
        public IGameInstance InitializeGame(int victoryPointTotal, int numberOfPlayers, List<IPlayer> players, IBoard board, DateTime timeStarted)
        {
            //Can add validation that this game is valid.
            IGameInstance NewGame = InstanceCreator.CreateGameInstance(victoryPointTotal, numberOfPlayers, players, board, timeStarted);
            return NewGame;
        }
        public IGameInstance StartGame(IGameInstance newGame)
        {
            while (newGame.VictoryConditionMet == false)
            {
                newGame.RunTurn();
            }
            return InstanceCreator.CreateFinishedGame();
        }
    }
}
