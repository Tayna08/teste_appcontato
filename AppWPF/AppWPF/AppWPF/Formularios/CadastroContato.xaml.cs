using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AppWPF.Contexto;
using MySql.Data.MySqlClient;

namespace AppWPF.Formularios
{
    /// <summary>
    /// Lógica interna para CadastroContato.xaml
    /// </summary>
    public partial class CadastroContato : Window
    {
        private MySqlConnection _conexao;
        private string sexoDado;
        public CadastroContato()
        {
            InitializeComponent();
            Conexao();
        }
        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btSalvar_Click_1(object sender, RoutedEventArgs e)
        {
             try
            {
              
                var nome = tbNome.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;
                var sexo = sexoDado;

                if (dtpData.SelectedDate != null)
                {
                    DateTime dataNasc = (DateTime) dtpData.SelectedDate;
                

                    var sql = "INSERT INTO contato (data_nasc_con, nome_con, email_con, telefone_con, sexo_con) VALUES (@_data_nasc, @_nome, @_email, @_telefone, @_sexo);";
                    var comando = new MySqlCommand(sql, _conexao);

                    comando.Parameters.AddWithValue("@_data_nasc", dataNasc.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("SALVO COM SUCESSO!!!");
                }

                
             }
            catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Ocorreram erros ao salvar as informações! Contate a equipe de suporte do sistema. (CAD 10)");

             }

            tbEmail.Clear();
            tbNome.Clear();
            tbTelefone.Clear();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            sexoDado = "Masculino";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            sexoDado = "Feminino";
        }
    }
}
