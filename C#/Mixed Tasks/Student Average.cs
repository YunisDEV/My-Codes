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
    public partial class Ortalama : Form
    {
        public Ortalama()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(math.Text);
            double b = Convert.ToDouble(physics.Text);
            double c = Convert.ToDouble(chemistry.Text);
            double d = Convert.ToDouble(information.Text);
            double f = Convert.ToDouble(english.Text);
            double result = (a + b + c + d + f) / 5;
            if (a > 100 || b > 100 || c > 100 || d > 100 || f > 100 || a < 0 || b < 0 || c < 0 || d < 0 || f < 0)
            {
                MessageBox.Show("Please enter right values.", "Error");
            }
            else
            {

                output.Text = result.ToString();
                if (result > 90)
                {
                    MessageBox.Show("Super");
                }
                else if (result > 80)
                {
                    MessageBox.Show("Good");
                }
                else if (result > 60)
                {
                    MessageBox.Show("Normal");
                }
                else
                {
                    MessageBox.Show("Bad");
                }
            }
        }
    }
}
