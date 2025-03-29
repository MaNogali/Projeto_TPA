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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnex4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex4 dist = new frmex4();
            dist.Show();
        }

        private void btnex5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex5 desconto = new frmex5();
            desconto.Show();
        }

        private void btnex6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex6 op = new frmex6();
            op.Show();
        }

        private void btnex7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex7 cubo = new frmex7();
            cubo.Show();
        }

        private void btncj_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex8 cj = new frmex8();
            cj.Show();
        }

        private void btnescolha_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex9 ex9 = new frmex9();
            ex9.Show();
        }

        private void btnlooping_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex10 ex10 = new frmex10();
            ex10.Show();

        }
    }
}
