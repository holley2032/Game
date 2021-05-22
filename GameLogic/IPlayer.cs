using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int PlayerNumber { get; set; }
        public bool IsTurn { get; set; }
        public ITile Location { get; set; }
        public Dictionary<IItem, int> Inventory { get; set; }
    }
}
