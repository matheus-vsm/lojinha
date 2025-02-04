using System;
using System.Data;
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
                MessageBox.Show($"Ocorreu um erro ao Cadastrar o Cliente: {error}.");
                throw;
            }
            finally
            {
                conecction.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarClientes
        public DataTable ListarClientes(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT Id_Cliente as ID, Nome, 
                                Rg, Cpf, Email, Numero, Datanasc as 
                                'Data de Nascimento', Endereco FROM tb_clientes";
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    sql += " WHERE Nome LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conecction);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + cli.Nome + "%");
                }

                conecction.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente); //preenche o datatable

                return tabelacliente;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! {error}.");
                throw;
            }
            finally
            {
                conecction.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region AlterarCliente
        public void AlterarCliente(Cliente cli)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_clientes SET 
                            Nome=@nome, Rg=@rg, Cpf=@cpf, Email=, Numero=@numero, 
                            Datanasc=@datanasc, Endereco=@endereco WHERE Id=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conecction);
                executacmd.Parameters.AddWithValue("@nome", cli.Nome);
                executacmd.Parameters.AddWithValue("@rg", cli.Rg);
                executacmd.Parameters.AddWithValue("@cpf", cli.Cpf);
                executacmd.Parameters.AddWithValue("@email", cli.Email);
                executacmd.Parameters.AddWithValue("@numero", cli.Numero);
                executacmd.Parameters.AddWithValue("@datanasc", cli.Datanasc);
                executacmd.Parameters.AddWithValue("@endereco", cli.Endereco);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                //Abrir conexão e executar o comando SQL
                conecction.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso!");

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar o Cliente: {error}.");
                throw;
            }
            finally
            {
                conecction.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ExcluirCliente
        public void ExcluirCliente(Cliente cli)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"DELETE FROM tb_clientes WHERE Id_Cliente=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conecction);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                //Abrir conexão e executar o comando SQL
                conecction.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluído com Sucesso!");

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Excluir o Cliente: {error}.");
                throw;
            }
            finally
            {
                conecction.Close(); // Sempre fechar a conexão
            }
        }
        #endregion
    
    }
}
