using MySql.Data.MySqlClient; 
using System;
using System.Data;
using System.Windows.Forms;
using RecursosHumanos.BdAcess;


namespace RecursosHumanos.BdAcess
{
    public class Acesso
    {
        //Conecta o MySQL
        public string connectionString = "Server=localhost;Database=recursosHumanos;Uid=root;Pwd=;";

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        //Carrega os dados do banco
        public void CarregarDados(DataGridView dataGridView)
        {
            // Consulta SQL
            string query = "SELECT * FROM login"; 

            // Criação da conexão
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection))
                    {
                        
                        DataTable dataTable = new DataTable();

                        
                        dataAdapter.Fill(dataTable);

                        
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        //Autentica o usuario
        public bool Autenticar(string usuario, string senha)
        {

            string query = "SELECT COUNT(*) FROM login WHERE user = @usuario AND password = @senha";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    connection.Open();
                    int resultado = Convert.ToInt32(command.ExecuteScalar());

                    // Retorna verdadeiro se o usuário foi encontrado
                    return resultado > 0;

                }
            }
            

        }

        //Cadastra usuario
        public bool Cadastrar(string usuario, string senha)
        {

            string query = "INSERT INTO login (user, password) VALUES (@usuario, @senha)";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    connection.Open();
                    int resultado = Convert.ToInt32(command.ExecuteScalar());

                    // Retorna verdadeiro se o usuário foi encontrado
                    return resultado > 0;

                }
            }


        }

    }



        
        

    
        
            
}

        
    
