﻿using System;
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
                                'Ativado' AS Status, 
                                Nome, 
                                Cpf, 
                                Rg, 
                                Email, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_clientes
                                WHERE Status = TRUE";
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    sql += " AND Nome LIKE @nome";
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
                                'Ativado' AS Status, 
                                Nome, 
                                Cpf, 
                                Rg, 
                                Email, 
                                Numero, 
                                Datanasc AS 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_clientes
                                WHERE Status = TRUE";
                if (!string.IsNullOrEmpty(cli.Cpf))
                {
                    sql += " AND Cpf LIKE @cpf";
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

        #region ListarClientesDesativados
        public DataTable ListarClientesDesativados(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Cliente as ID, 
                                'Desativado' AS Status, 
                                Nome, 
                                Cpf, 
                                Rg, 
                                Email, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_clientes
                                WHERE Status = FALSE";
                if (!string.IsNullOrEmpty(cli.Nome))
                {
                    sql += " AND Nome LIKE @nome";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarClientesDesativados) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarClientesDesativadosCpf
        public DataTable ListarClientesDesativadosCpf(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Cliente AS ID, 
                                'Desativado' AS Status, 
                                Nome, 
                                Cpf, 
                                Rg, 
                                Email, 
                                Numero, 
                                Datanasc AS 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_clientes
                                WHERE Status = FALSE";
                if (!string.IsNullOrEmpty(cli.Cpf))
                {
                    sql += " AND Cpf LIKE @cpf";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarClientesDesativadosCpf) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	                            v.Total_Venda AS 'Total da Venda (R$)', 
                                v.Valor_Pago AS 'Valor Pago (R$)', 
                                (v.Total_Venda - v.Valor_Pago) AS 'Dívida (R$)', 
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

        #region ListarCompras
        public DataTable ListarCompras(DateTime inicio, DateTime fim, Cliente cli)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT 
                                v.Id_Venda AS 'ID', 
                                v.Data_Venda AS 'Data da Venda', 
                                v.Total_Venda AS 'Total (R$)', 
                                v.Desconto, 
                                v.Valor_Pago 'Valor Pago (R$)', 
                                v.Status, 
                                v.Observacoes AS 'Observações' 
                            FROM tb_vendas AS v 
                            INNER JOIN tb_clientes AS c ON (v.Cliente_Id=c.Id_Cliente) 
                            WHERE c.Id_Cliente = @id 
                            AND v.Data_Venda BETWEEN @inicio AND @fim";
                //adicioar o PAGAMENTO fazendo JOIN com a tabela de pagamentos
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                executacmd.Parameters.AddWithValue("@inicio", inicio);
                executacmd.Parameters.AddWithValue("@fim", fim);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                connection.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao listar as compras: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
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

        #region AtivarCliente
        public bool AtivarCliente(Cliente cli)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_clientes SET 
                            Status = TRUE 
                            WHERE Id_Cliente=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente Ativado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Ativar o Cliente! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Ativar o Cliente: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region DesativarCliente
        public bool DesativarCliente(Cliente cli)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_clientes SET 
                            Status = FALSE 
                            WHERE Id_Cliente=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente Desativado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Desativar o cliente! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Desativar o Cliente: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarTotalGasto
        public string RetornarTotalGasto(Cliente cli)
        {
            try
            {
                string total;
                string sql = @"SELECT 
                                SUM(Total_Venda) AS 'Total Gasto' 
                                FROM tb_vendas 
                                WHERE Cliente_Id = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    total = rs.GetDecimal("Total Gasto").ToString();
                    if (total == null || total == "0.00")
                    {
                        MessageBox.Show("Esse Cliente ainda Não Gastou Nada.");
                        return total;
                    }
                    return total;
                }
                else
                {
                    MessageBox.Show("Erro ao retornar o Total Gasto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0.00";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao retornar o Total Gasto." + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0.00";
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region RetornarTotalCompras
        public string RetornarTotalCompras(Cliente cli)
        {
            try
            {
                string total;
                string sql = @"SELECT 
                                COUNT(Id_Venda) AS 'Total de Compras' 
                                FROM tb_vendas 
                                WHERE Cliente_Id = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", cli.Id);

                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    total = rs.GetInt32("Total de Compras").ToString();
                    if (total == "0")
                    {
                        MessageBox.Show("Esse Cliente ainda Não Possui Nenhuma Compra.");
                        return total;
                    }
                    return total;
                }
                else
                {
                    MessageBox.Show("Erro ao retornar o Total de Compras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao retornar o Total de Compras." + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}
