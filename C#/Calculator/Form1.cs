using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            if (rdMultiple.Checked)
            {
                MessageBox.Show("Cavab: " + Convert.ToString(a * b));
                rdMultiple.Checked = false;
            }
            if (rdDivide.Checked)
            {
                MessageBox.Show("Cavab: " + Convert.ToString(a / b));
                rdDivide.Checked = false;
            }
            if (rdPlus.Checked)
            {
                MessageBox.Show("Cavab: " + Convert.ToString(a + b));
                rdPlus.Checked = false;
            }
            if (rdMinus.Checked)
            {
                MessageBox.Show("Cavab: " + Convert.ToString(a - b));
                rdMinus.Checked = false;
            }
            if (rdPow.Checked)
            {
                MessageBox.Show("Cavab: " + Convert.ToString(Math.Pow(a,b)));
                rdPow.Checked = false;
            }
            textA.Text = "";
            textB.Text = "";
            process.Text = "";
        }

        private void RdMultiple_CheckedChanged(object sender, EventArgs e)
        {
            process.Text = "*";
        }

        private void RdDivide_CheckedChanged(object sender, EventArgs e)
        {
            process.Text = "/";
        }

        private void RdPlus_CheckedChanged(object sender, EventArgs e)
        {
            process.Text = "+";
        }

        private void RdMinus_CheckedChanged(object sender, EventArgs e)
        {
            process.Text = "-";
        }

        private void RdPow_CheckedChanged(object sender, EventArgs e)
        {
            process.Text = "^";
        }
    }
}
