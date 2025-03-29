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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string login = 
                txtlogin.Text;
            string senha = 
                txtsenha.Text; 
            if (login == "Marina" && senha == "12345")
            {
                this.Hide();
                frmmenu menu = new frmmenu();
                menu.Show();
            }

            else if(login == "Laura" && senha == "67890")
            {
                this.Hide();
                frmmenu menu = new frmmenu();
                menu.Show();
            }

            else
            {
                MessageBox.Show("login ou senha inválido", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Clear();
                txtsenha.Clear();
                txtlogin.Focus();   
            }
        }
    }
}
