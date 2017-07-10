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

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            double result;
           var firstArgument = Convert.ToDouble(textBoxEntering1.Text.ToString());
           var secondArgument = Convert.ToDouble(textBoxEntering2.Text.ToString());
           result = firstArgument + secondArgument;
           labelOut.Text = result.ToString();
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double result;
            var firstArgument = Convert.ToDouble(textBoxEntering1.Text.ToString());
            var secondArgument = Convert.ToDouble(textBoxEntering2.Text.ToString());
            result = firstArgument - secondArgument;
            labelOut.Text = result.ToString();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            double result;
            var firstArgument = Convert.ToDouble(textBoxEntering1.Text.ToString());
            var secondArgument = Convert.ToDouble(textBoxEntering2.Text.ToString());
            result = firstArgument * secondArgument;
            labelOut.Text = result.ToString();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            double result;
            var firstArgument = Convert.ToDouble(textBoxEntering1.Text.ToString());
            var secondArgument = Convert.ToDouble(textBoxEntering2.Text.ToString());
            result = firstArgument / secondArgument;
            labelOut.Text = result.ToString();
        }

        private void textBoxEntering1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntering2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOut_Click(object sender, EventArgs e)
        {

        }
    }
}
