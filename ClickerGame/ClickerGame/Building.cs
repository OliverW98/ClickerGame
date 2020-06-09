﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    class Building 
    {
        public Building( int pp , int c)
        {
            numberOf = 0;
            pointsProduction = pp;
            cost = c;
            purchased = false;
        }

        public int numberOf { get; set; }
        public int pointsProduction { get; set; }
        public bool purchased { get; set; }
        public double cost { get; set; }

        public int pps()
        {
            return pointsProduction * numberOf;
        }
    }
}
