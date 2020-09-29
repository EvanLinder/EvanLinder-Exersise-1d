using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = 10m;
            decimal rateAustralia = 0.71976m;
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountBhutan = 100m;
            decimal rateBhutan = 0.013831m;
            decimal usdBhutan = amountBhutan * rateBhutan;

            decimal amountCostaRica = 1000m''
            decimal rateCostaRica = 0.00176122m;
            decimal usdCostaRica = amountCostaRica * rateCostaRica;

            decimal amountEuro = 10000m;
            decimal rateEuro = 1.15528m;
            decimal usdEuro = amountEuro * rateEuro''



            decimal totalUSD = usdAustralia + usdBhutan + usdCostaRica + usdEuro;



        }
    }
}
