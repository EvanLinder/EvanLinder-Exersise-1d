using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder2i
{
    public partial class resul : Form
    {

        private void calcButton_Click(object sender, EventArgs e)
        {
            float float1 = Convert.ToSingle(inputTextBox1.Text);
            resultTextBox1a.Text = float1.ToString();
            resultTextBox1b.Text = float1.ToString("c");
            resultTextBox1c.Text = float1.ToString("n3");
            resultTextBox1d.Text = float1.ToString("p3");
            resultTextBox1e.Text = float1.ToString("0.00");
            resultTextBox1f.Text = float1.ToString("f5");
        }
    }
}
