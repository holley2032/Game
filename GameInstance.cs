using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GameInstance
    {
        public GameInstance(int victoryPointTotal, int numberOfPlayers)
        {
            VictoryPointTotal = victoryPointTotal;
            NumberOfPlayers = numberOfPlayers;
        }

        public int TurnNumber { get; set; }
        public int NumberOfPlayers { get; set; }
        public int VictoryPointTotal { get; set; }
        public Boolean VictoryConditionMet { get; set; }
        public List<Player> Players { get; set; }
        public List<Tile> Board { get; set; }
    }
}
