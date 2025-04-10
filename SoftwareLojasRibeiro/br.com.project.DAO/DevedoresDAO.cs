using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class DevedoresDAO
    {
        private MySqlConnection connection;

        public DevedoresDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarClienteDevedor
        public bool CadastrarClienteDevedor(Devedores devedor)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"INSERT INTO tb_historico_devedores 
                            (Cliente_Id, Venda_Id, Divida) 
                            VALUES (@idcli, @idven, @divida)";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@idcli", devedor.Id_Cliente);
                executacmd.Parameters.AddWithValue("@idven", devedor.Id_Venda);
                executacmd.Parameters.AddWithValue("@divida", devedor.Divida);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente Adicionado a Lista de Devedores!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Cliente Devedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Cadastrar Cliente Devedor: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornaDividaAtual
        public double RetornaDividaAtual(string idcliente, string idvenda)
        {
            try
            {
                string sql = @"SELECT Divida 
                                FROM tb_historico_devedores 
                                WHERE Cliente_Id=@idcli AND Venda_Id=@idven";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@idcli", idcliente);
                executacmd.Parameters.AddWithValue("@idven", idvenda);

                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    return rs.GetDouble("Divida");
                }
                else
                {
                    MessageBox.Show("Erro ao retornar a Dívida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao retornar a Dívida: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AtualizarDivida
        public bool AtualizarDivida(Devedores devedor)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_historico_devedores 
                            SET Divida=@dividas, Data_Atualizacao=@data, Data_Quitacao=@dataquit 
                            WHERE Cliente_Id=@idcli AND Venda_Id=@idven";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@dividas", devedor.Divida);
                executacmd.Parameters.AddWithValue("@idcli", devedor.Id_Cliente);
                executacmd.Parameters.AddWithValue("@idven", devedor.Id_Venda);
                executacmd.Parameters.AddWithValue("@data", devedor.Data_Atualizacao);
                executacmd.Parameters.AddWithValue("@dataquit", devedor.Data_Fim);

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
                MessageBox.Show($"Ocorreu um erro ao Alterar o Cliente Devedor: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarDevedores
        public DataTable ListarDevedores(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelaclientesdevedores = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                v.Id_Venda, 
                                c.Id_Cliente AS 'ID Cliente', 
                                c.Nome AS 'Nome Cliente', 
                                c.Cpf, 
	                            v.Total_Venda AS 'Total da Venda', 
                                v.Valor_Pago AS 'Valor Pago', 
                                hd.Divida_Inicial AS 'Dívida Inicial', 
                                hd.Divida_Atual AS 'Dívida Atual', 
                                hd.Data_Inicio_Divida AS 'Data de Início', 
                                hd.Data_Atualizacao AS 'Última Atualização', 
                                v.Observacoes AS 'Observações', 
                                c.Email, 
                                c.Numero AS 'Celular' 
                            FROM tb_historico_devedores hd
                            JOIN tb_clientes c ON c.Id_Cliente = hd.Cliente_Id
                            JOIN tb_vendas v ON v.Id_Venda = hd.Venda_Id
                            WHERE hd.Data_Quitacao IS NULL";
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

        #region ListarDevedoresQuitados
        public DataTable ListarDevedoresQuitados(Cliente cli)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelaclientesdevedores = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                v.Id_Venda, 
                                c.Id_Cliente AS 'ID Cliente', 
                                c.Nome AS 'Nome Cliente', 
                                c.Cpf, 
	                            v.Total_Venda AS 'Total da Venda', 
                                v.Valor_Pago AS 'Valor Pago', 
                                hd.Divida, 
                                hd.Data_Inicio_Divida AS 'Data de Início', 
                                hd.Data_Atualizacao AS 'Última Atualização', 
                                hd.Data_Quitacao AS 'Data de Quitação', 
                                v.Observacoes AS 'Observações', 
                                c.Email, 
                                c.Numero AS 'Celular' 
                            FROM tb_historico_devedores hd
                            JOIN tb_clientes c ON c.Id_Cliente = hd.Cliente_Id
                            JOIN tb_vendas v ON v.Id_Venda = hd.Venda_Id
                            WHERE hd.Data_Quitacao IS NOT NULL";
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
