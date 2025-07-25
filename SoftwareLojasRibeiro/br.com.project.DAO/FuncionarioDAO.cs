﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using SoftwareLojasRibeiro.br.com.project.VIEW;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class FuncionarioDAO
    {
        private MySqlConnection connection;

        public FuncionarioDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }

        #region ValidarSenha
        public bool ValidarSenha(Funcionario func)
        {
            if (string.IsNullOrEmpty(func.Senha)) return false;

            // Remove todos os espaços em branco da senha
            string senhaSemEspacos = func.Senha.Replace(" ", "");

            // Verifica se a senha tem pelo menos 12 caracteres (sem espaços)
            if (senhaSemEspacos.Length < 12) return false;

            bool temMaiuscula = func.Senha.Any(char.IsUpper);
            bool temMinuscula = func.Senha.Any(char.IsLower);
            bool temNumero = func.Senha.Any(char.IsDigit);
            bool temEspecial = func.Senha.Any(ch => !char.IsLetterOrDigit(ch));

            return temMaiuscula && temMinuscula && temNumero && temEspecial;
        }
        #endregion

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
                string sql = @"SELECT 
                                Id_Funcionario as ID, 
                                'Ativado' AS Status, 
                                Nome, 
                                Login, 
                                Tipo_Usuario as 'Tipo de Usuário', 
                                Data_Cadastro as 'Data de Cadastro', 
                                Cpf, 
                                Email, 
                                Rg, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_funcionarios
                                WHERE Status = TRUE";

                if (!string.IsNullOrEmpty(func.Nome))
                {
                    sql += " AND Nome LIKE @nome";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarFuncionarios) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarFuncionariosCpf
        public DataTable ListarFuncionariosCpf(Funcionario func)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelafuncionario = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Funcionario as ID, 
                                'Ativado' AS Status, 
                                Nome, 
                                Login, 
                                Tipo_Usuario as 'Tipo de Usuário', 
                                Data_Cadastro as 'Data de Cadastro', 
                                Cpf, 
                                Email, 
                                Rg, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_funcionarios
                                WHERE Status = TRUE";

                if (!string.IsNullOrEmpty(func.Cpf))
                {
                    sql += " AND Cpf LIKE @Cpf";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um Cpf para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(func.Cpf))
                {
                    executacmd.Parameters.AddWithValue("@Cpf", "%" + func.Cpf + "%");
                }

                connection.Open();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario); //preenche o datatable

                return tabelafuncionario;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarFuncionariosCpf) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarFuncionariosDesativados
        public DataTable ListarFuncionariosDesativados(Funcionario func)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelafuncionario = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Funcionario as ID, 
                                'Desativado' AS Status, 
                                Nome, 
                                Login, 
                                Tipo_Usuario as 'Tipo de Usuário', 
                                Data_Cadastro as 'Data de Cadastro', 
                                Cpf, 
                                Email, 
                                Rg, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_funcionarios
                                WHERE Status = FALSE";

                if (!string.IsNullOrEmpty(func.Nome))
                {
                    sql += " AND Nome LIKE @nome";
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
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarFuncionariosDesativados) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region ListarFuncionariosDesativadosCpf
        public DataTable ListarFuncionariosDesativadosCpf(Funcionario func)
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabelafuncionario = new DataTable();

                // Se o nome for informado, adicionamos um filtro na consulta
                string sql = @"SELECT 
                                Id_Funcionario as ID, 
                                'Desativado' AS Status, 
                                Nome, 
                                Login, 
                                Tipo_Usuario as 'Tipo de Usuário', 
                                Data_Cadastro as 'Data de Cadastro', 
                                Cpf, 
                                Email, 
                                Rg, 
                                Numero, 
                                Datanasc as 'Data de Nascimento', 
                                Cep, 
                                Endereco AS 'Endereço' 
                                FROM tb_funcionarios
                                WHERE Status = FALSE";

                if (!string.IsNullOrEmpty(func.Cpf))
                {
                    sql += " AND Cpf LIKE @Cpf";
                }

                //Organizar o comando SQL e executar
                MySqlCommand executacmd = new MySqlCommand(sql, connection);

                // Se houver um Cpf para buscar, adicionamos o parâmetro
                if (!string.IsNullOrEmpty(func.Cpf))
                {
                    executacmd.Parameters.AddWithValue("@Cpf", "%" + func.Cpf + "%");
                }

                connection.Open();

                //Criar o MySQLDataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario); //preenche o datatable

                return tabelafuncionario;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (ListarFuncionariosDesativadosCpf) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string sql = @"SELECT Senha 
                                FROM tb_funcionarios 
                                WHERE Id_Funcionario = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", idFuncionario);

                connection.Open();
                object resultado = executacmd.ExecuteScalar(); // Retorna um único valor

                return resultado != null ? resultado.ToString() : string.Empty;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao obter a senha do Funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Obter a senha atual do banco
                string senhaAtualBanco = ObterSenhaFuncionario(func.Id.ToString());

                // Se a senha foi alterada, criptografamos a nova senha
                string senhaParaSalvar = func.Senha;
                if (!string.IsNullOrEmpty(senhaAtualBanco) && !BCrypt.Net.BCrypt.Verify(func.Senha, senhaAtualBanco))
                {
                    senhaParaSalvar = Helpers.HashSenha(func.Senha); // Criptografa apenas se a senha foi alterada
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
                executacmd.Parameters.AddWithValue("@senha", senhaParaSalvar); // Senha correta
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
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Funcionário?",
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

        #region AtivarFuncionario
        public bool AtivarFuncionario(Funcionario func)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_funcionarios SET 
                            Status = TRUE 
                            WHERE Id_Funcionario=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", func.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Funcionário Ativado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Ativar o Funcionário! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Ativar o Funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region DesativarFuncionario
        public bool DesativarFuncionario(Funcionario func)
        {
            try
            {
                //Definir comando SQL - INSERT INTO
                string sql = @"UPDATE tb_funcionarios SET 
                            Status = FALSE 
                            WHERE Id_Funcionario=@id";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@id", func.Id);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                int linhasAfetadas = executacmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Funcionário Desativado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao Desativar o Funcionário! Nenhuma linha foi modificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro ao Desativar o Funcionário: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetornarIdLoginUsuario
        public string RetornarIdLoginUsuario(Funcionario func)
        {
            try
            {
                Funcionario funci = new Funcionario();
                string id;

                string sql = @"SELECT * FROM tb_funcionarios WHERE Login = @login";

                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@Login", func.Login);

                connection.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read()) //encontrou algo
                {
                    id = rs.GetInt32("Id_Funcionario").ToString(); //resgata o valor da coluna ID como int e converte para string
                    return id;
                }
                else
                {
                    MessageBox.Show("Funcionario Não Encontrado!");
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu um erro: " + error);
                return null;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region Login
        public bool Login(Funcionario func)
        {
            try
            {
                string sql = @"SELECT * 
                                FROM tb_funcionarios 
                                WHERE Login=@login AND Senha=@senha";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@login", func.Login);
                executacmd.Parameters.AddWithValue("@senha", func.Senha);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    string nivel = reader.GetString("Tipo_Usuario").ToString();
                    string nome = reader.GetString("Nome").ToString();
                    string user = reader.GetString("Login").ToString();

                    MessageBox.Show($"Login Realizado!\nNome: {nome}\nUsuário: {func.Login}\n" +
                        $"Tipo de Usuário: {nivel}");

                    FormMenu telamenu = new FormMenu();
                    telamenu.toolStripStatusLabelUsuario.Text = user;
                    telamenu.toolStripStatusLabelTipoUsuario.Text = nivel;

                    if (nivel.Equals("ADMIN"))
                    {
                        telamenu.Show();
                    }
                    else if (nivel.Equals("NORMAL"))
                    {
                        telamenu.Show();
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Login ou Senha Inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (Login) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close(); // Sempre fechar a conexão
            }
        }
        #endregion

        #region RetorndarDadosUsuarioLogado
        public Funcionario RetorndarDadosUsuarioLogado(Funcionario func)
        {
            try
            {
                Funcionario funcionariozin = new Funcionario();

                string sql = @"SELECT * 
                                FROM tb_funcionarios 
                                WHERE Login=@login AND Senha=@senha";

                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, connection);
                executacmd.Parameters.AddWithValue("@login", func.Login);
                executacmd.Parameters.AddWithValue("@senha", func.Senha);

                //Abrir conexão e executar o comando SQL
                connection.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    funcionariozin.Tipo = reader.GetString("Tipo_Usuario").ToString();
                    funcionariozin.Login = reader.GetString("Login").ToString();

                    FormMenu tela = new FormMenu();

                    return funcionariozin;
                }
                else
                {
                    MessageBox.Show("Dados do Usuário Logado Indisponíveis!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro ao executar o Comando SQL! (RetorndarDadosUsuarioLogado) {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
