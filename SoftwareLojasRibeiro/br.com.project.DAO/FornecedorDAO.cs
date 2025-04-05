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
    public class FornecedorDAO
    {
        private readonly MySqlConnection connection;

        public FornecedorDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastroFornecedor

        public bool CadastrarFornecedor(Fornecedor Forn)
        {
            try
            {
                // Perguntar ao usuário antes de cadastrar
                DialogResult resultado = MessageBox.Show("Os Dados para Cadastrar estão corretos? Deseja Continuar",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Definir comando SQL - INSERT INTO
                string sql = @"INSERT INTO tb_fornecedores
                      (Nome, Cnpj, Email, Telefone, Celular, Cep, Endereco) VALUES 
                      (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco)";

                // Organizar o comando SQL
                using (MySqlCommand executacmd = new MySqlCommand(sql, connection))
                {
                    executacmd.Parameters.AddWithValue("@nome", Forn.Nome);
                    executacmd.Parameters.AddWithValue("@cnpj", Forn.Cnpj);
                    executacmd.Parameters.AddWithValue("@email", Forn.Email);
                    executacmd.Parameters.AddWithValue("@celular", Forn.Celular);
                    executacmd.Parameters.AddWithValue("@telefone", Forn.Telefone);
                    executacmd.Parameters.AddWithValue("@endereco", Forn.Endereco);
                    executacmd.Parameters.AddWithValue("@cep", Forn.Cep);

                    // Abrir conexão e executar o comando SQL
                    connection.Open();
                    int linhasAfetadas = executacmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Cadastrar o Fornecedor: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }

        #endregion

        #region ListarFornecedores

        public DataTable ListarFornecedores(Fornecedor Forn)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacliente = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT Id_Fornecedor as 'ID', Nome, 
                               Cnpj, Email, Telefone, Celular,
                               Endereco, Cep FROM tb_fornecedores";
                if (!string.IsNullOrEmpty(Forn.Nome))
                {
                    sql += " WHERE Nome LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(Forn.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + Forn.Nome + "%");
                }

                connection.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente); //preenche o datatable

                return tabelacliente;
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

        #region AlterarForncedor
        public bool AlterarFornecedor(Fornecedor Forn)
        {
            try
            {
                // Perguntar ao usuário antes de alterar
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os dados deste Fornecedor?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", cancelar a operação
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Definir comando SQL - UPDATE
                string sql = @"UPDATE tb_fornecedores SET 
                      Nome=@nome, Cnpj=@cnpj, Email=@email, Telefone=@telefone, Celular=@celular, 
                      Cep=@cep, Endereco=@endereco 
                      WHERE Id_Fornecedor=@id";

                // Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", Forn.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", Forn.Cnpj);
                executacmd.Parameters.AddWithValue("@email", Forn.Email);
                executacmd.Parameters.AddWithValue("@celular", Forn.Celular);
                executacmd.Parameters.AddWithValue("@telefone", Forn.Telefone);
                executacmd.Parameters.AddWithValue("@endereco", Forn.Endereco);
                executacmd.Parameters.AddWithValue("@cep", Forn.Cep);
                executacmd.Parameters.AddWithValue("@id", Forn.Id);

                // Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Fornecedor Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Fornecedor! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar o fornecedor: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region Excluir Fornecedor

        public void ExcluirFornecedor(Fornecedor Forn)
        {
            try
            {
                // Perguntar ao usuário antes de excluir
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este Fornecedor?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                // Se o usuário clicar em "Não", a função retorna e não executa a exclusão
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Definir comando SQL - INSERT INTO
                string sql = @"DELETE FROM tb_Fornecedores WHERE Id_Fornecedor=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", Forn.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir o Fornecedor: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarFornecedoresCombo
        public DataTable ListarFornecedoresCombo()
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelacategoria = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT * FROM tb_fornecedores";

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
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarFornecedoresCombo) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarIdFornecedor
        public int RetornarIdFornecedor(string nome)
        {
            try
            {
                int resultado = 0;
                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT * FROM tb_fornecedores WHERE Nome=@nome";

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", nome);

                connection.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read()) //encontrou algo
                {
                    resultado = rs.GetInt32($"Id_Fornecedor");
                    return resultado;
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrada!");
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (RetornarIdFornecedor) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion
    }
}