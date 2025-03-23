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
using SoftwareLojasRibeiro.br.com.project.VIEW;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareLojasRibeiro//.br.com.project.VIEW se n colocar isso aqui vai impedir com que eu acesse o FormMenu
{
    public partial class FormClientes : BaseForm
    {
        PagamentoDAO pagaDAO = new PagamentoDAO();
        public FormClientes()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
            this.FormClosing += new FormClosingEventHandler(FormClientes_FormClosing);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            Cliente cli2 = new Cliente { Nome = textBoxPesquisaDevedor.Text };
            dataGridViewClientes.DataSource = dao.ListarClientes(cli);
            dataGridViewClientesDevedores.DataSource = dao.ListarClientesDevedores(cli2);
        }
        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Finaliza completamente a aplicação
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

        public void SelecionarLinhaTabelaClientesDevedores()
        {
            //passando id da venda para a tela de detalhes
            string idvenda = dataGridViewClientesDevedores.CurrentRow.Cells[0].Value.ToString() ?? "";

            FormDetalhesVendas tela = new FormDetalhesVendas(idvenda);
            DateTime datavenda;

            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewClientesDevedores.CurrentRow != null)
            {
                datavenda = Convert.ToDateTime(dataGridViewClientesDevedores.CurrentRow.Cells[7].Value.ToString() ?? "");
                //Pegar os dados da linha selecionada
                tela.textBoxNomeCliente.Text = dataGridViewClientesDevedores.CurrentRow.Cells[2].Value.ToString() ?? "";
                tela.maskedTextBoxDataVenda.Text = datavenda.ToString("dd/MM/yyyy");
                tela.textBoxTotal.Text = dataGridViewClientesDevedores.CurrentRow.Cells[4].Value.ToString() ?? "";
                tela.textBoxValorPago.Text = dataGridViewClientesDevedores.CurrentRow.Cells[5].Value.ToString() ?? "";

                // Obter as formas de pagamento
                List<Pagamento> pagamentos = pagaDAO.RetornarPagamentos(idvenda);
                StringBuilder sbPagamentos = new StringBuilder();

                sbPagamentos.AppendLine("Forma(s) de Pagamento:");
                if (pagamentos != null && pagamentos.Count > 0)
                {
                    foreach (var pagamento in pagamentos)
                    {
                        sbPagamentos.AppendLine($"{pagamento.Forma_Pagamento}: R${pagamento.Valor_Pago:F2}");
                    }
                }
                else
                {
                    sbPagamentos.AppendLine("Nenhuma Forma de Pagamento foi encontrada.");
                }

                // Concatenar as informações de pagamento com as observações
                string observacoes = "\n" + dataGridViewClientesDevedores.CurrentRow.Cells[8].Value.ToString() ?? "";
                tela.textBoxObs.Text = sbPagamentos.ToString() + observacoes;

                tela.ShowDialog();
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
        public void PesquisarDevedor()
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaDevedor.Text };
            dataGridViewClientesDevedores.DataSource = dao.ListarClientesDevedores(cli);
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Receber os dados dentro do objeto modelo de Cliente
            Cliente cli = new Cliente
            {
                Nome = textBoxNome.Text,
                Rg = maskedTextBoxRg.Text,//.Replace(',', '.'),
                Cpf = maskedTextBoxCpf.Text,//.Replace(',', '.'),
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
                //LimparCampos();
                new Helpers().LimparTela(this);
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
            new Helpers().LimparTela(this);
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
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

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void textBoxPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            ClienteDAO dao = new ClienteDAO();
            dataGridViewClientes.DataSource = dao.ListarClientes(cli);
            /*
             private void textBoxPesquisaNome_TextChanged(object sender, EventArgs e)
                {
                    Cliente cli = new Cliente();
                    ClienteDAO dao = new ClienteDAO();

                    if (comboboxOpcao.SelectedItem.ToString() == "NOME")
                    {
                        cli.Nome = textBoxPesquisaNome.Text;
                        dataGridViewClientes.DataSource = dao.ListarClientes(cli);
                    }
                    else if (comboboxOpcao.SelectedItem.ToString() == "CPF")
                    {
                        cli.Cpf = textBoxPesquisaNome.Text;
                        dataGridViewClientes.DataSource = dao.ListarClientesCPF(cli);
                    }
                }
                */

        }

        private void label14_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void buttonDetalhesVenda_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaClientesDevedores();
        }

        private void textBoxNomeDevedor_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxPesquisaDevedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaDevedor.Text };
            dataGridViewClientesDevedores.DataSource = dao.ListarClientesDevedores(cli);
        }

        private void textBoxID_TextChanged(object sender, EventArgs e) { }
    }
}
