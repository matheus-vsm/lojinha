﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
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
                    MessageBox.Show($"Produto '{prod.Nome}' Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                'Ativado' AS 'Status Produtos', 
                                prod.Nome_Produto AS 'Nome', 
                                prod.Marca, 
                                prod.Cor, 
                                prod.Tamanho, 
                                prod.Preco_Venda AS 'Preço', 
                                prod.Qtd_Estoque AS 'Estoque', 
                                'Ativado' AS 'Status Categoria Produtos', 
                                catprod.Nome AS 'Categoria Produto', 
                                'Ativado' AS 'Status Categoria Público',                                 
                                catpub.Nome AS 'Categoria Publico', 
                                prod.Descricao AS 'Descrição', 
                                prod.DataCadastro AS 'Data de Cadastro' 
                                
                                FROM tb_produtos AS prod
                                JOIN tb_categoria_produto AS catprod 
                                ON (prod.Categoria_Prod_Id = catprod.Id_Categoria_Prod)
                                JOIN tb_categoria_publico AS catpub 
                                ON (prod.Categoria_Publ_Id = catpub.Id_Categoria_Pub)
                                WHERE prod.Status = TRUE";
                if (!string.IsNullOrEmpty(prod.Nome))
                {
                    sql += " AND prod.Nome_Produto LIKE @nome";
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

        #region ListarProdutosDesativados
        public DataTable ListarProdutosDesativados(Produto prod)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelaproduto = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                prod.Id_Produto AS 'ID', 
                                'Desativado' AS 'Status Produtos', 
                                prod.Nome_Produto AS 'Nome', 
                                prod.Marca, 
                                prod.Cor, 
                                prod.Tamanho, 
                                prod.Preco_Venda AS 'Preço', 
                                prod.Qtd_Estoque AS 'Estoque', 
                                'Desativado' AS 'Status Produtos', 
                                catprod.Nome AS 'Categoria Produto', 
                                'Desativado' AS 'Status Produtos',                                 
                                catpub.Nome AS 'Categoria Publico', 
                                prod.Descricao AS 'Descrição', 
                                prod.DataCadastro AS 'Data de Cadastro' 
                                
                                FROM tb_produtos AS prod
                                JOIN tb_categoria_produto AS catprod 
                                ON (prod.Categoria_Prod_Id = catprod.Id_Categoria_Prod)
                                JOIN tb_categoria_publico AS catpub 
                                ON (prod.Categoria_Publ_Id = catpub.Id_Categoria_Pub)
                                WHERE prod.Status = FALSE";
                if (!string.IsNullOrEmpty(prod.Nome))
                {
                    sql += " AND prod.Nome_Produto LIKE @nome";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarProdutosDesativados) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Perguntar ao usuário antes de alterar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os Dados deste Produto?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", cancelar a operação
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
                    p.Preco_Venda = rs.GetDecimal("Preco_Venda");
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

                if (rs.Read())
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

        #region CadastrarProdutoNaCompra
        public bool CadastrarProdutoNaCompra(Produto prod)
        {
            try
            {
                connection.Open();

                string sql = @"SELECT Id_Produto, Qtd_Estoque 
                               FROM tb_produtos 
                               WHERE Nome_Produto = @nome AND 
                                     Marca = @marca AND 
                                     Cor = @cor AND 
                                     Tamanho = @tamanho";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", prod.Nome);
                executacmd.Parameters.AddWithValue("@marca", prod.Marca);
                executacmd.Parameters.AddWithValue("@cor", prod.Cor);
                executacmd.Parameters.AddWithValue("@tamanho", prod.Tamanho);

                int idProduto = 0;
                int quantidadeAtual = 0;

                using (var reader = executacmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idProduto = reader.GetInt32("Id_Produto");
                        quantidadeAtual = reader.GetInt32("Qtd_Estoque");
                    }
                }

                // Se encontrou o produto, atualiza o estoque
                if (idProduto > 0)
                {
                    int novaQuantidade = quantidadeAtual + prod.Estoque;

                    string updateSql = @"UPDATE tb_produtos 
                                         SET Qtd_Estoque = @novoestoque 
                                         WHERE Id_Produto = @idProduto";

                    MySqlCommand updateCmd = new MySqlCommand(updateSql, connection);
                    updateCmd.Parameters.AddWithValue("@novoestoque", novaQuantidade);
                    updateCmd.Parameters.AddWithValue("@idProduto", idProduto);

                    int linhasAfetadas = updateCmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show($"Produto '{prod.Nome}' Atualizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar Produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    // Produto não encontrado, cadastrar novo
                    connection.Close(); // Fecha para reabrir dentro de CadastrarProduto
                    bool verificacao = CadastrarProduto(prod);

                    if (verificacao)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

        #region AtivarProduto
        public bool AtivarProduto(Produto prod)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_produtos SET 
                            Status = TRUE 
                            WHERE Id_Produto=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", prod.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto Ativado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Ativar o Produto! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Ativar o Produto: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region DesativarProduto
        public bool DesativarProduto(Produto prod)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_produtos SET 
                            Status = FALSE 
                            WHERE Id_Produto=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", prod.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto Desativado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Desativar o Produto! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Desativar o Produto: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion
    }
}