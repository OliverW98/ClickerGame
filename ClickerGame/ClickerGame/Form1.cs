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
        Upgrade upgrade1;
        Upgrade upgrade2;
        int timerRunTime;
        double total;
        int pps;
        bool upgrade1Purchased;
        bool upgrade2Purchased;

        public Form1()
        {
            InitializeComponent();
            upgrade1 = new Upgrade(10, 10);
            upgrade2 = new Upgrade(50, 50);
            total = 0;
            pps = 0;
            timerRunTime = 0;
            upgrade1Purchased = false;
            upgrade2Purchased = false;
            lblUpgrade1Cost.Text = "Cost :" + upgrade1.cost;
            lblUpgrade2Cost.Text = "Cost :" + upgrade2.cost;
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
            purchaseCost(upgrade1);
            lblUpgrade1owned.Text = upgrade1.NumberOf + " Owned";
            updatePPS();
            lblUpgrade1Cost.Text = "Cost :" + upgrade1.cost;
        }

        private void btnBuyUpgrade2_Click(object sender, EventArgs e)
        {
            upgrade2.NumberOf++;
            upgrade2Purchased = true;
            purchaseCost(upgrade2);
            lblUpgrade2owned.Text = upgrade2.NumberOf + " Owned";
            updatePPS();
            lblUpgrade2Cost.Text = "Cost :" + upgrade2.cost;
        }

        private void updatePPS()
        {
            pps = upgrade1.pps + upgrade2.pps;
            lblPointsPerSecond.Text = pps + " pp/s";
        }

        private void purchaseCost(Upgrade upgrade)
        {
            total = Math.Round(total - upgrade.cost);
            upgrade.cost = Math.Round(upgrade.cost * 1.5);
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

            if (total >= upgrade2.cost)
            {
                btnBuyUpgrade2.Enabled = true;
            }
            else
            {
                btnBuyUpgrade2.Enabled = false;
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
            if (timerRunTime % 50 == 0 && upgrade2Purchased == true)
            {
                total = total + upgrade2.pps;
            }

            lblPointsTotal.Text = total + " Points";
        }
    }
}
