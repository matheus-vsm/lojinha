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
                string sql = @"INSERT INTO tb_compras (Fornecedor_Id, 
                            Nome_Produto, Total_Compra, Observacoes) 
                            VALUES (@fornecedor, @prod, @total, 
                            @observacoes)";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@fornecedor", compra.Id_Fornecedor);
                executacmd.Parameters.AddWithValue("@prod", compra.Nome_Produto);
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
                                comp.Id_Compra AS 'ID', 
                                forn.Nome AS 'Fornecedor', 
                                comp.Nome_Produto AS 'Nome do Produto', 
                                itens.Qtd AS 'Quantidade',
                                comp.Total_Compra AS 'Total da Compra', 
                                comp.Observacoes,
                                comp.Data_Compra AS 'Data da Compra'
                                
                                FROM tb_compras AS comp
                                JOIN tb_fornecedores AS forn
                                ON (forn.Id_Fornecedor = comp.Fornecedor_Id)
                                JOIN tb_itenscompras as itens
                                ON (itens.Compra_Id = comp.Id_Compra)";
                if (!string.IsNullOrEmpty(compra.Nome_Produto))
                {
                    sql += " WHERE comp.Nome_Produto LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(compra.Nome_Produto))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + compra.Nome_Produto + "%");
                }

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

    }
}
