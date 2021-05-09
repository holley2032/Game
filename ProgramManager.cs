using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ProgramManager
    {
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
        public List<Player> InitializePlayers(int numberOfPlayers)
        {
            List<Player> players = new List<Player>(numberOfPlayers);
            return players;
        }
        public GameInstance InitializeGame(int victoryPointTotal, int numberOfPlayers, List<Player> players, List<Tile> board)
        {
            var NewGame = new GameInstance(victoryPointTotal, numberOfPlayers, players, board);
            return NewGame;
        }
    }
}
