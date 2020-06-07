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
        Upgrade1 upgrade1 = new Upgrade1();
        int total;
        int pps;

        public Form1()
        {
            InitializeComponent();
            total = 0;
            pps = 0;
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
            lblUpgrade1owned.Text = upgrade1.NumberOf + " Owned";
            pps = upgrade1.pps;
            lblPointsPerSecond.Text = pps.ToString();
        }
    }
}
