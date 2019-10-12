using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class PositiveNegative : Form
    {
        public PositiveNegative()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox.Text);
            string message;
            if (a > 0)
            {
                message = "Positive";
                MessageBox.Show(message);
            }
            else if (a == 0)
            {
                message = "Zero";
                MessageBox.Show(message);
            }
            else if (a < 0)
            {
                message = "Negative";
                MessageBox.Show(message);
            }
        }
    }
}
