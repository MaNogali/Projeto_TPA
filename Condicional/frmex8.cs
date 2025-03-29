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
    public partial class frmex8 : Form
    {
        public frmex8()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu1 = new frmmenu();
            menu1.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtanos.Clear();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double i, chico, joao;
            i = 0;
            chico = 150;
            joao = 110;
            while (chico >= joao)
            {
                chico = chico + 2;
                joao = joao + 3;
                txtanos.Text = i.ToString();
                i++;
            }
        }

        private void btndw_Click(object sender, EventArgs e)
        {
            double i, chico, joao;
            i = 0;
            chico = 150;
            joao = 110;
            do
            {
                chico = chico + 2;
                joao = joao + 3;
                txtanos.Text = i.ToString();
                i++;
            } while (chico >= joao);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double i, chico, joao;
            i = 0;
            chico = 150;
            joao = 110;
            for (i = 0; chico >= joao; i++)
            {
                chico = chico + 2;
                joao = joao + 3;
                txtanos.Text = i.ToString();
            }
        }
    }
}
