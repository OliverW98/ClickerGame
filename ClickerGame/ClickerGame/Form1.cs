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
        Upgrade upgrade1; 
        int timerRunTime;
        double total;
        int pps;

        public Form1()
        {
            InitializeComponent();
            building1 = new Building(10, 10); // need to create an economy
            building2 = new Building(50, 50);
            upgrade1 = new Upgrade(2, 150);
            total = 0;
            pps = 0;
            timerRunTime = 0;
            lblBuilding1Cost.Text = "Cost :" + building1.cost;
            lblBuilding2Cost.Text = "Cost :" + building2.cost;
            lblUpgrade1Cost.Text = "Cost :" + upgrade1.cost;
            timer.Start();
        }



        private void btnClickMe_Click(object sender, EventArgs e)
        {
            total = total + 1;
            lblPointsTotal.Text = total + " Points";
        }

        private void btnBuyBuilding1_Click(object sender, EventArgs e)
        {
            purchaseBuilding(building1);
            updatePPS();
            lblBuilding1production.Text = building1.pps() + " pp/s";
            lblBuilding1owned.Text = building1.numberOf + " Owned";
            lblBuilding1Cost.Text = "Cost :" + building1.cost;
        }

        private void btnBuyBuilding2_Click(object sender, EventArgs e)
        {
            purchaseBuilding(building2);
            updatePPS();
            lblBuilding2production.Text = building2.pps() + " pp/s";
            lblBuilding2owned.Text = building2.numberOf + " Owned";
            lblBuilding2Cost.Text = "Cost :" + building2.cost;
        }

        private void btnBuyUpgrade1_Click(object sender, EventArgs e)
        {
            upgrade1.numberOf++;
            building1.pointsProduction = building1.pointsProduction * upgrade1.effect;
            updatePPS();
            lblBuilding1production.Text = building1.pps() + " pp/s";
            lblUpgrade1Owned.Text = upgrade1.numberOf + " Owned";
            total = Math.Round(total - upgrade1.cost);
            upgrade1.cost = Math.Round(upgrade1.cost * 10);
            lblUpgrade1Cost.Text = "Cost :" + upgrade1.cost;
        }

        private void updatePPS()
        {
            pps = building1.pps() + building2.pps();
            lblPointsPerSecond.Text = pps + " pp/s";
        }

        private void purchaseBuilding(Building building)
        {
            building.numberOf++;
            building.purchased = true;
            total = Math.Round(total - building.cost);
            building.cost = Math.Round(building.cost * 1.5); //1.5 is hard coded - maybe a var in the object for individual cost increases. 
        }

        private void CostCheck()
        {
            if (total >= building1.cost)
            {
                btnBuyBuilding1.Enabled = true;
            }
            else
            {
                btnBuyBuilding1.Enabled = false;
            }

            if (total >= building2.cost)
            {
                btnBuyBuilding2.Enabled = true;
            }
            else
            {
                btnBuyBuilding2.Enabled = false;
            }
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

            if (timerRunTime % 10 == 0 && building1.purchased)
            {
                total = total + building1.pps();
            }
            if (timerRunTime % 10 == 0 && building2.purchased)
            {
                total = total + building2.pps();
            }

            lblPointsTotal.Text = total + " Points";
        }


    }
}
