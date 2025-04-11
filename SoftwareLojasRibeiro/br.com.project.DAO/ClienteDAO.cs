using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection connection;

        public ClienteDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public bool CadastrarCliente(Cliente cli)
        {
            try
            {
                // Perguntar ao usuário antes de cadastrar
                DialogResult resultado = MessageBox.Show("Os dados para cadastro estão corretos? Deseja continuar?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //Definir comando SQL - INSERT INTO
                string sql = @"INSERT INTO tb_clientes 
                            (Nome, Rg, Cpf, Email, Numero, 
                            Datanasc, Endereco, Cep) VALUES 
                            (@nome, @rg, @cpf, @email, @numero, 
                            @datanasc, @endereco, @cep)";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", cli.Nome);
                executacmd.Parameters.AddWithValue("@rg", cli.Rg);
                executacmd.Parameters.AddWithValue("@cpf", cli.Cpf);
                executacmd.Parameters.AddWithValue("@email", cli.Email);
                executacmd.Parameters.AddWithValue("@numero", cli.Numero);
                executacmd.Parameters.AddWithValue("@datanasc", cli.Datanasc);
                executacmd.Parameters.AddWithValue("@endereco", cli.Endereco);
                executacmd.Parameters.AddWithValue("@cep", cli.Cep);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Cadastrar o Cliente: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
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
                string sql = @"SELECT 
                                Id_Cliente as ID, 
                                Nome, 
                                Cpf, 
                                Rg, 
                                Email, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco 
                                FROM tb_clientes";
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    sql += " WHERE Nome LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + cli.Nome + "%");
                }

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente); //preenche o datatable

                return tabelacliente;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarClientes) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarClientesCpf
        public DataTable ListarClientesCpf(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Cliente AS ID, 
                                Nome, 
                                Cpf, 
                                Rg, 
                                Email, 
                                Numero, 
                                Datanasc AS 'Data de Nascimento', 
                                Cep, 
                                Endereco 
                                FROM tb_clientes";
                if (!string.IsNullOrEmpty(cli.Cpf))
                {
                    sql += " WHERE Cpf LIKE @cpf";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um cpf para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(cli.Cpf))
                {
                    executacmd.Parameters.AddWithValue("@cpf", "%" + cli.Cpf + "%");
                }

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente); //preenche o datatable

                return tabelacliente;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarClientesCpf) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region AlterarCliente
        public bool AlterarCliente(Cliente cli)
        {
            try
            {
                // Perguntar ao usuário antes de alterar
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os dados deste cliente?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", cancelar a operação
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_clientes SET 
                            Nome=@nome, Rg=@rg, Cpf=@cpf, Email=@email, Numero=@numero, 
                            Datanasc=@datanasc, Endereco=@endereco, Cep=@cep 
                            WHERE Id_Cliente=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", cli.Nome);
                executacmd.Parameters.AddWithValue("@rg", cli.Rg);
                executacmd.Parameters.AddWithValue("@cpf", cli.Cpf);
                executacmd.Parameters.AddWithValue("@email", cli.Email);
                executacmd.Parameters.AddWithValue("@numero", cli.Numero);
                executacmd.Parameters.AddWithValue("@datanasc", cli.Datanasc);
                executacmd.Parameters.AddWithValue("@endereco", cli.Endereco);
                executacmd.Parameters.AddWithValue("@cep", cli.Cep);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar cliente! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar o Cliente: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ExcluirCliente
        public void ExcluirCliente(Cliente cli)
        {
            try
            {
                // Perguntar ao usuário antes de excluir
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", a função retorna e não executa a exclusão
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Definir comando SQL - INSERT INTO
                string sql = @"DELETE FROM tb_clientes WHERE Id_Cliente=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir o cliente: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarClienteCPF
        public Cliente RetornarClienteCPF(string cpf)
        {
            try
            {
                Cliente cli = new Cliente();

                string sql = @"SELECT * FROM tb_clientes WHERE cpf = @cpf";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                connection.Open();
                //
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read()) //encontrou algo
                {
                    cli.Id = rs.GetInt32("Id_Cliente").ToString(); //resgata o valor da coluna ID como int e converte para string
                    cli.Nome = rs.GetString("Nome");
                    return cli;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    return null;
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu um erro: " + error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarClientesDevedores
        public DataTable ListarClientesDevedores(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelaclientesdevedores = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                v.Id_Venda AS 'ID da Venda', 
                                c.Id_Cliente AS 'ID do Cliente', 
                                c.Nome, 
                                c.Cpf, 
	                            v.Total_Venda AS 'Total da Venda', 
                                v.Valor_Pago AS 'Valor Pago', 
                                (v.Total_Venda - v.Valor_Pago) AS 'Dívida', 
                                v.Data_Venda AS 'Data da Venda', 
                                v.Observacoes AS 'Observações', 
                                c.Email, 
                                c.Numero AS 'Telefone' 
                            FROM tb_clientes c 
                            JOIN tb_vendas v ON c.Id_Cliente = v.Cliente_Id 
                            WHERE v.Status = 'Pendente'";
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    sql += " AND c.Nome LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + cli.Nome + "%");
                }

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaclientesdevedores); //preenche o datatable

                return tabelaclientesdevedores;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarClientesDevedores) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion
    }
}
