﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
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

        #region CadastrarItensVenda
        public void CadastrarItensVenda(ItensVenda item)
        {
            try
            {
                string sql = @"INSERT INTO tb_itensvendas (Venda_Id, Produto_Id, 
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

        #region ListarItensVenda
        public DataTable ListarItensVenda(string idvenda)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT 
                                v.Id_Venda AS 'ID Venda',
                                it.Id_Item_Venda AS 'ID Item Venda', 
		                        p.Nome_Produto as 'Produto', 
                                it.Qtd AS 'Quantidade', 
                                p.Preco_Venda AS 'Preço Unitário (R$)', 
                                it.Subtotal AS 'SubTotal (R$)' 
                            FROM tb_itensvendas AS it 
                            JOIN tb_produtos AS p ON (it.Produto_Id = p.Id_Produto) 
                            JOIN tb_vendas AS v ON (it.Venda_Id = v.Id_Venda)
                            WHERE it.Venda_Id = @id";

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
