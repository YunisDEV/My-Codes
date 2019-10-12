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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void CbPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlus.Checked)
            {
                cbMinus.Checked = false;
                cbDivide.Checked = false;
                cbMultiple.Checked = false;
                cbModal.Checked = false;
            }
        }

        private void CbMinus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMinus.Checked)
            {
                cbPlus.Checked = false;
                cbDivide.Checked = false;
                cbMultiple.Checked = false;
                cbModal.Checked = false;
            }
        }

        private void CbDivide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDivide.Checked)
            {
                cbMinus.Checked = false;
                cbPlus.Checked = false;
                cbMultiple.Checked = false;
                cbModal.Checked = false;
            }
        }

        private void CbMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMultiple.Checked)
            {
                cbMinus.Checked = false;
                cbDivide.Checked = false;
                cbPlus.Checked = false;
                cbModal.Checked = false;
            }
        }

        private void CbModal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModal.Checked)
            {
                cbMinus.Checked = false;
                cbDivide.Checked = false;
                cbMultiple.Checked = false;
                cbPlus.Checked = false;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            double result = 0;
            if (cbPlus.Checked)
            {
                result = a + b ;
            }else if (cbMinus.Checked)
            {
                result = a - b;
            }else if (cbMultiple.Checked)
            {
                result = a * b;
            }else if (cbDivide.Checked)
            {
                result = a / b;
            }else if (cbModal.Checked)
            {
                result = a % b;
            }
            output.Text =result.ToString();
        }
    }
}
