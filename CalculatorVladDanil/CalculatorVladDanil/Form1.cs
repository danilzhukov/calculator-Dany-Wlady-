using System;
using System.Windows.Forms;

namespace CalculatorVladDanil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Clicking(object sender, EventArgs e)
        {
            var firstArgument = Convert.ToDouble(textBoxEntering1.Text);
            var secondArgument = Convert.ToDouble(textBoxEntering2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.ExecuteOperation(firstArgument, secondArgument);
            labelOut.Text = result.ToString();
        }
    }
}
