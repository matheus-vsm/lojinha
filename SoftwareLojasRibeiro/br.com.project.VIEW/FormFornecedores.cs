using SoftwareLojasRibeiro.br.com.project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormFornecedores : BaseForm
    {
        public FormFornecedores()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            Fornecedor Forn = new Fornecedor { Nome = textBoxPesquisaNome.Text }; 
            dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Forn);
        }

        #region Selecionar Tabela Fornecedores
        public void SelecionarLinhaTabelaFornecedores()
        {
            if (dataGridViewFornecedores.CurrentRow != null)
            {
                FornecedorDAO dao = new FornecedorDAO();

                textBoxID.Text = dataGridViewFornecedores.CurrentRow.Cells[0].Value?.ToString() ?? "";
                textBoxNome.Text = dataGridViewFornecedores.CurrentRow.Cells[1].Value?.ToString() ?? "";
                maskedTextBoxCnpj.Text = dataGridViewFornecedores.CurrentRow.Cells[2].Value?.ToString() ?? "";
                textBoxEmail.Text = dataGridViewFornecedores.CurrentRow.Cells[3].Value?.ToString() ?? "";
                maskedTextBoxTelefone.Text = dataGridViewFornecedores.CurrentRow.Cells[4].Value?.ToString() ?? "";
                maskedTextBoxCelular.Text = dataGridViewFornecedores.CurrentRow.Cells[5].Value?.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewFornecedores.CurrentRow.Cells[6].Value?.ToString() ?? "";
                maskedTextBoxCep.Text = dataGridViewFornecedores.CurrentRow.Cells[7].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Botao Pesquisa

        public void Pesquisa()
        {
            FornecedorDAO dao = new FornecedorDAO();
            Fornecedor Forn = new Fornecedor { Nome = textBoxPesquisaNome.Text };
            dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Forn);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Botão Consultar CEP
            try
            {
                string cep = maskedTextBoxCep.Text;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";

                DataSet dados = new DataSet(); //objeto capaz de receber e fazer uma requisição para a API

                dados.ReadXml(xml);
                textBoxEndereco.Text = $"{dados.Tables[0].Rows[0]["logradouro"]}, " +
                                       $"{dados.Tables[0].Rows[0]["bairro"]}, " +
                                       $"{dados.Tables[0].Rows[0]["complemento"]}, " +
                                       $"{dados.Tables[0].Rows[0]["localidade"]} - " +
                                       $"{dados.Tables[0].Rows[0]["uf"]}.";

            }
            catch (Exception error)
            {
                MessageBox.Show($"Endereço não encontrado. Digite manualmente. {error.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
        #endregion

        #region Botao Limpar
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
            textBoxID.Clear();
            textBoxNome.Clear();
            maskedTextBoxCnpj.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCelular.Clear();
            textBoxEndereco.Clear();
            maskedTextBoxCep.Clear();
        }
        #endregion

        #region Botao Cadastro
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor Forn = new Fornecedor
            {
                Nome = textBoxNome.Text,
                Cnpj = maskedTextBoxCnpj.Text,
                Email = textBoxEmail.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Celular = maskedTextBoxCelular.Text,
                Endereco = textBoxEndereco.Text,
                Cep = maskedTextBoxCep.Text,
            };

            FornecedorDAO dao = new FornecedorDAO();
            bool sucesso = false;

            if (buttonCadastrar.Text == "Cadastrar")
            {
                sucesso = dao.CadastrarFornecedor(Forn);
            }
            else if (buttonCadastrar.Text == "Alterar")
            {
                Forn.Id = textBoxID.Text;
                sucesso = dao.AlterarFornecedor(Forn);
            }

            if (sucesso)
            {
                // Limpar os Campos
                new Helpers().LimparTela(this);
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";

                // Criar novo Objeto Vazio
                Forn = new Fornecedor();

                dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Forn);
            }
        }
        #endregion

        #region Pesquisa Click
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }
        #endregion

        #region Botão Alterar
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaFornecedores();
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            tabControlFornecedores.SelectedTab = tabPageCadastrar;
        }
        #endregion

        #region Botao Excluir
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor Fonr = new Fornecedor();
            textBoxID.Text = dataGridViewFornecedores.CurrentRow.Cells[0].Value.ToString() ?? " ";
            Fonr.Id = textBoxID.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(Fonr);
            dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Fonr);
            textBoxID.Clear();
        }

        #endregion

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
     
        }

        private void buttonLimparPesquisar_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNome.Clear();
        }
    }

}




