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
    public partial class frmex4 : Form
    {
        public frmex4()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu tela = new frmmenu();
            tela.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdist.Clear();
            txtpremio.Clear();
        }

        private void btrncalcular_Click(object sender, EventArgs e)
        {
            double distancia;
            distancia = Convert.ToDouble(txtdist.Text);
            if (distancia <= 800)
            {
                txtpremio.Text = "R-----$ 5000";
            }

            else if (distancia > 800 && distancia <= 1500)
            {
                txtpremio.Text = "R$ 10000";
            }
            else
                txtpremio.Text = "R$ 15000";

        }
    }
}
