using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class BoardProperties
    {
        static BoardProperties()
        {
            PlayersToTiles = new Dictionary<int, int>(5)
            {
                { 2, 20 },
                { 3, 25 },
                { 4, 30 },
                { 5, 35 },
                { 6, 45 }
            };
            TileTypeList = new List<string>(10)
            {
                "Forest",
                "Desert",
                "Hills"
            }
        }
        static public Dictionary<int, int> PlayersToTiles { get; }
        static public List<string> TileTypeList { get; }
    }
}
