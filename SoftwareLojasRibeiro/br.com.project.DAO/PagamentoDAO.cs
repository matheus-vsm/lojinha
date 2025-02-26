using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class PagamentoDAO
    {
        private MySqlConnection connection;

        public PagamentoDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarPagamento
        public void CadastrarPagamento(Pagamento paga)
        {
            try
            {
                string sql = @"INSERT INTO tb_pagamentos 
                                (Venda_Id, 
                                Forma_Pagamento, 
                                Valor_Pago) 
                            VALUES (@venda, @forma, @valor)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@venda", paga.Id_Venda);
                executacmd.Parameters.AddWithValue("@forma", paga.Forma_Pagamento);
                executacmd.Parameters.AddWithValue("@valor", paga.Valor_Pago);

                connection.Open();
                executacmd.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar o pagamento: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
