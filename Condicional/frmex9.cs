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
    public partial class frmex9 : Form
    {
        public frmex9()
        {
            InitializeComponent();
        }

        private void frmex9_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, operacao, result1, result2;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            operacao = Convert.ToDouble(txtOperacao.Text);
            switch (operacao)
            {
                case 1:
                    result1 = num1 + num2;
                    txtResult.Text = result1.ToString();
                    break;
                case 2:
                    result1 = num1 - num2;
                    txtResult.Text = result1.ToString();
                    break;
                case 3:
                    result1 = num1 / num2;
                    txtResult.Text = result1.ToString();
                    break;
                case 4:
                    result1 = num1 * num2;
                    txtResult.Text = result1.ToString();
                    break;
                case 5:
                    result1 = Math.Pow(num1, 2);
                    result2 = Math.Pow(num2, 2);
                    txtResult.Text += result1.ToString() + Environment.NewLine + result2.ToString();
                    break;
                case 6:
                    result1 = Math.Sqrt(num1);
                    result2 = Math.Sqrt(num2);
                    txtResult.Text += result1.ToString() + Environment.NewLine + result2.ToString();
                    break;
                default:
                    txtResult.Text = ("Operação inválida.");
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtOperacao.Clear();
            txtResult.Clear();
            txtNum1.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu1 = new frmmenu();
            menu1.Show();
        }
    }
}
