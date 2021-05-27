using System;
using System.Collections.Generic;

namespace Game.GameLogic
{
    public class Tile : ITile
    {
        public Tile(string type, int column, int row)
        {
            Type = type;
            Name = GenerateTileName(column, row);
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public Boolean Occupied { get; set; }
        public int TileNumber { get; set; }
        public IImprovement Improvement { get; set; }
        public List<IImprovement> ValidImprovements { get; set; }
        public List<ITile> AdjacentTo { get; set; }
        public override string ToString()
        {
            return $"{Type} {Name}";
        }

        public string GenerateTileName(int column, int row)
        {
            return $"{Convert.ToChar(column + 65)}{row}";
        }
    }
}
