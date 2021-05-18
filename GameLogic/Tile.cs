using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Tile
    {
        public Tile(string type)
        {
            Type = type;
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public Boolean Occupied { get; set; }
        public int TileNumber { get; set; }
        public string Improvement { get; set; }
        public override string ToString()
        {
            return $"{Type} {Name}";
        }

    }
}
