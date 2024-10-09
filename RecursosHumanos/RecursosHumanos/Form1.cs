using MySql.Data.MySqlClient; 
using System;
using System.Windows.Forms;
using RecursosHumanos.BdAcess;

namespace RecursosHumanos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {

            string usuario = textUser.Text;
            string senha = textPassword.Text;

            Acesso loginObj = new Acesso();

            bool autenticar = loginObj.Autenticar(usuario, senha);

            if (autenticar)
            {
                PrincipalAdm principalAdm = new PrincipalAdm();
                principalAdm.Show();
                

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            telaCadastro telaCad = new telaCadastro();
            telaCad.Show();
            
        }
    }
}
