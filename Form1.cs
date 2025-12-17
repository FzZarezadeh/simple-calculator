using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_calculator
{
    public partial class Form1 : Form
    {
        class calc
        {
            public double Multiply(double a, double b)
            {
                return a * b;
            }

            public double division(double a, double b)
            {
                return a / b;
            }

            public double mines(double a, double b)
            {
                return a - b;
            }

            public double plus(double a, double b)
            {
                return a + b;
            }
        }

        public double n1 = 0, n2 = 0;
        calc calc1;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnplus_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc1.plus(n1, n2).ToString();
            lbloperator.Text = "+";
        }

        private void btnmines_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc1.mines(n1, n2).ToString();
            lbloperator.Text = "-";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc1.division(n1, n2).ToString();
            lbloperator.Text = "÷";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc1.Multiply(n1, n2).ToString();
            lbloperator.Text = "×";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc1 = new calc();
        }


        private void btnall_mouseDown(object sender, MouseEventArgs e)
        {
            if (txtn1.TextLength > 0 && txtn2.TextLength > 0)
            {
                n1 = double.Parse(txtn1.Text);
                n2 = double.Parse(txtn2.Text);
            }
        }

    }
}
