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
    public partial class frmex7 : Form
    {
        public frmex7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtint.Clear();
            txtquad.Clear();
            txtcubo.Clear();
            txtint.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu quad = new frmmenu();
            quad.Show();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double i, num, quadrado, cubo;
            num = Convert.ToDouble(txtint.Text);
            i = num;
            while (i >=1)
            {
                quadrado = Math.Pow(i, 2);
                txtquad.Text += quadrado.ToString() + Environment.NewLine;
                cubo = Math.Pow(i, 3);
                txtcubo.Text += cubo.ToString() + Environment.NewLine;
                i--;
            }

        }

        private void btndw_Click(object sender, EventArgs e)
        {
            double i, num, quadrado, cubo;
            num = Convert.ToDouble(txtint.Text);
            i = num;
            do
            {
                quadrado = Math.Pow(i, 2);
                txtquad.Text += quadrado.ToString() + Environment.NewLine;
                cubo = Math.Pow(i, 3);
                txtcubo.Text += cubo.ToString() + Environment.NewLine;
                i--;
            } while (i >= 1);

        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double i, num, quadrado, cubo;
            num = Convert.ToDouble(txtint.Text);
            for (i = num; i >= 1; i--)
            {
                quadrado = Math.Pow(i, 2);
                txtquad.Text += quadrado.ToString() + Environment.NewLine;
                cubo = Math.Pow(i, 3);
                txtcubo.Text += cubo.ToString() + Environment.NewLine;
            }
        }
    }
}
