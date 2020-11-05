using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {


            //#1
            result1TextBox.Text = Ex2fCalculations.Calc01(input1TextBox.Text);

            //#2 if {block}
            result2TextBox.Text = Ex2fCalculations.Calc02(input2TextBox.Text);

            //#3 if else
            result3TextBox.Text = Ex2fCalculations.Calc03(input3TextBox.Text);

            //#4
            result4TextBox.Text = Ex2fCalculations.Calc04(input4TextBox.Text);

            //#5 
            result5TextBox.Text = Ex2fCalculations.Calc05(input5TextBox.Text);

            //#6
            result6TextBox.Text = Ex2fCalculations.Calc06(input6aTextBox.Text, input6bTextBox.Text);

        }

        private void input6bTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void result6TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void result5TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void result4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void result3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void result2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void result1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input6aTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input5TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
