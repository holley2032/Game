using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public class Turn
    {
        public int TurnNumber { get; set; }
        public List<IAction> ListOfActions { get; set; }

    }
}
