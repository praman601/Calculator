using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
       bool isOperationPerformed=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        
        private void button_Click(object sender, EventArgs e)
        {
            if((textBox1.Text=="0") || isOperationPerformed)
            {
                textBox1.Clear();
               
            }

            isOperationPerformed = false;
           Button button=(Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            label.Text = resultValue + " " + operationPerformed;


            isOperationPerformed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
             
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                     break;

                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;


            }
        }
    }
}
 