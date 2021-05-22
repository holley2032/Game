using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public class Player
    {
        public Player(string name, int playerNumber)
        {
            Name = name;
            Points = 0;
            PlayerNumber = playerNumber;
            if (playerNumber == 1)
            {
                IsTurn = true;
            }
            else
            {
                IsTurn = false;
            }
        }
        public string Name { get; set; }
        public int Points { get; set; }
        public int PlayerNumber { get; set; }
        public bool IsTurn { get; set; }

        private Tile _Location;
        public Tile Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public Dictionary<IItem, int> Inventory { get; set; }
        override public string ToString()
        {
            return $"Player {PlayerNumber}, {Name}";
        }

    }
}
