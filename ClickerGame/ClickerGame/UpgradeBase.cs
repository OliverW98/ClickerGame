using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    class UpgradeBase
    {
        public UpgradeBase()
        {
            numberOf = 0;
            pointsProduction = 0;
            cost = 0;
        }

        int numberOf;

        public int NumberOf
        {
            get { return numberOf; }
            set
            {
                numberOf = numberOf + 1;
                pps = numberOf * pointsProduction;
            }
        }
        public int pointsProduction { get; set; }

        public double cost { get; set; }
        public int pps { get; private set; }
    }
}
