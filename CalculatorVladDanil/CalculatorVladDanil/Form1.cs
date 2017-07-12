using System;
using System.Windows.Forms;
using CalculatorVladDanil.OneArgument;
using CalculatorVladDanil.TwoArguments;
/// <summary>
/// Initializing form components and handling keystrokes
/// Clicking for two argument
/// ClicklingOne one argument
/// </summary>
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
            var calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.ExecuteOperation(firstArgument, secondArgument);
            labelOut.Text = result.ToString();
        }

        public void ClicklingOne(object sender, EventArgs e)
        {
            var firstArgument = Convert.ToDouble(textBoxEntering1.Text);
            var calculator = OneArgumentsFactory.CreateCalculator(((Button) sender).Name);
            double result = calculator.OneArgumentOperation(firstArgument);
            labelOut.Text = result.ToString();
        }
    }      
}
