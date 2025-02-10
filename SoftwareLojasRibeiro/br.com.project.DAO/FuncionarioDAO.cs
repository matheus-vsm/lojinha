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
    public class FuncionarioDAO
    {
        private MySqlConnection connection;

        public FuncionarioDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFuncionario
        public bool CadastrarFuncionario(Funcionario func)
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

                string sql = @"INSERT INTO tb_funcionarios 
                            (Nome, Rg, Cpf, Email, Numero, 
                            Datanasc, Endereco, Login, Senha, Tipo_Usuario, Cep) 
                            VALUES 
                            (@nome, @rg, @cpf, @email, @numero, 
                            @datanasc, @endereco, @login, @senha, @tipo, @cep)";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", func.Nome);
                executacmd.Parameters.AddWithValue("@rg", func.Rg);
                executacmd.Parameters.AddWithValue("@cpf", func.Cpf);
                executacmd.Parameters.AddWithValue("@email", func.Email);
                executacmd.Parameters.AddWithValue("@numero", func.Numero);
                executacmd.Parameters.AddWithValue("@datanasc", func.Datanasc);
                executacmd.Parameters.AddWithValue("@endereco", func.Endereco);
                executacmd.Parameters.AddWithValue("@login", func.Login);
                executacmd.Parameters.AddWithValue("@senha", Helpers.HashSenha(func.Senha)); // Criptografa a senha
                executacmd.Parameters.AddWithValue("@tipo", func.Tipo);
                executacmd.Parameters.AddWithValue("@cep", func.Cep);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Funcionário Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Cadastrar o funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region ListarFuncionarios
        public DataTable ListarFuncionarios(Funcionario func)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelafuncionario = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT Id_Funcionario as ID, Nome, Login, Tipo_Usuario as 
                                'Tipo de Usuário', Data_Cadastro as 'Data Cadastro', Email, 
                                Rg, Cpf, Numero, Datanasc as 'Data de Nascimento', 
                                Endereco, Cep
                                FROM tb_funcionarios";
                //string sql = "SELECT * FROM tb_funcionarios";
                if (!string.IsNullOrEmpty(func.Nome))
                {
                    sql += " WHERE Nome LIKE @nome";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um nome para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(func.Nome))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + func.Nome + "%");
                }

                connection.Open();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario); //preenche o datatable

                return tabelafuncionario;
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

        #region ObterSenhaFuncionario
        public string ObterSenhaFuncionario(string idFuncionario)
        {
            try
            {
                string sql = "SELECT Senha FROM tb_funcionarios WHERE Id_Funcionario = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", idFuncionario);

                connection.Open();
                object resultado = executacmd.ExecuteScalar(); // Retorna um único valor

                return resultado != null ? resultado.ToString() : string.Empty;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao obter a senha do funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AlterarFuncionario
        public bool AlterarFuncionario(Funcionario func)
        {
            try
            {
                // Perguntar ao usuário antes de alterar
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar os dados deste funcionário?",
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
                string sql = @"UPDATE tb_funcionarios SET 
                            Nome=@nome, Rg=@rg, Cpf=@cpf, Email=@email, Numero=@numero, 
                            Datanasc=@datanasc, Endereco=@endereco, Login=@login, Senha=@senha, 
                            Tipo_Usuario=@tipo, Cep=@cep 
                            WHERE Id_Funcionario=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@nome", func.Nome);
                executacmd.Parameters.AddWithValue("@rg", func.Rg);
                executacmd.Parameters.AddWithValue("@cpf", func.Cpf);
                executacmd.Parameters.AddWithValue("@email", func.Email);
                executacmd.Parameters.AddWithValue("@numero", func.Numero);
                executacmd.Parameters.AddWithValue("@datanasc", func.Datanasc);
                executacmd.Parameters.AddWithValue("@endereco", func.Endereco);
                executacmd.Parameters.AddWithValue("@login", func.Login);
                executacmd.Parameters.AddWithValue("@senha", func.Senha);
                executacmd.Parameters.AddWithValue("@tipo", func.Tipo);
                executacmd.Parameters.AddWithValue("@cep", func.Cep);
                executacmd.Parameters.AddWithValue("@id", func.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Funcionário Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar funcionário! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Alterar o Funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ExcluirFuncionario
        public void ExcluirFuncionario(Funcionario func)
        {
            try
            {
                // Perguntar ao usuário antes de excluir
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
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
                string sql = @"DELETE FROM tb_funcionarios WHERE Id_Funcionario=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", func.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir o funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
