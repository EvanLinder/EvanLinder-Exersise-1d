using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lol
{
    public partial class Form1 : Form
    {
        private int i1 = 0, i2 = 0, i3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int input1 = Int32.Parse(inputTextBox1.Text);
            int input2 = Int32.Parse(inputTextBox2.Text);
            int input3 = Int32.Parse(inputTextBox3.Text);
            string input4 = inputTextBox4.Text;
            string input5 = inputTextBox5.Text;
            string result = "";

            result += input5.Substring(input1, 1) + " ";

            if (input1 > input2)
            {
                if (input4.Substring(1, 1) == "3")
                {
                    result += "D ";
                }
                else
                {
                    result += "E ";
                }
                result += "F ";

                if (input1 < 2)
                    result += "G ";
                else if (input1 < 4)
                    result += "H ";
                else if
                    (input1 < 6)
                    result += "I ";

                result += "J ";

            }
            else
            {
                result += "K ";
                switch (input1)
                {
                    case 0:
                        result += "L ";
                        break;
                    case 1:
                        result += "M ";
                        break;
                    default:
                        result += "N ";
                        break;

                }
                if (input2 == 4 && input3 > 0)
                {
                    result += "O ";
                }
                else
                {
                    result += "P ";
                }
            }
            resultTextBox.Text = result;
                
            
        }

        private void resultTextBox1f_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox1e_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox1d_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox1c_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox1b_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox1a_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void calcButton2_Click(object sender, EventArgs e)
        {
            i1 = Int32.Parse(inputTextBox1.Text);
        }
    }
}
