using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    class Upgrade : UpgradeBase
    {
        public Upgrade()
        {

            pointsProduction = 10;
            cost = 10;
        }


        public int pointsProduction { get; set; }

        public double cost { get; set; }

    }
}
