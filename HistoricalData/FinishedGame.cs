using Game.GameLogic;
using System;
using System.Collections.Generic;

namespace Game.HistoricalData
{
    public class FinishedGame : IGameInstance
    {
        public FinishedGame()
        {

        }
        public int NumberOfPlayers { get; set; }
        public int VictoryPointTotal { get; set; }
        public bool VictoryConditionMet { get; set; }
        public List<IPlayer> Players { get; set; }
        public IBoard Board { get; set; }
        public DateTime TimeStarted { get; set; }
        public List<ITurn> ListOfTurns { get; set; }
        public void DisplayBoardOnConsole(IBoard board) { }

        public void RunTurn()
        {
            throw new NotImplementedException();
        }
    }
}
