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
    public class ItensVendaDAO
    {
        private MySqlConnection connection;

        public ItensVendaDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarItemsVenda
        public void CadastrarItemsVenda(ItensVenda item)
        {
            try
            {
                string sql = @"INSERT INTO tb_itens_venda (Venda_Id, Produto_Id, 
                        Qtd, Preco_Unitario, Subtotal) 
                        VALUES (@venda, @produto, @qntd, @preco, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@venda", item.Id_Venda);
                executacmd.Parameters.AddWithValue("@produto", item.Id_Produto);
                executacmd.Parameters.AddWithValue("@qntd", item.Quantidade);
                executacmd.Parameters.AddWithValue("@preco", item.Preco_Unitario);
                executacmd.Parameters.AddWithValue("@subtotal", item.Subtotal);

                connection.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Item cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar o item: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
