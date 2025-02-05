using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareLojasRibeiro
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            dataGridViewClientes.DataSource = dao.ListarClientes(cli);
        }

        private void LimparCampos()
        {
            // Limpar os campos da tela
            textBoxID.Clear();
            textBoxNome.Clear();
            maskedTextBoxRg.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxNumero.Clear();
            maskedTextBoxData.Clear();
            textBoxEmail.Clear();
            textBoxEndereco.Clear();
            maskedTextBoxCep.Clear();
        }

        public void SelecionarLinhaTabelaClientes()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewClientes.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString() ?? "";
                maskedTextBoxRg.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() ?? "";
                maskedTextBoxCpf.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString() ?? "";
                maskedTextBoxNumero.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString() ?? "";
                textBoxEmail.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString() ?? "";
                maskedTextBoxData.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewClientes.CurrentRow.Cells[7].Value.ToString() ?? "";
                maskedTextBoxCep.Text = dataGridViewClientes.CurrentRow.Cells[8].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Pesquisar()
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            dataGridViewClientes.DataSource = dao.ListarClientes(cli);
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Receber os dados dentro do objeto modelo de Cliente
            Cliente cli = new Cliente
            {
                Nome = textBoxNome.Text,
                Rg = maskedTextBoxRg.Text.Replace(',', '.'),
                Cpf = maskedTextBoxCpf.Text.Replace(',', '.'),
                Numero = maskedTextBoxNumero.Text,
                Datanasc = DateTime.Parse(maskedTextBoxData.Text),
                Email = textBoxEmail.Text,
                Endereco = textBoxEndereco.Text,
                Cep = maskedTextBoxCep.Text
            };

            //Criar um objeto da classe ClienteDAO e chamar o método CadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            bool sucesso = false; // Variável para verificar sucesso da operação

            if (buttonCadastrar.Text == "Cadastrar")
            {
                sucesso = dao.CadastrarCliente(cli);
            }
            else if (buttonCadastrar.Text == "Alterar")
            {
                cli.Id = textBoxID.Text;
                sucesso = dao.AlterarCliente(cli);
                
            }

            if (sucesso)
            {
                LimparCampos();
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";

                // Criar novo objeto vazio
                cli = new Cliente();

                dataGridViewClientes.DataSource = dao.ListarClientes(cli); //atualizar tabela
            }
            
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            /*if (dataGridViewClientes.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString() ?? "";
                maskedTextBoxRg.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() ?? "";
                maskedTextBoxCpf.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString() ?? "";
                maskedTextBoxNumero.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString() ?? "";
                textBoxEmail.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString() ?? "";
                maskedTextBoxData.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewClientes.CurrentRow.Cells[7].Value.ToString() ?? "";
            }*/
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaClientes();
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            tabControlClientes.SelectedTab = tabPageCadastrar;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            textBoxID.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString() ?? "";
            cli.Id = textBoxID.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(cli);
            dataGridViewClientes.DataSource = dao.ListarClientes(cli); //atualizar tabela
            textBoxID.Clear();
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNome.Clear();
            Pesquisar();
        }
    }
}
