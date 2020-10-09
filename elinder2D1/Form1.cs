using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder2D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1Result.Text = "Fail";
            textBox2Result.Text = "Fail";
            textBox3Result.Text = "Fail";
            textBox4Result.Text = "Fail";
            textBox5Result.Text = "Fail";
            textBox6Result.Text = "Fail";
            textBox7Result.Text = "Fail";
            textBox8Result.Text = "Fail";
            textBox9Result.Text = "Fail";
            textBox10Result.Text = "Fail";

            textBox1ResultA.Text = "Sucess";
            textBox2ResultA.Text = "Sucess";
            textBox3ResultA.Text = "Sucess";
            textBox4ResultA.Text = "Sucess";
            textBox5ResultA.Text = "Sucess";
            textBox6ResultA.Text = "Sucess";
            textBox7ResultA.Text = "Sucess";
            textBox8ResultA.Text = "Sucess";
            textBox9ResultA.Text = "Sucess";
            textBox10ResultA.Text = "Sucess";

            if (textBox1Input.Text == "Frank") 
               textBox1Result.Text = "Sucess";
            if (textBox1Input.Text != "Frank")
                textBox1ResultA.Text = "Fail";
                    

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3Result.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultA.Text = "Fail";
                
            
          
            
            
            if (textBox2Input.Text == "")
                textBox2Result.Text = "Sucess";
            if (textBox2Input.Text != "")
                textBox2ResultA.Text = "Fail"; 

           
            
            
            if (textBox4Input.Text == "False")
                textBox4Result.Text = "Sucess";
            if (textBox4Input.Text != "False")
                textBox4ResultA.Text = "Fail";




            
         




           
            
            
            
            if (textBox6Input.Text == "xyz")
                textBox6Result.Text = "Sucess";
            if (textBox6Input.Text != "xyz")
                textBox6ResultA.Text = "Fail";
          
            
            
            
            if (textBox7Input.Text == "1")
                textBox7Result.Text = "Sucess";
            if (textBox7Input.Text != "1")
             textBox7ResultA.Text = "Fail";
 


            if (textBox9Input.Text == "500")
                textBox9Result.Text = "Sucess";
            if (textBox9Input.Text != "500")
                textBox9ResultA.Text = "Fail";
           
            
            if (textBox10InputA.Text == "2")
                textBox10Result.Text = "Sucess";
            if (textBox10InputA.Text != "2")
                textBox10ResultA.Text = "Fail";

            if (textBox5InputB.Text == "2")
                textBox5Result.Text = "Sucess";
            if (textBox5InputB.Text != "2")
                textBox5ResultA.Text = "Fail";

            if (textBox8InputB.Text == "2")
                textBox8Result.Text = "Sucess";
            if (textBox8InputB.Text != "2")
                textBox8ResultA.Text = "Fail";





















        }

        private void SetPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "False";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
        }

        private void SetFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
