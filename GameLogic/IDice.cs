using System;

namespace Game.GameLogic
{
    public interface IDice
    {
        public int DieRoll1 { get; set; }
        public Random Die1 { get; set; }
        public void RollDice()
    }
}
