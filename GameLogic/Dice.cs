using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public class Dice
    {
        public Dice()
        {
            Die1 = new Random();
            Die2 = new Random();
        }
        public int DieRoll1 { get; set; }
        public int DieRoll2 { get; set; }
        public Boolean IsDouble { get; set; }
        public Random Die1 { get; set; }
        public Random Die2 { get; set; }
        public void RollDice() {
            DieRoll1 = Die1.Next(1, 7);
            DieRoll2 = Die2.Next(1, 7);
            if (DieRoll1 == DieRoll2)
            {
                IsDouble = true;
            }
            else
            {
                IsDouble = false;
            }
        }

    }
}
