using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public interface IBoard
    {
        public List<List<ITile>> ListOfTiles { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfTiles { get; set; }
    }
}
