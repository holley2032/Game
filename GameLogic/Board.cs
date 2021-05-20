using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    class Board
    {
        public Board(int numberOfPlayers)
        {
            NumberOfTiles = BoardProperties.PlayersToTiles.GetValueOrDefault(numberOfPlayers);
            NumberOfRows = (int)Math.Floor(Math.Sqrt(NumberOfTiles));
            NumberOfColumns = (int)Math.Ceiling(Math.Sqrt(NumberOfTiles));
            List<List<Tile>> ListOfTiles = new List<List<Tile>>(capacity: NumberOfRows);
        }
        public List<List<Tile>> ListOfTiles { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfTiles { get; set; }
    }
}
