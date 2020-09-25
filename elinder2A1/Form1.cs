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
            decimal discountamount = Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDiscountPercen);
            txtDiscountAmount.Text = discountamount.ToString("0.00");
            decimal total = Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDiscountAmount.Text);
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
