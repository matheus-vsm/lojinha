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
    public class ItensCompraProdutosDAO
    {
        private MySqlConnection connection;

        public ItensCompraProdutosDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarItensCompra
        public void CadastrarItensCompra(ItensCompraProdutos item)
        {
            try
            {
                string sql = @"INSERT INTO tb_itenscompras (Compra_Id, Nome_Produto, 
                        Marca, Cor, Tamanho, Descricao, Qtd, Preco_Custo, Preco_Medio, Subtotal) 
                        VALUES (@idcompra, @nomeproduto, @marca, @cor, @tam, @desc, @qtde, @precust, 
                        @precmed, @sub)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@idcompra", item.Id_Compra);
                executacmd.Parameters.AddWithValue("@nomeproduto", item.Nome_Produto);
                executacmd.Parameters.AddWithValue("@marca", item.Marca);
                executacmd.Parameters.AddWithValue("@cor", item.Cor);
                executacmd.Parameters.AddWithValue("@tam", item.Tamanho);
                executacmd.Parameters.AddWithValue("@desc", item.Descricao);
                executacmd.Parameters.AddWithValue("@qtde", item.Quantidade);
                executacmd.Parameters.AddWithValue("@precust", item.Preco_Custo);
                executacmd.Parameters.AddWithValue("@precmed", item.Preco_Medio);
                executacmd.Parameters.AddWithValue("@sub", item.Subtotal);

                connection.Open();
                executacmd.ExecuteNonQuery();
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
