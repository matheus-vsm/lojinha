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
                                (Vendaa_Id, 
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

        #region RetornarPagamentos
        public List<Pagamento> RetornarPagamentos(string idvenda)
        {
            List<Pagamento> pagamentos = new List<Pagamento>();

            try
            {
                string sql = @"SELECT * FROM tb_pagamentos WHERE Vendaa_Id = @vendaid";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@vendaid", idvenda);

                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                while (rs.Read())
                {
                    Pagamento paga = new Pagamento
                    {
                        Id = rs.GetInt32("Id_Pagamento").ToString(),
                        Id_Venda = rs.GetInt32("Vendaa_Id").ToString(),
                        Forma_Pagamento = rs.GetString("Forma_Pagamento"),
                        Valor_Pago = rs.GetDouble("Valor_Pago")
                    };
                    pagamentos.Add(paga);
                }
                //if (pagamentos.Count == 0){ MessageBox.Show("Nenhuma Forma de Pagamento encontrada!");}
                return pagamentos;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu um erro: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
