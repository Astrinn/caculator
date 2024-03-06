using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal value1 = 0, value2 = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "0";
;        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResult.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResult.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResult.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResult.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textResult.Text += "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResult.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResult.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResult.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResult.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResult.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string button7_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse (textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operation = "Soma";
            lblOperation.Text = "+"
        }
    }
}
