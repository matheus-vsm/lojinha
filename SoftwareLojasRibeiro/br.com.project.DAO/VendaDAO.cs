using System;
using System.Collections.Generic;
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
                            Total_Venda, Desconto, Forma_Pagamento, Valor_Pago, Status, Observacoes) 
                            VALUES (@id, @data, @total, @desconto, @pagamento, 
                            @valor, @status, @observacoes)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", ven.Id_Cliente);
                executacmd.Parameters.AddWithValue("@data", ven.Data_Venda);
                executacmd.Parameters.AddWithValue("@total", ven.Total_Venda);
                executacmd.Parameters.AddWithValue("@desconto", ven.Desconto);
                executacmd.Parameters.AddWithValue("@pagamento", ven.Forma_Pagamento);
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
                MessageBox.Show("Erro ao retornar o ID da Venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
