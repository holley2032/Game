using Game.GameLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.CoreFiles
{
    public class InstanceCreator
    {
        public static PlayerAction CreatePlayerAction()
        {
            return new PlayerAction();
        }
        public static Board CreateBoard(int numberOfPlayers)
        {
            return new Board(numberOfPlayers);
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
