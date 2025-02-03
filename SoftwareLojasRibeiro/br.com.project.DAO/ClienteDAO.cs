using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection conecction;

        public ClienteDAO()
        {
            this.conecction = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void CadastrarCliente(Cliente cli)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"INSERT INTO tb_clientes 
                            (Nome, Rg, Cpf, Email, Numero, 
                            Datanasc, Endereco) VALUES 
                            (@nome, @rg, @cpf, @email, @numero, 
                            @datanasc, @endereco)";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conecction);
                executacmd.Parameters.AddWithValue("@nome", cli.Nome);
                executacmd.Parameters.AddWithValue("@rg", cli.Rg);
                executacmd.Parameters.AddWithValue("@cpf", cli.Cpf);
                executacmd.Parameters.AddWithValue("@email", cli.Email);
                executacmd.Parameters.AddWithValue("@numero", cli.Numero);
                executacmd.Parameters.AddWithValue("@datanasc", cli.Datanasc);
                executacmd.Parameters.AddWithValue("@endereco", cli.Endereco);

                //Abrir conexão e executar o comando SQL
                conecction.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso!");

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro: {error}.");
                throw;
            }
        }
        #endregion

    }
}
