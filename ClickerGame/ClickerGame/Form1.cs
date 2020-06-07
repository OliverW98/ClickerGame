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
        double total;
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
            lblUpgrade1Cost.Text = "Cost :" + upgrade1.cost;
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
            total = Math.Round(total - upgrade1.cost);
            upgrade1.cost = Math.Round(upgrade1.cost * 1.5);
            lblUpgrade1owned.Text = upgrade1.NumberOf + " Owned";
            pps = upgrade1.pps;
            lblPointsPerSecond.Text = pps + " pp/s";
            lblUpgrade1Cost.Text = "Cost :" + upgrade1.cost;
        }

        private void CostCheck()
        {
            if (total >= upgrade1.cost)
            {
                btnBuyUpgrade1.Enabled = true;
            }
            else
            {
                btnBuyUpgrade1.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CostCheck();

            timerRunTime++;

            if (timerRunTime % 100 == 0 && upgrade1Purchased == true )
            {
                total = total + upgrade1.pps;
            }

            lblPointsTotal.Text = total + " Points";
        }
    }
}
