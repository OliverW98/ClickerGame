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

        int total;
        int pfs;

        public Form1()
        {
            InitializeComponent();
            total = 0;
            pfs = 0;
            timer.Start();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            total = total + 1;
            lblPointsTotal.Text = total + " Points";
        }

        private void btnBuyUpgrade1_Click(object sender, EventArgs e)
        {

            lblUpgrade1owned.Text = " Owned";
        }
    }
}
