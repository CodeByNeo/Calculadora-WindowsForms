using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Calculator_Visual
{
    public partial class Form1 : Form
    {
        public static double value1;
        public static string operation;

        public Form1()
        {
            InitializeComponent();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            result.Text += "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            result.Text += "2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            result.Text += "3";
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            result.Text += "4";
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            result.Text += "5";
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            result.Text += "6";
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            result.Text += "7"; 
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            result.Text += "8"; 
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            result.Text += "9";
        }

        protected void btnsoma_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(result.Text);
            result.Text = ""; // Clear the result for the next input
            operation = "soma"; // Store the operation type

        }

        protected void btnigual_Click(object sender, EventArgs e)
        {
            double value2 = Convert.ToDouble(result.Text);
            switch(operation)
            {
                case "soma":
                    result.Text = (value1 + value2).ToString();
                    break;
                case "sub":
                    result.Text = (value1 - value2).ToString();
                    break;
                case "multi":
                    result.Text = (value1 * value2).ToString();
                    break;
                case "div":
                    if (value2 != 0)
                        result.Text = (value1 / value2).ToString();
                    else
                        result.Text = "Error: Division by zero";
                    break;
                default:
                    result.Text = "Error: Invalid operation";
                    break;
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            result.Text = ""; // Clear the result display
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            result.Text += "0"; 
        }

        private void btnsub_Click_1(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(result.Text);
            result.Text = ""; // Clear the result for the next input
            operation = "sub"; // Store the operation type
        }

        private void btnmulti_Click_1(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(result.Text);
            result.Text = ""; // Clear the result for the next input
            operation = "multi"; // Store the operation type
        }

        private void btndiv_Click_1(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(result.Text);
            result.Text = ""; // Clear the result for the next input
            operation = "div"; // Store the operation type
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            result.Text = ""; // Add decimal point to the result display
            result.Text += "Clicou errado...";
            await Task.Delay(3000); // Wait for 1 second
            Environment.Exit(0); // Exit the application
        }
    }
}
