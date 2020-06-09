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
        Building building1;
        Building building2;
        int timerRunTime;
        double total;
        int pps;

        public Form1()
        {
            InitializeComponent();
            building1 = new Building(10, 10); // need to create an economy
            building2 = new Building(50, 50);
            total = 0;
            pps = 0;
            timerRunTime = 0;
            lblBuilding1Cost.Text = "Cost :" + building1.cost;
            lblBuilding2Cost.Text = "Cost :" + building2.cost;
            timer.Start();
        }



        private void btnClickMe_Click(object sender, EventArgs e)
        {
            total = total + 1;
            lblPointsTotal.Text = total + " Points";
        }

        private void btnBuyUpgrade1_Click(object sender, EventArgs e)
        {
            purchaseUpgrade(building1);
            updatePPS();
            lblBuilding1production.Text = building1.pps + " pp/s";
            lblBuilding1owned.Text = building1.NumberOf + " Owned";
            lblBuilding1Cost.Text = "Cost :" + building1.cost;
        }

        private void btnBuyUpgrade2_Click(object sender, EventArgs e)
        {
            purchaseUpgrade(building2);
            updatePPS();
            lblBuilding2production.Text = building2.pps + " pp/s";
            lblBuilding2owned.Text = building2.NumberOf + " Owned";
            lblBuilding2Cost.Text = "Cost :" + building2.cost;
        }

        private void updatePPS()
        {
            pps = building1.pps + building2.pps;
            lblPointsPerSecond.Text = pps + " pp/s";
        }

        private void purchaseUpgrade(Building upgrade)
        {
            upgrade.NumberOf++;
            upgrade.purchased = true;
            total = Math.Round(total - upgrade.cost);
            upgrade.cost = Math.Round(upgrade.cost * 1.5); //1.5 is hard coded - maybe a var in the object for individual cost increases. 
        }


        private void CostCheck()
        {
            if (total >= building1.cost)
            {
                btnBuyUpgrade1.Enabled = true;
            }
            else
            {
                btnBuyUpgrade1.Enabled = false;
            }

            if (total >= building2.cost)
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

            if (timerRunTime % 100 == 0 && building1.purchased)
            {
                total = total + building1.pps;
            }
            if (timerRunTime % 100 == 0 && building2.purchased)
            {
                total = total + building2.pps;
            }

            lblPointsTotal.Text = total + " Points";
        }
    }
}
