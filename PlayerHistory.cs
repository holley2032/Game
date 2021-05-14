using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayerHistory
    {
        public int NumberOfGamesPlayer { get; set; }
        public List<Player> ListOfPlayerInstances { get; set; }
        public List<FinishedGame> ListOfFinishedGameInstances { get; set; }
        public string PlayerName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
