using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    class Upgrade
    {
        public Upgrade(int e, int c)
        {
            numberOf = 0;
            numBuildingRequired = 15;
            effect = e;
            cost = c;
        }

        public int numberOf { get; set; }
        public int numBuildingRequired { get; set; }
        public int effect { get; set; }
        public double cost { get; set; }
    }
}
