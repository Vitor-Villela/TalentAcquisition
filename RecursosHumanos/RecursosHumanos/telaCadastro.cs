using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanos.BdAcess;

namespace RecursosHumanos
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            textNome.Clear();
            textSenha.Clear();
        }

        public void btCadastrar_Click(object sender, EventArgs e)
        {

            string usuario = textNome.Text;
            string senha = textSenha.Text;

            Acesso cadObj = new Acesso();

            bool cadastrar = cadObj.Cadastrar(usuario, senha);

            if (cadastrar)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                Form1 login = new Form1();
                login.Show();
            }
            else 
            {
                MessageBox.Show("Erro ao cadastrar usuário!");
            }

        }
    }
}
