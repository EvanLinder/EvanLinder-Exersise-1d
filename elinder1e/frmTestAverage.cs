using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder1e
{
    public partial class frmTestAverage : Form
    {
        public frmTestAverage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest2.Text) + Convert.ToDecimal(txtTest3.Text) / 3.0m).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
