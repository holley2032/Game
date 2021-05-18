using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player
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
        override public string ToString()
        {
            return $"Player {PlayerNumber}, {Name}";
        }

    }
}
