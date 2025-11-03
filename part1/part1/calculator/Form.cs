using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        int num1 = 0;
        int num2 = 0;
        int result = 0;//add,sub,mult
        float dividerresult = 0;//division
        string operatortype = "";
        double sqrtval = 0;
        float sqr = 0;
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn9.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sqrtval = int.Parse(txtresult.Text);
            sqrtval = Math.Sqrt(sqrtval);
            txtresult.Text = sqrtval.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn6.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn8.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn5.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn2.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresult.Text += btn0.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operatortype = "divide";
            num1 = int.Parse(txtresult.Text);
            txtresult.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            operatortype = "Add"; 
            num1 = int.Parse(txtresult.Text);
            txtresult.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
         
            num2 = int.Parse(txtresult.Text);
            if (operatortype == "Add")
            {
                result = num1 + num2;
                txtresult.Text = result.ToString();
            }
            else if (operatortype == "subt")
            {
                result = num1 - num2;
                txtresult.Text = result.ToString();
            }
            else if (operatortype == "mult")
            {
                result = num1 * num2;
                txtresult.Text = result.ToString();
            }
       
           
                else if (operatortype == "divide")
                {


                    if (num2 !=0)
                    {
                       dividerresult =(float) num1 / num2;
                        txtresult.Text =dividerresult.ToString();
                    }
          
                    else
                    {
                        txtresult.Text = "we can not divide the number by 0";
                    }
                }
                else
                {
                    txtresult.Text = "EERor";
                }
               
              
            } 
    

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            operatortype = "mult";
            num1 = int.Parse(txtresult.Text);
            txtresult.Text = "";
        }

        private void btnsubstract_Click(object sender, EventArgs e)
        {
            operatortype = "subt";
            num1 = int.Parse(txtresult.Text);
            txtresult.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            sqr = int.Parse(txtresult.Text);
            sqr = sqr * sqr;
            txtresult.Text = sqr.ToString();
        }
    }
}
