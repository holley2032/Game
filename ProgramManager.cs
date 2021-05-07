using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ProgramManager
    {
        static public GameInstance InitializeGame(int VictoryPointTotal, int NumberOfPlayers)
        {
            var NewGame = new GameInstance(VictoryPointTotal, NumberOfPlayers);
            return NewGame;
        }
    }
}
