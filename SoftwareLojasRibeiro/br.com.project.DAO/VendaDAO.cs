using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class VendaDAO
    {
        private MySqlConnection connection;

        public VendaDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarVenda
        public void CadastrarVenda(Venda ven)
        {
            try
            {
                string sql = @"INSERT INTO tb_vendas (Cliente_Id, Data_Venda, 
                            Total_Venda, Desconto, Valor_Pago, Status, Observacoes) 
                            VALUES (@id, @data, @total, @desconto, 
                            @valor, @status, @observacoes)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", ven.Id_Cliente);
                executacmd.Parameters.AddWithValue("@data", ven.Data_Venda);
                executacmd.Parameters.AddWithValue("@total", ven.Total_Venda);
                executacmd.Parameters.AddWithValue("@desconto", ven.Desconto);
                executacmd.Parameters.AddWithValue("@valor", ven.Valor_Pago);
                executacmd.Parameters.AddWithValue("@status", ven.Status);
                executacmd.Parameters.AddWithValue("@observacoes", ven.Observacoes);

                connection.Open();
                executacmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar a venda: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region RetornarIdLastVenda
        public string RetornarIdLastVenda()
        {
            try
            {
                string idvenda = "0";
                string sql = @"SELECT MAX(Id_Venda) Id_Venda FROM tb_vendas";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("Id_Venda").ToString();
                    return idvenda;
                }
                else
                {
                    MessageBox.Show("Erro ao retornar o ID da Venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao retornar o ID da Venda." + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region ListarVendas
        public DataTable ListarVendas(DateTime inicio, DateTime fim)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT 
                                v.Id_Venda AS 'ID', 
                                c.Nome AS 'Cliente', 
                                v.Data_Venda AS 'Data da Venda', 
                                v.Total_Venda AS 'Total (R$)', 
                                v.Desconto AS 'Desconto (R$)', 
                                v.Valor_Pago AS 'Valor Pago (R$)', 
                                v.Status, 
                                v.Observacoes 
                            FROM tb_vendas AS v 
                            INNER JOIN tb_clientes AS c ON (v.Cliente_Id=c.Id_Cliente) 
                            WHERE v.Data_Venda BETWEEN @inicio AND @fim";
                //adicioar o PAGAMENTO fazendo JOIN com a tabela de pagamentos
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                executacmd.Parameters.AddWithValue("@inicio", inicio);
                executacmd.Parameters.AddWithValue("@fim", fim);

                connection.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao listar as vendas: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region ListarTodasVendas
        public DataTable ListarTodasVendas()
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT 
                                v.Id_Venda AS 'ID', 
                                c.Nome AS 'Cliente', 
                                v.Data_Venda AS 'Data da Venda', 
                                v.Total_Venda AS 'Total (R$)', 
                                v.Desconto AS 'Desconto (R$)', 
                                v.Valor_Pago AS 'Valor Pago (R$)', 
                                v.Status, 
                                v.Observacoes 
                            FROM tb_vendas AS v 
                            JOIN tb_clientes AS c ON (v.Cliente_Id=c.Id_Cliente)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                connection.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao listar as vendas: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AtualizarStatusVenda
        public bool AtualizarStatusVenda(Devedores devedor)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_vendas 
                            SET Status='Concluída' 
                            WHERE Cliente_Id=@idcli AND Id_Venda=@idven";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@idcli", devedor.Id_Cliente);
                executacmd.Parameters.AddWithValue("@idven", devedor.Id_Venda);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Dívida quitada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Status da Venda! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar o Status da Venda: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion
    }
}
