using Game.GameLogic;
using Game.HistoricalData;
using System;
using System.Collections.Generic;

namespace Game.CoreFiles
{
    public class InstanceCreator
    {
        public static PlayerAction CreatePlayerAction(IPlayer player, string action)
        {
            return new PlayerAction(player, action);
        }
        public static Board CreateBoard(int numberOfPlayers)
        {
            return new Board(numberOfPlayers);
        }
        public static Dice CreateDice()
        {
            return new Dice();
        }
        public static GameInstance CreateGameInstance(int victoryPointTotal, int numberOfPlayers, List<IPlayer> players, IBoard board, DateTime timeStarted)
        {
            return new GameInstance(victoryPointTotal, numberOfPlayers, players, board, timeStarted);
        }
        public static Player CreatePlayer(string name, int playerNumber)
        {
            return new Player(name, playerNumber);
        }
        public static Tile CreateTile(string type, int column, int row)
        {
            return new Tile(type, column, row);
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
