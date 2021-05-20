using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    interface IAction
    {
        public Player PlayerInstance { get; set; }
        public string TypeOfAction { get; set; }
    }
}
