using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_PDS.RegrasDenegocios;

namespace Projeto_PDS.Formulários
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cadastramento cadastro = new Cadastramento();
            cadastro.Email = tbEmail.Text;
            cadastro.Nome = tbNome.Text;
            cadastro.Data = Convert.ToDateTime(dtpNascimento.Text);
            cadastro.Sexo = tbSexo.Text;
            cadastro.Numero = tbNumero.Text;
        }
    }
}
