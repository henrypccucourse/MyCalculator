using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class MyCalculator : Form
    {
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            displayTextField.Text = $"{displayTextField.Text}8";
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            var historyForm = new History();
            historyForm.Show();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}0";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}7";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}9";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}6";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}5";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}4";
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}1";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (displayTextField.Text.Equals("0"))
            {
                displayTextField.Text = string.Empty;
            }

            displayTextField.Text = $"{displayTextField.Text}3";
        }
    }
}
