using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    interface IImprovement
    {
        public string ValidTileType { get; set; }
        public Dictionary<IItem, int> CostOfBuilding { get; set; }
        public Object Benefit { get; set; }
    }
}
