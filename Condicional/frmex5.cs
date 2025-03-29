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
    public partial class frmex5 : Form
    {
        public frmex5()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtreg.Clear();
            txtpreco.Clear();
            txtdesconto.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu tela2 = new frmmenu();
            tela2.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco, reg, result;
            preco = Convert.ToDouble(txtpreco.Text);
            reg = Convert.ToDouble(txtreg.Text);
            if (reg == 1)
            {
                result = (preco * 5) / 100;
                txtdesconto.Text = result.ToString();
            }
            else if (reg == 2)
            {
                result = (preco * 15) / 100;
                txtdesconto.Text = result.ToString();
            }
            else if (reg == 3)
            {
                result = (preco * 7) / 100;
                txtdesconto.Text = result.ToString();
            }

            else if (reg == 4)
            {
                result = (preco * 12) / 100;
                txtdesconto.Text = result.ToString();
            }

            else if (reg == 5)
            {
                result = (preco * 20) / 100;
                txtdesconto.Text = result.ToString();
            }

            else
                txtdesconto.Text = "O produto é importado";
        }

        private void frmex5_Load(object sender, EventArgs e)
        {
         
        }
    }
}
