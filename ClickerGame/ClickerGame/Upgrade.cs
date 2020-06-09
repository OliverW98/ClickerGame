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
            effect = e;
            cost = c;
            purchased = false;
        }

        public int numberOf { get; set; }
        public int effect { get; set; }
        public double cost { get; set; }
        public bool purchased { get; set; }
    }
}
