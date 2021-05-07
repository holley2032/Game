using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramManager Manager = new ProgramManager();
            GameInstance NewGame = ProgramManager.InitializeGame(7, 5);
            Console.WriteLine($"You have created a new game with a victory point total of {NewGame.VictoryPointTotal} and {NewGame.NumberOfPlayers} players");
        }
    }
}
