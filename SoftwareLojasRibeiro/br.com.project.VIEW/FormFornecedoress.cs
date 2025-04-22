using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormFornecedoress : BaseForm
    {
        public FormFornecedoress()
        {
            InitializeComponent();
        }

        private void FormFornecedoress_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            Fornecedor Forn = new Fornecedor { Nome = textBoxPesquisaNome.Text };
            dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Forn);
            dataGridViewFornecedoresOff.DataSource = dao.ListarFornecedoresDesativados(Forn);
        }

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
                maskedTextBoxCep.Text = dataGridViewFornecedores.CurrentRow.Cells[6].Value?.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewFornecedores.CurrentRow.Cells[7].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Pesquisa(string nome, DataGridView tabela)
        {
            FornecedorDAO dao = new FornecedorDAO();
            Fornecedor Forn = new Fornecedor { Nome = nome };
            tabela.DataSource = dao.ListarFornecedores(Forn);
        }
        public void PesquisaCnpj(string cnpj, DataGridView tabela)
        {
            FornecedorDAO dao = new FornecedorDAO();
            Fornecedor Forn = new Fornecedor { Cnpj = cnpj };
            tabela.DataSource = dao.ListarFornecedoresCnpj(Forn);
        }


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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
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

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
        }

        private void buttonAltera_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaFornecedores();
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            tabControlFornecedores.SelectedTab = tabPageCadastrar;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Desativar esse Fornecedor?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Fornecedor Fonr = new Fornecedor();
            Fonr.Id = dataGridViewFornecedores.CurrentRow.Cells[0].Value.ToString() ?? " ";

            FornecedorDAO dao = new FornecedorDAO();
            //dao.ExcluirFornecedor(Fonr);
            dao.DesativarFornecedor(Fonr);
            dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Fonr);
            dataGridViewFornecedoresOff.DataSource = dao.ListarFornecedoresDesativados(Fonr);
        }

        private void buttonAtivar_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Ativar esse Fornecedor?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Fornecedor Fonr = new Fornecedor();
            Fonr.Id = dataGridViewFornecedoresOff.CurrentRow.Cells[0].Value.ToString() ?? " ";

            FornecedorDAO dao = new FornecedorDAO();
            //dao.ExcluirFornecedor(Fonr);
            dao.AtivarFornecedor(Fonr);
            dataGridViewFornecedores.DataSource = dao.ListarFornecedores(Fonr);
            dataGridViewFornecedoresOff.DataSource = dao.ListarFornecedoresDesativados(Fonr);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNome.Clear();
            textBoxPesquisaCnpj.Clear();
            Pesquisa(textBoxPesquisaNome.Text, dataGridViewFornecedores);
        }

        private void textBoxPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(textBoxPesquisaNome.Text, dataGridViewFornecedores);
        }

        private void textBoxPesquisaCnpj_TextChanged(object sender, EventArgs e)
        {
            PesquisaCnpj(textBoxPesquisaCnpj.Text, dataGridViewFornecedores);
        }

        private void textBoxPesquisaNomeOff_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(textBoxPesquisaNomeOff.Text, dataGridViewFornecedoresOff);
        }

        private void textBoxPesquisaCnpjOff_TextChanged(object sender, EventArgs e)
        {
            PesquisaCnpj(textBoxPesquisaCnpjOff.Text, dataGridViewFornecedoresOff);
        }
    }
}
