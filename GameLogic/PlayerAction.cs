using Game.CoreFiles;
using Game.GameLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class PlayerAction : IAction
    {
        public PlayerAction(Player player, string action)
        {
            PlayerInstance = player;
            TypeOfAction = action;
        }

        public Player PlayerInstance { get; set; }
        public string TypeOfAction { get; set; }
        public void MovePlayer(Player player, Tile currentLocation, Tile desiredLocation, Turn currentTurn)
        {
            if (currentLocation.AdjacentTo.Contains(desiredLocation))
            {
                PlayerAction currentAction = InstanceCreator.CreatePlayerAction(player, "Move");
                player.Location = desiredLocation;
                currentTurn.ListOfActions.Add(currentAction);
                //Send signal back to currentTurn that turn for this player is complete.
            }
            else
            {
                throw new Exception($"{{player.Name}} cannot move to {{desiredLocation.Name}}. Please choose another tile.");
            }
        }
        public 
    }
}
