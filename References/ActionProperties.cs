using System;
using System.Collections.Generic;
using System.Text;

namespace Game.References
{
    public class ActionProperties
    {
        private static readonly List<string> _ListOfActions = new List<string>(6) 
        {
            "Move",
            "Harvest",
            "Build",
            "Trade",
            "Sell",
            "Skip"
        };

        public static List<string> ListOfActions
        {
            get { return _ListOfActions; }
        }
        private static readonly List<string> _ListOfNonFinalActions = new List<string>(2)
        {
            "Trade",
            "Sell"
        };

        public static List<string> ListOfNonFinalActions
        {
            get { return _ListOfNonFinalActions; }
        }


    }
}
