using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public interface ITile
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Boolean Occupied { get; set; }
        public int TileNumber { get; set; }
        public IImprovement Improvement { get; set; }
        public List<IImprovement> ValidImprovements { get; set; }
        public List<ITile> AdjacentTo { get; set; }
    }
}
