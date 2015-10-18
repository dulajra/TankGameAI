﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    class Coin
    {
        public Coordinate position { get; set; }

        public int TimeLimit { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Coin position: " + position.ToString() + "\tTimeLimit: " + TimeLimit + "\tValue: " + Value);
            return builder.ToString();
        }
    }
}