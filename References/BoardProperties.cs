using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class BoardProperties
    {
        private static readonly Dictionary<int, int> _PlayersToTiles = new Dictionary<int, int>(5)
            {
                { 2, 20 },
                { 3, 25 },
                { 4, 30 },
                { 5, 36 },
                { 6, 49 }
            };
        private static readonly List<string> _TileTypeList = new List<string>(10)
            {
                "Forest",
                "Desert",
                "Hills",
                "Canyon",
                "Ocean",
                "Lake",
                "Plains",
                "Grassland",
                "Mountains",
                "Floodplains"
            };
        static public Dictionary<int, int> PlayersToTiles { 
            get => _PlayersToTiles;
        }
        static public List<string> TileTypeList { 
            get => _TileTypeList;
        }
    }
}
