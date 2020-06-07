using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        Upgrade1 upgrade1;
        int timerRunTime;
        int total;
        int pps;
        bool upgrade1Purchased;

        public Form1()
        {
            InitializeComponent();
            upgrade1 = new Upgrade1();
            total = 0;
            pps = 0;
            timerRunTime = 0;
            upgrade1Purchased = false;
            timer.Start();
        }



        private void btnClickMe_Click(object sender, EventArgs e)
        {
            total = total + 1;
            lblPointsTotal.Text = total + " Points";
        }

        private void btnBuyUpgrade1_Click(object sender, EventArgs e)
        {           
            upgrade1.NumberOf++;
            upgrade1Purchased = true;
            lblUpgrade1owned.Text = upgrade1.NumberOf + " Owned";
            pps = upgrade1.pps;
            lblPointsPerSecond.Text = pps.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerRunTime++;

            if (timerRunTime % 100 == 0 && upgrade1Purchased == true )
            {
                total = total + upgrade1.pps;
            }

            lblPointsTotal.Text = total + " Points";
        }
    }
}
