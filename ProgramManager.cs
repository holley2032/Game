using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ProgramManager
    {
        public static List<Tile> InitializeBoard(int numberOfPlayers)
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
            }
            Random randomNumber = new Random();
            while (tilesLeft > 0)
            {
                int location = randomNumber.Next(0, 10);
                tiles.Add(BoardProperties.TileTypeList[location]);
            }
            for (int i = 0; i < board.Capacity; i++)
            {

            }
            return board;
        }
        public static List<Player> InitializePlayers(int numberOfPlayers)
        {
            List<Player> players = new List<Player>(numberOfPlayers);
            return players;
        }
        public static GameInstance InitializeGame(int victoryPointTotal, int numberOfPlayers, List<Player> players, List<Tile> board)
        {
            var NewGame = new GameInstance(victoryPointTotal, numberOfPlayers, players, board);
            return NewGame;
        }
    }
}
