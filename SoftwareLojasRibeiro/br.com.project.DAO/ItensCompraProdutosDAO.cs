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
                string sql = @"INSERT INTO tb_itenscompras (Compra_Id, Fornecedor_Id, Nome_Produto, 
                        Marca, Cor, Tamanho, Descricao, Qtd, Categoria_Prod_Id, Categoria_Publ_Id, 
                        Preco_Custo, Preco_Medio, Subtotal) 
                        VALUES (@idcompra, @idfornecedor, @nomeproduto, @marca, @cor, @tam, @desc, 
                        @qtde, @catprod, @catpub, @precust, @precmed, @sub)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@idcompra", item.Id_Compra);
                executacmd.Parameters.AddWithValue("@idfornecedor", item.Id_Fornecedor);
                executacmd.Parameters.AddWithValue("@nomeproduto", item.Nome_Produto);
                executacmd.Parameters.AddWithValue("@marca", item.Marca);
                executacmd.Parameters.AddWithValue("@cor", item.Cor);
                executacmd.Parameters.AddWithValue("@tam", item.Tamanho);
                executacmd.Parameters.AddWithValue("@desc", item.Descricao);
                executacmd.Parameters.AddWithValue("@qtde", item.Quantidade);
                executacmd.Parameters.AddWithValue("@catprod", item.Id_Cat_Prod);
                executacmd.Parameters.AddWithValue("@catpub", item.Id_Cat_Publ);
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

        #region ListarItensCompra
        public DataTable ListarItensCompra(string idvenda)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT 
                                c.Id_Compra AS 'ID Compra',
                                ic.Id_Item_Compra AS 'ID Item Compra', 
                                f.Nome AS 'Fornecedor', 
		                        ic.Nome_Produto as 'Produto', 
                                ic.Marca, 
                                ic.Cor,
                                ic.Tamanho,
                                ic.Descricao AS 'Descrição', 
                                cprod.Nome AS 'Categoria Produto',
                                cpub.Nome AS 'Categoria Publico',
                                ic.Qtd AS 'Quantidade', 
                                ic.Preco_Custo AS 'Preço de Custo', 
                                ic.Subtotal AS 'SubTotal' 
                            FROM tb_itenscompras AS ic 
                            JOIN tb_compras AS c ON (ic.Compra_Id = c.Id_Compra) 
                            JOIN tb_fornecedores AS f ON (ic.Fornecedor_Id = f.Id_Fornecedor) 
                            JOIN tb_categoria_produto AS cprod ON (ic.Categoria_Prod_Id = cprod.Id_Categoria_Prod)
                            JOIN tb_categoria_publico AS cpub ON (ic.Categoria_Publ_Id = cpub.Id_Categoria_Pub)
                            WHERE ic.Compra_Id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", idvenda);

                connection.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao listar os itens da venda: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
