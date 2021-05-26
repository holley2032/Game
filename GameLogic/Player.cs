using System;
using System.Collections.Generic;
using Game.CoreFiles;

namespace Game.GameLogic
{
    public class Player : IPlayer
    {
        public Player(string name, int playerNumber)
        {
            Name = name;
            Points = 0;
            PlayerNumber = playerNumber;
            if (playerNumber == 1)
            {
                IsTurn = true;
            }
            else
            {
                IsTurn = false;
            }
        }
        public string Name { get; set; }
        public int Points { get; set; }
        public int PlayerNumber { get; set; }
        public bool IsTurn { get; set; }

        private ITile _Location;
        public ITile Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public Dictionary<IItem, int> Inventory { get; set; }
        override public string ToString()
        {
            return $"Player {PlayerNumber}, {Name}";
        }
        public void ActionComplete(ITurn currentTurn, IAction currentAction)
        {
            currentTurn.ListOfActions.Add(currentAction);
            //Send signal back to currentTurn that turn for this player is complete.
        }
        public void MovePlayer(ITile currentLocation, ITile desiredLocation)
        {
            if (currentLocation.AdjacentTo.Contains(desiredLocation))
            {
                Location = desiredLocation;
                var currentAction = InstanceCreator.CreatePlayerAction(this, "Move");
            }
            else
            {
                throw new Exception($"{{player.Name}} cannot move to {{desiredLocation.Name}}. Please choose another tile.");
            }
        }
        public void BuildImprovement(ITile tile, IImprovement improvement)
        {
            if (tile.ValidImprovements.Contains(improvement))
            {
                var currentAction = InstanceCreator.CreatePlayerAction(this, "Build");
            }
            else
            {
                throw new Exception($"{{tile.Name}} cannot contain {{improvement.Name}}");
            }
        }
        public void SkipTurn(ITurn currentTurn)
        {
            var currentAction = InstanceCreator.CreatePlayerAction(this, "Skip");
            ActionComplete(currentTurn, currentAction);
        }
    }
}
