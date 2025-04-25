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
    public class CompraProdutosDAO
    {
        private MySqlConnection connection;

        public CompraProdutosDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCompra
        public bool CadastrarCompra(CompraProdutos compra)
        {
            try
            {
                string sql = @"INSERT INTO tb_compras (Total_Compra, Observacoes) 
                            VALUES (@total, @observacoes)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@total", compra.Total_Compra);
                executacmd.Parameters.AddWithValue("@observacoes", compra.Observacoes);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Compra Cadastrada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Compra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar a compra: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region RetornarIdLastCompra
        public string RetornarIdLastCompra()
        {
            try
            {
                string idcompra = "0";
                string sql = @"SELECT MAX(Id_Compra) Id_Compra FROM tb_compras";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    idcompra = rs.GetInt32("Id_Compra").ToString();
                    return idcompra;
                }
                else
                {
                    MessageBox.Show("Erro ao retornar o ID da Compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao retornar o ID da Compra." + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region ListarCompras
        public DataTable ListarCompras(CompraProdutos compra)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacompras = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Compra AS 'ID', 
                                Total_Compra AS 'Total da Compra', 
                                Data_Compra AS 'Data da Compra', 
                                Observacoes AS 'Observações' 
                                FROM tb_compras";

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacompras); //preenche o datatable

                return tabelacompras;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarCompras) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarComprasData
        public DataTable ListarComprasData(DateTime inicio, DateTime fim)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT 
                                Id_Compra AS 'ID', 
                                Total_Compra AS 'Total da Compra', 
                                Data_Compra AS 'Data da Compra', 
                                Observacoes AS 'Observações' 
                                FROM tb_compras
                                WHERE Data_Compra BETWEEN @inicio AND @fim";
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
                MessageBox.Show("Erro ao listar as Compras: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}
