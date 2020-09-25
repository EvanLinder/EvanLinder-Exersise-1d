using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variableSamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotDogsSubtotal.Text = (
            //    4.00m * Convert.ToInt32(txtHotDogs.Text)
            //    ).ToString("0.00");
            int hotdogs = 5;
            decimal hotdogPrice = 4.0m;
            decimal hotdogsSubtotal = hotdogs * hotdogPrice;
            txtHotDogsSubtotal.Text = hotdogsSubtotal.ToString("0.00");


            //txtHamburgersSubtotal.Text = (
            //    5.00m * Convert.ToInt32((txtHamburgers.Text)
            //    ).ToString("0.00");
            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 5.0m;
            decimal HamburgersSubtotal = hamburgers * hamburgerPrice;
            txtHamburgersSubtotal.Text = HamburgersSubtotal.ToString("0.00");
            //txtPretaxTotal.Text = (
            //    Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //    ).ToString("0.00");
            decimal pretaxTotal = hotdogsSubtotal + HamburgersSubtotal;
            txtPretaxTotal.Text = pretaxTotal.ToString("0.00");
            //txtTax.Text = (6.875m * Convert.ToDecimal(txtPretaxTotal.Text) / 100m)
            //    .ToString("0.00");
            decimal tax = 6.875m * pretaxTotal / 100;
            txtTax.Text = tax.ToString("0.00");

            //txtTotal.Text = (
            //    Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //    ).ToString("0.00");
            decimal total = pretaxTotal + tax;
            txtTotal.Text = total.ToString("0.00");
            btnClear.Focus();


            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTax_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
