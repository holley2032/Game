﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Turn
    {
        public int TurnNumber { get; set; }
        public List<PlayerAction> ListOfActions { get; set; }
    }
}