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
    public class ProdutoDAO
    {
        private MySqlConnection connection;

        public ProdutoDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarProduto
        public bool CadastrarProduto(Produto prod)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"INSERT INTO tb_produtos 
                            (Nome_Produto, Marca, Cor, Tamanho, Descricao, 
                            Preco_Venda, Preco_Medio, Qtd_Estoque, Categoria_Prod_Id, 
                            Categoria_Publ_Id) VALUES 
                            (@nome, @marca, @cor, @tamanho, @descricao, 
                            @precovenda, @precomedio, @estoque, @prod, @pub)";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", prod.Nome);
                executacmd.Parameters.AddWithValue("@marca", prod.Marca);
                executacmd.Parameters.AddWithValue("@cor", prod.Cor);
                executacmd.Parameters.AddWithValue("@tamanho", prod.Tamanho);
                executacmd.Parameters.AddWithValue("@descricao", prod.Descricao);
                executacmd.Parameters.AddWithValue("@precovenda", prod.Preco_Venda);
                executacmd.Parameters.AddWithValue("@precomedio", prod.Preco_Medio);
                executacmd.Parameters.AddWithValue("@estoque", prod.Estoque);
                executacmd.Parameters.AddWithValue("@prod", prod.Id_Cat_Prod);
                executacmd.Parameters.AddWithValue("@pub", prod.Id_Cat_Pub);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Cadastrar o Produto: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarProdutos
        public DataTable ListarProdutos(Produto prod)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelaproduto = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                prod.Id_Produto AS 'ID', 
                                prod.Nome_Produto AS 'Nome', 
                                prod.Marca, 
                                prod.Cor, 
                                prod.Tamanho, 
                                prod.Preco_Venda, 
                                prod.Qtd_Estoque AS 'Estoque', 
                                catprod.Nome AS 'Categoria Produto', 
                                catpub.Nome AS 'Categoria Publico', 
                                prod.Descricao, 
                                prod.DataCadastro AS 'Data de Cadastro' 
                                
                                FROM tb_produtos AS prod
                                JOIN tb_categoria_produto AS catprod 
                                ON (prod.Categoria_Prod_Id = catprod.Id_Categoria_Prod)
                                JOIN tb_categoria_publico AS catpub 
                                ON (prod.Categoria_Publ_Id = catpub.Id_Categoria_Pub)";
                if (!string.IsNullOrEmpty(prod.Nome))
                {
                    sql += " WHERE prod.Nome_Produto LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(prod.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + prod.Nome + "%");
                }

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto); //preenche o datatable

                return tabelaproduto;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarProdutos) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region AlterarProduto
        public bool AlterarProduto(Produto prod)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_produtos SET 
                            Nome_Produto=@nome, Marca=@marca, Cor=@cor, Tamanho=@tamanho, 
                            Descricao=@descricao, Preco_Venda=@precovenda, Preco_Medio=@precomedio, 
                            Qtd_Estoque=@estoque, Categoria_Prod_Id=@prod, Categoria_Publ_Id=@pub
                            WHERE Id_Produto=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", prod.Nome);
                executacmd.Parameters.AddWithValue("@marca", prod.Marca);
                executacmd.Parameters.AddWithValue("@cor", prod.Cor);
                executacmd.Parameters.AddWithValue("@tamanho", prod.Tamanho);
                executacmd.Parameters.AddWithValue("@descricao", prod.Descricao);
                executacmd.Parameters.AddWithValue("@precovenda", prod.Preco_Venda);
                executacmd.Parameters.AddWithValue("@precomedio", prod.Preco_Medio);
                executacmd.Parameters.AddWithValue("@estoque", prod.Estoque);
                executacmd.Parameters.AddWithValue("@prod", prod.Id_Cat_Prod);
                executacmd.Parameters.AddWithValue("@pub", prod.Id_Cat_Pub);
                executacmd.Parameters.AddWithValue("@id", prod.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o Produto! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar o Produto: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ExcluirProduto
        public void ExcluirProduto(Produto prod)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"DELETE FROM tb_produtos WHERE Id_Produto=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", prod.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir o Produto: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarProduto
        public Produto RetornarProduto(int id)
        {
            try
            {
                string sql = @"SELECT * FROM tb_produtos WHERE Id_Produto = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.Id = rs.GetInt32("Id_Produto").ToString();
                    p.Descricao = rs.GetString("Descricao");
                    p.Preco_Venda = rs.GetDecimal("Preco");
                    p.Estoque = rs.GetInt32("Qtd_Estoque");

                    return p;
                }
                else
                {
                    MessageBox.Show("Nenhum Produto encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao retornar o Produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RemoverEstoque
        public void RemoverEstoque(string idprod, int qntdestoque)
        {
            try
            {
                string sql = @"UPDATE tb_produtos SET Qtd_Estoque = @qtd 
                            WHERE Id_Produto = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@qtd", qntdestoque);
                executacmd.Parameters.AddWithValue("@id", idprod);

                connection.Open();
                executacmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao remover o estoque: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AdicionarEstoque
        public void AdicionarEstoque(string idprod, int qntdestoque)
        {
            try
            {
                string sql = @"UPDATE tb_produtos SET Qtd_Estoque = @qtd 
                            WHERE Id_Produto = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@qtd", qntdestoque);
                executacmd.Parameters.AddWithValue("@id", idprod);

                connection.Open();
                executacmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao remover o estoque: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region RetornaEstoqueAtual
        public int RetornaEstoqueAtual(string idprod)
        {
            try
            {
                string sql = @"SELECT Qtd_Estoque FROM tb_produtos 
                                WHERE Id_Produto = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", idprod);

                connection.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if(rs.Read())
                {
                    return rs.GetInt32("Qtd_Estoque");
                }
                else
                {
                    MessageBox.Show("Erro ao retornar o estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao retornar o estoque: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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