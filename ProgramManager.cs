using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ProgramManager
    {
        static public List<Tile> InitializeBoard(int numberOfPlayers)
        {
            List<Tile> board = new List<Tile>(BoardProperties.PlayersToTiles.GetValueOrDefault(numberOfPlayers));
            return board;
        }
        static public List<Player> InitializePlayers(int numberOfPlayers)
        {
            List<Player> players = new List<Player>(numberOfPlayers);
            return players;
        }
        static public GameInstance InitializeGame(int victoryPointTotal, int numberOfPlayers, List<Player> players, List<Tile> board)
        {
            var NewGame = new GameInstance(victoryPointTotal, numberOfPlayers, players, board);
            return NewGame;
        }
    }
}
