using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public interface IImprovement
    {
        public string ValidTileType { get; set; }
        public Dictionary<IItem, int> CostOfBuilding { get; set; }
        public Object Benefit { get; set; }
        public string Name { get; set; }
    }
}
