using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder1730
{
    public partial class frmCurrencyConverterv2 : Form
    {
        public frmCurrencyConverterv2()
        {
            InitializeComponent();
        }

        private void picAustralia_Click(object sender, EventArgs e)
        {

        }

        private void frmCurrencyConverterv2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.730292";
            txtTotalUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Focus();

        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;

        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;

        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCurrency_Click_1(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtTotalUSD.Text;
        }
    }
}
