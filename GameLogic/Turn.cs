using System.Collections.Generic;

namespace Game.GameLogic
{
    public class Turn : ITurn
    {
        public int TurnNumber { get; set; }
        public List<IAction> ListOfActions { get; set; }

    }
}
