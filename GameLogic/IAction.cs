using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameLogic
{
    public interface IAction
    {
        public IPlayer PlayerInstance { get; set; }
        public string TypeOfAction { get; set; }
    }
}
