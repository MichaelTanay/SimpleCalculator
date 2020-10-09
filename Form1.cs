using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {

            GetAction SumAction = new GetAction(formula.getSum);

            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);

            MessageBox.Show("The Sum is:" + " " + SumAction(a, b).ToString());
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            GetAction SubAction = new GetAction(formula.getSub);

            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);

            MessageBox.Show("The Difference is:" + " " + SubAction(a, b).ToString());
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            GetAction MultiAction = new GetAction(formula.getMulti);

            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);

            MessageBox.Show("The Product is:" + " " + MultiAction(a, b).ToString());
        }

        private void Divition_Click(object sender, EventArgs e)
        {
            GetAction DivAction = new GetAction(formula.getDiv);

            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);

            MessageBox.Show("The Quotient is:"+ " " + DivAction(a, b).ToString());
        }


    }
}
