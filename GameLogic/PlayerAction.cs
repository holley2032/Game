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
    }
}
