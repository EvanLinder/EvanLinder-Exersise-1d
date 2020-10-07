using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder2A1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercen = Convert.ToDecimal(txtDiscountPercen.Text);
            decimal discountAmount = subtotal * discountPercen / 100m;
            decimal total = subtotal - discountAmount;
            txtTotal.Text = total.ToString("0.00");
            txtDiscountAmount.Text = discountAmount.ToString("0.00");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
