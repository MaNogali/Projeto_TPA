using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicional
{
    public partial class frmex10 : Form
    {
        public frmex10()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num,  i, soma;
            num = Convert.ToInt32(txt1.Text);
            soma = 0;
            for(i = 1; i <= num; i++)
            {
                if(num % i == 0)
                    soma = soma + i;
            }
            if (soma == num)
                txt2.Text = ("O número é perfeito");
            else
                txt2.Text = ("O número não é perfeito");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt1.Focus();
        }
    }
}
