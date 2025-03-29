using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicional
{
    public partial class frmex6 : Form
    {
        public frmex6()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtop.Clear();
            txtresult.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu tela3 = new frmmenu();
            tela3.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, op, result;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            op = Convert.ToDouble(txtop.Text);
            if (op == 1)
            {
                result = num1 + num2;
                txtresult.Text = result.ToString();
            }
            else if (op == 2)
            {
                result = num1 - num2;
                txtresult.Text = result.ToString();
            }

            else if (op == 3)
            {
                result = num1 / num2;
                txtresult.Text = result.ToString();
            }

            else
            {
                result = num1 * num2;
                txtresult.Text = result.ToString();
            }
        }
    }
}