using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormFuncionarios : BaseForm
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }

        private void FormFuncionarios_Load_1(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario func = new Funcionario { Nome = textBoxPesquisaNome.Text };
            dataGridViewFuncionarios.DataSource = dao.ListarFuncionarios(func);
            dataGridViewFuncionariosOff.DataSource = dao.ListarFuncionariosDesativados(func);
        }

        public void SelecionarLinhaTabelaFuncionarios()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewFuncionarios.CurrentRow != null)
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewFuncionarios.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNome.Text = dataGridViewFuncionarios.CurrentRow.Cells[2].Value.ToString() ?? "";
                maskedTextBoxRg.Text = dataGridViewFuncionarios.CurrentRow.Cells[8].Value.ToString() ?? "";
                maskedTextBoxCpf.Text = dataGridViewFuncionarios.CurrentRow.Cells[6].Value.ToString() ?? "";
                maskedTextBoxNumero.Text = dataGridViewFuncionarios.CurrentRow.Cells[9].Value.ToString() ?? "";
                textBoxEmail.Text = dataGridViewFuncionarios.CurrentRow.Cells[7].Value.ToString() ?? "";
                maskedTextBoxData.Text = dataGridViewFuncionarios.CurrentRow.Cells[10].Value.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewFuncionarios.CurrentRow.Cells[12].Value.ToString() ?? "";
                maskedTextBoxCep.Text = dataGridViewFuncionarios.CurrentRow.Cells[11].Value.ToString() ?? "";
                comboBoxTipoUsuario.Text = dataGridViewFuncionarios.CurrentRow.Cells[4].Value.ToString() ?? "";
                textBoxLogin.Text = dataGridViewFuncionarios.CurrentRow.Cells[3].Value.ToString() ?? "";
                textBoxSenha.Text = dao.ObterSenhaFuncionario(textBoxID.Text);
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Pesquisar(string nome, DataGridView tabela)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario func = new Funcionario { Nome = nome };
            tabela.DataSource = dao.ListarFuncionarios(func);
        }
        public void PesquisarCpf(string cpf, DataGridView tabela)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario func = new Funcionario { Cpf = cpf };
            tabela.DataSource = dao.ListarFuncionariosCpf(func);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!Helpers.VerificarCamposPreenchidos(this, new List<string> { "textBoxID" }, "tabPageCadastrar"))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario func = new Funcionario
            {
                Nome = textBoxNome.Text,
                Rg = maskedTextBoxRg.Text,//.Replace(',', '.'),
                Cpf = maskedTextBoxCpf.Text,//.Replace(',', '.'),
                Numero = maskedTextBoxNumero.Text,
                Datanasc = DateTime.Parse(maskedTextBoxData.Text),
                Email = textBoxEmail.Text,
                Endereco = textBoxEndereco.Text,
                Cep = maskedTextBoxCep.Text,
                Login = textBoxLogin.Text,
                Senha = textBoxSenha.Text,
                Tipo = comboBoxTipoUsuario.Text
            };

            FuncionarioDAO dao = new FuncionarioDAO();
            bool sucesso = false; // Variável para verificar sucesso da operação

            if (buttonCadastrar.Text == "Cadastrar")
            {
                sucesso = dao.CadastrarFuncionario(func);
            }
            else if (buttonCadastrar.Text == "Alterar")
            {
                func.Id = textBoxID.Text;
                sucesso = dao.AlterarFuncionario(func);

            }

            if (sucesso)
            {
                //LimparCampos();
                new Helpers().LimparTela(this);
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";

                // Criar novo objeto vazio
                func = new Funcionario();

                dataGridViewFuncionarios.DataSource = dao.ListarFuncionarios(func); //atualizar tabela
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNome.Text, dataGridViewFuncionarios);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaFuncionarios();
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            tabControlFuncionarios.SelectedTab = tabPageCadastrar;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Desativar esse Cliente?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario func = new Funcionario();
            func.Id = dataGridViewFuncionarios.CurrentRow.Cells[0].Value.ToString() ?? "";

            FuncionarioDAO dao = new FuncionarioDAO();
            //dao.ExcluirFuncionario(func);
            dao.DesativarFuncionario(func);
            dataGridViewFuncionarios.DataSource = dao.ListarFuncionarios(func); //atualizar tabela
            dataGridViewFuncionariosOff.DataSource = dao.ListarFuncionariosDesativados(func);
        }

        private void buttonAtivar_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Ativar esse Funcionário?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario func = new Funcionario();
            func.Id = dataGridViewFuncionariosOff.CurrentRow.Cells[0].Value.ToString() ?? "";

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AtivarFuncionario(func);
            dataGridViewFuncionarios.DataSource = dao.ListarFuncionarios(func); //atualizar tabela
            dataGridViewFuncionariosOff.DataSource = dao.ListarFuncionariosDesativados(func);
            textBoxID.Clear();
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNome.Clear();
            textBoxPesquisaCpf.Clear();
            Pesquisar(textBoxPesquisaNome.Text, dataGridViewFuncionarios);
        }

        private void buttonLimparPesquisaOff_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomeOff.Clear();
            textBoxPesquisaCpfOff.Clear();
            Pesquisar(textBoxPesquisaNomeOff.Text, dataGridViewFuncionariosOff);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string end = new Helpers().BuscarCep(maskedTextBoxCep.Text);
            textBoxEndereco.Text = end;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void textBoxPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNome.Text, dataGridViewFuncionarios);
        }

        private void textBoxPesquisaCpf_TextChanged(object sender, EventArgs e)
        {
            PesquisarCpf(textBoxPesquisaCpf.Text, dataGridViewFuncionarios);
        }

        private void textBoxPesquisaNomeOff_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomeOff.Text, dataGridViewFuncionariosOff);
        }

        private void textBoxPesquisaCpfOff_TextChanged(object sender, EventArgs e)
        {
            PesquisarCpf(textBoxPesquisaCpfOff.Text, dataGridViewFuncionariosOff);
        }

        #region Lixos
        private void FormFuncionarios_Load(object sender, EventArgs e) { }
        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        #endregion
    }
}
