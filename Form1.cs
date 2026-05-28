using System;
using System.Windows.Forms;

namespace InfinitePrecisionCalculator
{
    public partial class Form1 : Form
    {
        private string expression = "";
        private ExpressionCalculator calculator;

        public Form1()
        {
            InitializeComponent();

            calculator = new ExpressionCalculator();
        }

        private void AddSymbol(string symbol)
        {
            expression += symbol;
            txtDisplay.Text = expression;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddSymbol(btn.Text);
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddSymbol(btn.Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = calculator.Calculate(expression);
            expression = txtDisplay.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            expression = "";
            txtDisplay.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (expression.Length > 0)
            {
                expression = expression.Remove(expression.Length - 1);
                txtDisplay.Text = expression;
            }
        }
    }
}
