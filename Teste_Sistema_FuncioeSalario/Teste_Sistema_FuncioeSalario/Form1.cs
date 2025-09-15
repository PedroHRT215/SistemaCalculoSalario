using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Sistema_FuncioeSalario
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            cboCargo.Items.Clear();
            //Pedro
            //criando opções para o usuário inserir 
            //seu cargo respectivo
            //ou seja
            //se ele é CLT, estag. ou PJ
            cboCargo.Items.Add("Selecione um cargo");
            cboCargo.Items.Add("CLT");
            cboCargo.Items.Add("Estagiário");
            cboCargo.Items.Add("PJ");

            //definindo o primeiro item como selecionado
            cboCargo.SelectedIndex = 0;

            //adicionando no formulário
            this.Controls.Add(cboCargo);
        }
        
        
        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboCargo.SelectedIndex == 0)
            {
                MessageBox.Show("Insira um cargo válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
