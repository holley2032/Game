using System.Collections.Generic;

namespace Game.GameLogic
{
    public interface IBoard
    {
        public List<List<ITile>> ListOfTiles { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfTiles { get; set; }

        void DisplayBoard();
    }
}
