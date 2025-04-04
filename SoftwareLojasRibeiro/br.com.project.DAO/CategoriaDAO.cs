using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using Org.BouncyCastle.Utilities;
using System.Data;
using System.Net.Http.Headers;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class CategoriaDAO
    {
        private MySqlConnection connection;

        public CategoriaDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCategoria
        public bool CadastrarCategoria(Categoria cat, string qual)
        {
            try
            {
                string sql = @"INSERT INTO tb_categoria_" + qual +  
                                "(Nome, Descricao) VALUES (@nome, @descricao)";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", cat.Nome);
                executacmd.Parameters.AddWithValue("@descricao", cat.Descricao);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Categoria Cadastrada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Cadastrar a Categoria: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarCategorias
        public DataTable ListarCategorias(Categoria cat, string qual)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacategoria = new DataTable();
                string qual2 = (qual == "Produto") ? "Prod" : "Pub";
                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT Id_Categoria_" + qual2 + @" as 'ID', Nome, 
                                Descricao, Data_Cadastro as 'Data de Cadastro' 
                                FROM tb_categoria_" + qual;
                if (!string.IsNullOrEmpty(cat.Nome))
                {
                    sql += " WHERE Nome LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(cat.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + cat.Nome + "%");
                }

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacategoria); //preenche o datatable

                return tabelacategoria;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarCategorias) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarNomeCategorias
        public DataTable ListarNomeCategorias(string qual)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacategoria = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT * FROM tb_categoria_" + qual;

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacategoria); //preenche o datatable

                return tabelacategoria;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarNomeCategorias) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarNomeCat
        public string RetornarNomeCat(string qual, int id)
        {
            try
            {
                string resultado = string.Empty;
                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT * FROM tb_categoria_" + qual + 
                             @" WHERE Id_Categoria_" + qual + @" = @id";

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read()) //encontrou algo
                {
                    resultado = rs.GetString("Nome");
                    return resultado;
                }
                else
                {
                    MessageBox.Show("Categoria não encontrada!");
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (RetornarNomeCat) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarIdCat
        public int RetornarIdCat(string qual, string nome)
        {
            try
            {
                int resultado = 0;
                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT * FROM tb_categoria_" + qual +
                             @" WHERE Nome=@nome";

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", nome);

                connection.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read()) //encontrou algo
                {
                    if (qual == "publico")
                    {
                        qual = "Pub";
                    }
                    else
                    {
                        qual = "Prod";
                    }
                    resultado = rs.GetInt32($"Id_Categoria_{qual}");
                    return resultado;
                }
                else
                {
                    MessageBox.Show("Categoria não encontrada!");
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (RetornarNomeCat) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion


        #region AlterarCategoria
        public bool AlterarCategoria(Categoria cat, string qual)
        {
            try
            {
                // Perguntar ao usuário antes de alterar
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os dados desta Categoria?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", cancelar a operação
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string qual2 = (qual == "Produto") ? "Prod" : "Pub";

                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_categoria_" + qual + @" SET 
                            Nome=@nome, Descricao=@descricao 
                            WHERE Id_Categoria_" + qual2 + "=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", cat.Nome);
                executacmd.Parameters.AddWithValue("@descricao", cat.Descricao);
                executacmd.Parameters.AddWithValue("@id", cat.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Categoria Alterada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Categoria! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar a Categoria: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ExcluirCategoria
        public void ExcluirCategoria(Categoria cat, string qual)
        {
            try
            {
                // Perguntar ao usuário antes de excluir
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta Categoria?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", a função retorna e não executa a exclusão
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string qual2 = (qual == "Produto") ? "Prod" : "Pub";
                //Definir comando SQL - INSERT INTO
                string sql = @"DELETE FROM tb_categoria_" + qual + 
                            @" WHERE Id_categoria_" + qual2 + "=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", cat.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir a Categoria: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion
    }
}
