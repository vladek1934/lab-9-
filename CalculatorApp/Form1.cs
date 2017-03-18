using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        CaclBrain brain = new CaclBrain();
        public Form1()
        {
            brain.n = 0;
            brain.firstoperand = 0 ;
            InitializeComponent();
            display.Text = "Welcome";
        }

        private void digitbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "Welcome" || (display.Text == "0"&& btn.Text!=",")) { display.Text = ""; }
            display.Text += btn.Text;
        }

        private void operationbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
          
            if (btn.Text != "=") { brain.n++; }
            if (btn.Text == "=" || brain.n >= 2)
            {
                brain.n = 4; 
                brain.secondoperand = double.Parse(display.Text);
                if (brain.symbol == '+') { display.Text = brain.Plus().ToString(); }
                if (brain.symbol == '-') { display.Text = brain.Minus().ToString(); }
                if (brain.symbol == '*') { display.Text = brain.Multiply().ToString(); }
                if (brain.symbol == '/') { display.Text = brain.Divide().ToString(); }
                if (brain.symbol == '%') { display.Text = brain.Percent().ToString(); }
                if (brain.symbol == '^') { display.Text = brain.Powerof().ToString(); }
            }

            if (brain.n >0)
            {
                if (btn.Text == "+")
                {

                    brain.firstoperand = double.Parse(display.Text);

                    brain.symbol = '+';
                    display.Text = "";
                }

                if (btn.Text == "x^2")
                {

                    double number = Math.Pow(double.Parse(display.Text), 2);

                    display.Text = number.ToString();
                    brain.symbol = ' ';
                }
                if (btn.Text == "1/x")
                {
                    double number = 1 / double.Parse(display.Text);

                    display.Text = number.ToString();

                }
                if (btn.Text == "x^y")
                {
                    brain.firstoperand = double.Parse(display.Text);
                    display.Text = "";
                    brain.symbol = '^';
                }
                if (btn.Text == "%")
                {
                    brain.firstoperand = double.Parse(display.Text);
                    display.Text = "";
                    brain.symbol = '%';
                }

                if (btn.Text == "sqrt")
                {
                    double number = Math.Sqrt(double.Parse(display.Text));

                    display.Text = number.ToString();

                }

                if (btn.Text == "-")
                {
                    brain.firstoperand = double.Parse(display.Text);
                    display.Text = "";
                    brain.symbol = '-';
                }



                if (btn.Text == "*")
                {
                    brain.firstoperand = double.Parse(display.Text);
                    display.Text = "";
                    brain.symbol = '*';
                }


                if (btn.Text == "/")
                {
                    brain.firstoperand = double.Parse(display.Text);
                    display.Text = "";
                    brain.symbol = '/';
                }


                if (btn.Text == "CE")
                {
                    brain.secondoperand = 0;
                    display.Text = "0";
                    brain.symbol = '+';
                }

                if (btn.Text == "C")
                {
                    brain.secondoperand = 0;
                    brain.firstoperand = 0;
                    display.Text = "0";
                    brain.symbol = '+';
                }
            }
           }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (brain.secondoperand != 0) { label1.Text = brain.firstoperand.ToString() + brain.symbol.ToString() + brain.secondoperand; }
            if (brain.secondoperand == 0) { label1.Text = brain.firstoperand.ToString() + brain.symbol.ToString(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }
        }
    }

