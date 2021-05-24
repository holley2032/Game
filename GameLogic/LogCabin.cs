using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public class LogCabin : IImprovement
    {
        public static string ValidTileType { get => "Forest"; }
        public static Dictionary<IItem, int> CostOfBuilding { get => new Dictionary<IItem, int>{Log, 2}; }
        public static object Benefit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public static string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
