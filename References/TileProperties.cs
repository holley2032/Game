using System;
using System.Collections.Generic;
using System.Text;

namespace Game.References
{
    class TileProperties
    {
        private static readonly Dictionary<string, List<string>> _ValidImprovements = new Dictionary<string, List<string>>(10)
        {
            {"Forest", new List<string>{"Log Cabin", "Lumber Mill"} },
            {"Desert", new List<string>{"Artificial Oasis"} }

        };

        public static Dictionary<string, List<string>> ValidImprovements
        {
            get { return _ValidImprovements; }
        }
        
    }
}
