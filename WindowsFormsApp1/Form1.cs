using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelOne.Text = (Convert.ToDecimal(textBoxOne.Text)
                            + Convert.ToDecimal(textBoxTwo.Text)).ToString();
            picture.Image = buttonTwo.BackgroundImage;
            textBoxTwo.ReadOnly = true;
            groupBoxTwo.Text = "buttonOne";
            labelOne.Text = textBoxOne.Text + textBoxTwo.Text;
            labelTwo.Text = groupBoxOne.Text;
            buttonOne.TabIndex = 5;
            picture.Top = 32;
            textBoxOne.Focus();
            labelTwo.Text = (Convert.ToInt32("12") + 6).ToString();
            buttonOne.BackgroundImage = pictureBoxThree.Image;
            groupBoxTwo.Text = "5"; labelOne.Text = textBoxTwo.Text;
            labelOne.Text = Convert.ToInt32("1").ToString();
            textBoxOne.TabStop = false;
            textBoxOne.TabStop = textBoxTwo.ReadOnly;






















        }
    }
}
