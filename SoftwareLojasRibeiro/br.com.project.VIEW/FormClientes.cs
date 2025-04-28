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
            ClienteDAO cliDAO = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            DevedoresDAO devDAO = new DevedoresDAO();
            dataGridViewClientes.DataSource = cliDAO.ListarClientes(cli);
            dataGridViewClientesDesativados.DataSource = cliDAO.ListarClientesDesativados(cli);
            dataGridViewClientesDevedores.DataSource = devDAO.ListarDevedores(cli);
            dataGridViewClientesDevedoresOff.DataSource = devDAO.ListarDevedoresQuitados(cli);
        }
        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Finaliza completamente a aplicação
        }

        public void SelecionarLinhaTabelaClientes()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewClientes.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNome.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() ?? "";
                maskedTextBoxRg.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString() ?? "";
                maskedTextBoxCpf.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString() ?? "";
                maskedTextBoxNumero.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString() ?? "";
                textBoxEmail.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString() ?? "";
                maskedTextBoxData.Text = dataGridViewClientes.CurrentRow.Cells[7].Value.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewClientes.CurrentRow.Cells[9].Value.ToString() ?? "";
                maskedTextBoxCep.Text = dataGridViewClientes.CurrentRow.Cells[8].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelecionarLinhaTabelaClientesDevedores(DataGridView tabela)
        {
            //passando id da venda para a tela de detalhes
            string idvenda = tabela.CurrentRow.Cells[0].Value.ToString() ?? "";

            FormDetalhesVendas tela = new FormDetalhesVendas(idvenda);
            DateTime datavenda;

            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (tabela.CurrentRow != null)
            {
                datavenda = Convert.ToDateTime(tabela.CurrentRow.Cells[8].Value.ToString() ?? "");
                //Pegar os dados da linha selecionada
                tela.textBoxNomeCliente.Text = tabela.CurrentRow.Cells[2].Value.ToString() ?? "";
                tela.maskedTextBoxDataVenda.Text = datavenda.ToString("dd/MM/yyyy");
                tela.textBoxTotal.Text = tabela.CurrentRow.Cells[4].Value.ToString() ?? "";
                tela.textBoxValorPago.Text = tabela.CurrentRow.Cells[5].Value.ToString() ?? "";

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
                string observacoes = "\n" + tabela.CurrentRow.Cells[8].Value.ToString() ?? "";
                tela.textBoxObs.Text = sbPagamentos.ToString() + observacoes;

                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PesquisarNome(string nome, DataGridView tabela)
        {
            ClienteDAO clidao = new ClienteDAO(); 
            DevedoresDAO devdao = new DevedoresDAO();
            Cliente cli = new Cliente { Nome = nome };

            if (tabela == dataGridViewClientes)
            {
                tabela.DataSource = clidao.ListarClientes(cli);
            }
            else if (tabela == dataGridViewClientesDesativados)
            {
                tabela.DataSource = clidao.ListarClientesDesativados(cli);
            }
            else if (tabela == dataGridViewClientesDevedores)
            {
                tabela.DataSource = devdao.ListarDevedores(cli);
            }
            else if (tabela == dataGridViewClientesDevedoresOff)
            {
                tabela.DataSource = devdao.ListarDevedoresQuitados(cli);
            }
        }

        public void PesquisarCpf(string cpf, DataGridView tabela)
        {
            ClienteDAO clidao = new ClienteDAO();
            DevedoresDAO devdao = new DevedoresDAO();
            Cliente cli = new Cliente { Cpf = cpf };

            if (tabela == dataGridViewClientes)
            {
                tabela.DataSource = clidao.ListarClientesCpf(cli);
            }
            else if (tabela == dataGridViewClientesDesativados)
            {
                tabela.DataSource = clidao.ListarClientesDesativadosCpf(cli);
            }
            else if (tabela == dataGridViewClientesDevedores)
            {
                tabela.DataSource = devdao.ListarDevedoresCpf(cli);
            }
            else if (tabela == dataGridViewClientesDevedoresOff)
            {
                tabela.DataSource = devdao.ListarDevedoresQuitadosCpf(cli);
            }
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!Helpers.VerificarCamposPreenchidos(this, new List<string> { "textBoxID" }, "tabPageCadastrar"))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
 
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaClientes();
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            tabControlClientes.SelectedTab = tabPageCadastrar;
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

            Cliente cli = new Cliente();
            cli.Id = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString() ?? "";

            ClienteDAO dao = new ClienteDAO();
            //dao.ExcluirCliente(cli);
            dao.DesativarCliente(cli);
            dataGridViewClientes.DataSource = dao.ListarClientes(cli); //atualizar tabela
            dataGridViewClientesDevedores.DataSource = dao.ListarClientesDevedores(cli);
            dataGridViewClientesDesativados.DataSource = dao.ListarClientesDesativados(cli);
        }

        private void buttonAtivarCliente_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Ativar esse Cliente?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cli = new Cliente();
            textBoxID.Text = dataGridViewClientesDesativados.CurrentRow.Cells[0].Value.ToString() ?? "";
            cli.Id = textBoxID.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.AtivarCliente(cli);
            dataGridViewClientes.DataSource = dao.ListarClientes(cli); //atualizar tabela
            dataGridViewClientesDevedores.DataSource = dao.ListarClientesDevedores(cli);
            dataGridViewClientesDesativados.DataSource = dao.ListarClientesDesativados(cli);
            textBoxID.Clear();
        }

        #region Botões Limpar
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNome.Clear();
            textBoxPesquisaCpf.Clear();
            PesquisarNome("", dataGridViewClientes);
        }
        private void buttonLimparDesativados_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomeDesativado.Clear();
            textBoxPesquisaCpfDesativado.Clear();
            PesquisarNome("", dataGridViewClientesDesativados);
        }
        private void buttonLimparDevedor_Click(object sender, EventArgs e)
        {
            textBoxPesquisaDevedor.Clear();
            textBoxPesquisaDevedorCpf.Clear();
            PesquisarNome("", dataGridViewClientesDevedores);
        }

        private void buttonLimparOff_Click(object sender, EventArgs e)
        {
            textBoxPesquisaDevedorOff.Clear();
            textBoxPesquisaDevedorOffCpf.Clear();
            PesquisarNome("", dataGridViewClientesDevedoresOff);
        }
        #endregion

        #region Campos de Pesquisa
        private void textBoxPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome(textBoxPesquisaNome.Text, dataGridViewClientes);
        }
        private void textBoxPesquisaCpf_TextChanged(object sender, EventArgs e)
        {
            PesquisarCpf(textBoxPesquisaCpf.Text, dataGridViewClientes);
        }

        private void textBoxPesquisaNomeDesativado_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome(textBoxPesquisaNomeDesativado.Text, dataGridViewClientesDesativados);
        }
        private void textBoxPesquisaCpfDesativado_TextChanged(object sender, EventArgs e)
        {
            PesquisarCpf(textBoxPesquisaCpfDesativado.Text, dataGridViewClientesDesativados);
        }

        private void textBoxPesquisaDevedor_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome(textBoxPesquisaDevedor.Text, dataGridViewClientesDevedores);
        }
        private void textBoxPesquisaDevedorCpf_TextChanged(object sender, EventArgs e)
        {
            PesquisarCpf(textBoxPesquisaDevedorCpf.Text, dataGridViewClientesDevedores);
        }

        private void textBoxPesquisaDevedorOff_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome(textBoxPesquisaDevedorOff.Text, dataGridViewClientesDevedoresOff);
        }
        private void textBoxPesquisaDevedorOffCpf_TextChanged(object sender, EventArgs e)
        {
            PesquisarCpf(textBoxPesquisaDevedorOffCpf.Text, dataGridViewClientesDevedoresOff);
        }
        #endregion

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

        private void buttonDetalhesVenda_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaClientesDevedores(dataGridViewClientesDevedores);
        }

        private void buttonDetalhesOff_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaClientesDevedores(dataGridViewClientesDevedoresOff);
        }

        private void buttonExibirCompras_Click(object sender, EventArgs e)
        {
            string id = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString() ?? "";
            string nome = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() ?? "";
            FormExibirComprasCliente tela = new FormExibirComprasCliente(id, nome);
            tela.ShowDialog();
        }

        private void buttonExibirComprasDesativado_Click(object sender, EventArgs e)
        {
            string id = dataGridViewClientesDesativados.CurrentRow.Cells[0].Value.ToString() ?? "";
            string nome = dataGridViewClientesDesativados.CurrentRow.Cells[2].Value.ToString() ?? "";
            FormExibirComprasCliente tela = new FormExibirComprasCliente(id, nome);
            tela.ShowDialog();
        }

        private void buttonAtualizarDivida_Click(object sender, EventArgs e)
        {
            string idcliente = dataGridViewClientesDevedores.CurrentRow.Cells[1].Value.ToString() ?? "";
            string idvenda = dataGridViewClientesDevedores.CurrentRow.Cells[0].Value.ToString() ?? "";
            double dividaatual = Convert.ToDouble(dataGridViewClientesDevedores.CurrentRow.Cells[7].Value.ToString() ?? "");

            string pagamento = Helpers.InputBox($"A dídida atual é R${dividaatual:F2}. Quanto deseja cobrir?", "Atualização de Dívida");
            double novadivida = dividaatual - Convert.ToDouble(pagamento);
            DateTime data = DateTime.Now;

            Devedores devedor;
            if (novadivida < 0)
            {
                MessageBox.Show("Valor inválido! A dívida não pode ser negativa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(pagamento))
            {
                MessageBox.Show("Insira um Valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (novadivida == 0)
            {
                devedor = new Devedores
                {
                    Id_Cliente = idcliente,
                    Id_Venda = idvenda,
                    Divida_Atual = novadivida,
                    Data_Atualizacao = data,
                    Data_Fim = data
                };
            }
            else
            {
                devedor = new Devedores
                {
                    Id_Cliente = idcliente,
                    Id_Venda = idvenda,
                    Divida_Atual = novadivida,
                    Data_Atualizacao = data,
                    Data_Fim = null,
                };
            }

            DevedoresDAO devedoresDAO = new DevedoresDAO();
            bool sucesso = devedoresDAO.AtualizarDivida(devedor);
            double retornodivida = devedoresDAO.RetornaDividaAtual(idcliente, idvenda);

            if (sucesso)
            {
                if (retornodivida == 0.00)
                {
                    new VendaDAO().AtualizarStatusVenda(devedor);
                    devedoresDAO.AtualizarStatus(devedor);
                }
                else
                {
                    MessageBox.Show($"Dívida atualizada para o valor de R${retornodivida:F2}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Cliente cli = new Cliente { Nome = textBoxPesquisaDevedor.Text };
                dataGridViewClientesDevedores.DataSource = devedoresDAO.ListarDevedores(cli);
                dataGridViewClientesDevedoresOff.DataSource = devedoresDAO.ListarDevedoresQuitados(cli);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a dívida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Lixos
        private void label14_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBoxNomeDevedor_KeyPress(object sender, KeyPressEventArgs e) { }
        private void textBoxID_TextChanged(object sender, EventArgs e) { }
        private void buttonPesquisar_Click(object sender, EventArgs e) { }
        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBoxPesquisaDevedor_KeyPress(object sender, EventArgs e) { }
        #endregion
    }
}
