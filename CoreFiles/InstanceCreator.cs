using System;
using System.Collections.Generic;
using System.Text;

namespace Game.CoreFiles
{
    class InstanceCreator
    {
        public static Action CreateAction()
        {
            return new Action();
        }
        public static Dice CreateDice()
        {
            return new Dice();
        }
        public static GameInstance CreateGameInstance(int victoryPointTotal, int numberOfPlayers, List<Player> players, List<Tile> board, DateTime timeStarted)
        {
            return new GameInstance(victoryPointTotal, numberOfPlayers, players, board, timeStarted);
        }
        public static Player CreatePlayer(string name, int playerNumber)
        {
            return new Player(name, playerNumber);
        }
        public static Tile CreateTile(string type)
        {
            return new Tile(type);
        }
        public static Turn CreateTurn()
        {
            return new Turn();
        }
        public static FinishedGame CreateFinishedGame()
        {
            return new FinishedGame();
        }
        public static HallOfGame CreateHallOfGame()
        {
            return new HallOfGame();
        }
        public static PlayerHistory CreatePlayerHistory()
        {
            return new PlayerHistory();
        }
        public static ProgramManager CreateProgramManager()
        {
            return new ProgramManager();
        }
    }
}
