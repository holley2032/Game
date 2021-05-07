using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ProgramManager
    {
        public Boolean InitializeGame(int VictoryPointTotal, int NumberOfPlayers)
        {
            var NewGame = new GameInstance(VictoryPointTotal, NumberOfPlayers);
            return true;
        }
    }
}
