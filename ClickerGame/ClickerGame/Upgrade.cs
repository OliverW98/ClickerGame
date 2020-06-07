using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    class Upgrade : UpgradeBase
    {
        public Upgrade( int pp , int c)
        {
            pointsProduction = pp;
            cost = c;
        }


        public new int pointsProduction { get; set; }

        public new double cost { get; set; }

    }
}
