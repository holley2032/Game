using Game.GameLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.HistoricalData
{
    public class PlayerHistory
    {
        public int NumberOfGamesPlayer { get; set; }
        public List<IPlayer> ListOfPlayerInstances { get; set; }
        public List<IGameInstance> ListOfFinishedGameInstances { get; set; }
        public string PlayerName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
