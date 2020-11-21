using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string lastOperation="";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if(labelError.Text != "")
                labelError.Text = "";
            if (textBoxCurrentOperand.Text[0] == '='||Convert.ToInt32(textBoxCurrentOperand.Text) == 0 )
                textBoxCurrentOperand.Text = (((Button)sender).Text);
            else
                textBoxCurrentOperand.Text = textBoxCurrentOperand.Text + (((Button)sender).Text);
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if (labelError.Text != "")
                labelError.Text = "";
            if (textBoxCurrentOperand.Text[0] == '=')
            {
                labelSecondOperand.Text = textBoxCurrentOperand.Text.Substring(1);
            }
            else
            {
                labelSecondOperand.Text = textBoxCurrentOperand.Text;
            }
            textBoxCurrentOperand.Text = "0";
            lastOperation = ((Button)sender).Text;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (labelError.Text != "")
                labelError.Text = "";
            switch (lastOperation)
            {
                case "+":
                    textBoxCurrentOperand.Text = "=" +(Convert.ToInt32(labelSecondOperand.Text) + Convert.ToInt32(textBoxCurrentOperand.Text));
                    break;
                case "-":
                    textBoxCurrentOperand.Text = "=" +(Convert.ToInt32(labelSecondOperand.Text) - Convert.ToInt32(textBoxCurrentOperand.Text));
                    break;
                case "/":
                    if (Convert.ToInt32(textBoxCurrentOperand.Text) != 0)
                        textBoxCurrentOperand.Text = "=" + (Convert.ToInt32(labelSecondOperand.Text) / Convert.ToInt32(textBoxCurrentOperand.Text));
                    else
                        labelError.Text = "Error: Division by zero";
                    break;
                case "*":
                    textBoxCurrentOperand.Text = "=" +(Convert.ToInt32(labelSecondOperand.Text) * Convert.ToInt32(textBoxCurrentOperand.Text));
                    break;
            }
            lastOperation = "";
            labelSecondOperand.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCurrentOperand.Text = "0";
            labelSecondOperand.Text = "0";
            lastOperation = "";
        }
    }
}
