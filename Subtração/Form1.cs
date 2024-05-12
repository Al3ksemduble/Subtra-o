using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subtração
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //Aviso se algo for digitado incorretamente na caixa 1
            if(!int.TryParse(txtValue1.Text, out int Valor1))
            {
                MessageBox.Show("Por favor, digite um valor válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Aviso se algo for digitado incorretamente na caixa 2
            if (!int.TryParse(txtValue2.Text, out int Valor2))
            {
                MessageBox.Show("Por favor, digite um valor válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Subtraindo valores
            int value1, value2, sub;
            value1 = int.Parse(txtValue1.Text);
            value2 = int.Parse(txtValue2.Text);
            sub = value1 - value2;
            lblResult.Text = $"O Resultado subtraido de {value1} e {value2} é igual a {sub}";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Limpando caixa 1 e 2, colocando o foco na caixa 1 e removendo o resultado passado
            txtValue1.Clear();
            txtValue2.Clear();
            txtValue1.Focus();
            lblResult.Text = "Resultado";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Fechando a aplicação
            Close();
        }
    }
}
