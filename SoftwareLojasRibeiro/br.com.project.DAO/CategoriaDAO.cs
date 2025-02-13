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
                // Perguntar ao usuário antes de cadastrar
                DialogResult resultado = MessageBox.Show("Os dados para cadastro estão corretos? Deseja continuar?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //switch (qual)
                //{
                //    case "Produto":
                //        sql = @"INSERT INTO tb_categoria_produto 
                //                (Nome, Descricao) VALUES (@nome, @descricao)";
                //        break;
                //    case "Público":
                //        sql = @"INSERT INTO tb_categoria_publico 
                //                (Nome, Descricao) VALUES (@nome, @descricao)";
                //        break;
                //    default:
                //        throw new ArgumentException("Categoria Inválida!");
                //}
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

        #region ListarCategoriasProdutos
        public DataTable ListarCategoriasProdutos(Categoria cat)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacategoria = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT Id_Categoria_Prod as 'ID', Nome, 
                                Descricao, Data_Cadastro as 'Data de Cadastro' 
                                FROM tb_categoria_produto";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarCategoriasPublicos
        public DataTable ListarCategoriasPublicos(Categoria cat)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacategoria = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT Id_Categoria_Pub as 'ID', Nome, 
                                Descricao, Data_Cadastro as 'Data de Cadastro' 
                                FROM tb_categoria_publico";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os dados deste cliente?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", cancelar a operação
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_categoria_" + qual + @"SET 
                            Nome=@nome, Descricao=@descricao
                            WHERE Id_Categoria_Prod=@id";

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

        #region AlterarCategoriaPub
        public bool AlterarCategoriaPub(Categoria cat)
        {
            try
            {
                // Perguntar ao usuário antes de alterar
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os dados deste cliente?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", cancelar a operação
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_categoria_publico SET 
                            Nome=@nome, Descricao=@descricao
                            WHERE Id_Categoria_Publico=@id";

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

    }
}
