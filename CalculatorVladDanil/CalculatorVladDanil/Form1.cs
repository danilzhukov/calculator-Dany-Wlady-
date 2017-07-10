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
            double result;
            var firstArgument = Convert.ToDouble(textBoxEntering1.Text);
            var secondArgument = Convert.ToDouble(textBoxEntering2.Text);
            switch (((Button)sender).Name)
            {
                case "buttonPlus":
                    result = firstArgument + secondArgument;
                    break;
                case "buttonMinus":
                    result = firstArgument - secondArgument;
                    break;
                case "buttonMulti":
                    result = firstArgument * secondArgument;
                    break;
                case "buttonDivision":
                    result = firstArgument / secondArgument;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            labelOut.Text = result.ToString();
        }
    }
}
