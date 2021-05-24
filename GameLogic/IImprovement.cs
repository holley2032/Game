using System;
using System.Collections.Generic;

namespace Game.GameLogic
{
    public interface IImprovement
    {
        public static string ValidTileType { get; }
        public static Dictionary<IItem, int> CostOfBuilding { get; }
        public static Object Benefit { get; }
        public static string Name { get; }
    }
}
