using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNine.Text = (
        Convert.ToDecimal(textBoxNine.Text) + 1
    ).ToString();
            textBoxTen.Text = (
        Convert.ToDecimal(textBoxTen.Text) + 1
    ).ToString();
            textBoxNine.Text = textBoxNine.Text + textBoxNine.Text;
            labelEight.Text = (
        Convert.ToInt32(textBoxTen.Text) + Convert.ToInt32(textBoxTen.Text)
    ).ToString();
            textBoxTen.TabIndex = 3;
            buttonTwelve.Focus();
            labelEight.Text = "8";
            buttonTwelve.Text = labelSeven.Text + labelEight.Text;
            groupBoxEleven.Left = 20;
            labelSeven.Text = Convert.ToInt32(textBoxTen.Text).ToString()
                    + Convert.ToInt32(textBoxTen.Text).ToString();
            pictureBoxFour.Image = pictureBoxTwo.Image;
            buttonThirteen.Text = textBoxNine.Text;
            textBoxTen.ReadOnly = buttonThirteen.TabStop;
            labelEight.Text = groupBoxFive.Text;
            groupBoxFive.Text = (Convert.ToInt32("5") + 5).ToString();
            buttonTwelve.BackgroundImage = pictureBoxThree.Image;
            textBoxNine.ReadOnly = true;
            textBoxTen.Text = Convert.ToDecimal("1").ToString("n2");















































        }
    }
}