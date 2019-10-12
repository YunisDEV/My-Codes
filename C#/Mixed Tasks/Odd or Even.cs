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
    public partial class oddeven : Form
    {
        public oddeven()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double nmb = Convert.ToDouble(numberr.Text);
            if (nmb%2==0)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("Odd");
            }

        }
    }
}
