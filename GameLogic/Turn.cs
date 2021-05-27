using System.Collections.Generic;

namespace Game.GameLogic
{
    public class Turn : ITurn
    {
        public Turn()
        { }
        public int TurnNumber { get; set; }
        public List<IAction> ListOfActions { get; set; }
        public int NumberOfPlayers { get; set; }
        public IBoard Board { get; set; }

    }
}
