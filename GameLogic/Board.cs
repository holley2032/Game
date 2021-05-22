using Game.References;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public class Board : IBoard
    {
        public Board(int numberOfPlayers)
        {
            NumberOfTiles = BoardProperties.PlayersToTiles.GetValueOrDefault(numberOfPlayers);
            NumberOfRows = (int)Math.Floor(Math.Sqrt(NumberOfTiles));
            NumberOfColumns = (int)Math.Ceiling(Math.Sqrt(NumberOfTiles));
            ListOfTiles = new List<List<ITile>>(capacity: NumberOfRows);
        }
        public List<List<ITile>> ListOfTiles { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfTiles { get; set; }
    }
}
