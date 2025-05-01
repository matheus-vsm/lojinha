using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormVendas : BaseForm
    {
        Cliente cliente = new Cliente();
        ClienteDAO cDAO = new ClienteDAO();

        Produto produto = new Produto();
        ProdutoDAO pDAO = new ProdutoDAO();

        Pagamento paga = new Pagamento();
        PagamentoDAO pagaDAO = new PagamentoDAO();

        int qntd, qntdestoque;
        decimal preco, subtotal, total;
        DateTime iniciozada = Convert.ToDateTime("2000-01-01");
        DateTime fimzada = Convert.ToDateTime("3000-01-01");

        DataTable carrinho = new DataTable();

        Helpers help = new Helpers();

        public FormVendas()
        {
            InitializeComponent(); 
            this.WindowState = FormWindowState.Normal; // Abre o formulário no estado normal

            maskedTextBoxData.ReadOnly = true;
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            carrinho.Columns.Add("ID", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço (R$)", typeof(decimal));
            carrinho.Columns.Add("Subtotal (R$)", typeof(decimal));

            dataGridViewProdutosCarrinho.DataSource = carrinho;
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            dateTimePickerDataInicio.Value = DateTime.Now;
            dateTimePickerDataFim.Value = DateTime.Now.AddDays(1);

            VendaDAO vdao = new VendaDAO();
            dataGridViewHistorico.DataSource = vdao.ListarVendas(iniciozada, fimzada);
            dataGridViewHistorico.DefaultCellStyle.ForeColor = Color.Black;

            dataGridViewProdutosCarrinho.DefaultCellStyle.Font = new Font("Arial Rounded MT", 16);
            dataGridViewProdutosCarrinho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 18, FontStyle.Bold);
            dataGridViewProdutosCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProdutosCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewHistorico.DefaultCellStyle.Font = new Font("Arial Rounded MT", 16);
            dataGridViewHistorico.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 18, FontStyle.Bold);
            dataGridViewHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHistorico.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            toolStripStatusLabelUsuario.Text = FormMenu.nomeusuariologado;
            toolStripStatusLabelTipoUsuario.Text = FormMenu.tipousuariologado;

            maskedTextBoxCpf.Focus();
            help.ConfigurarLinkToolStrip(toolStripStatusLabelDevMath, "https://www.linkedin.com/in/matheus-v-275924208/");
            help.ConfigurarLinkToolStrip(toolStripStatusLabelDevLeandro, "https://www.linkedin.com/in/matheus-v-275924208/");
            help.AjustarControles(this); // Salva os tamanhos originais dos controles
        }


        public void SelecionarLinhaTabelaVendas()
        {
            //passando id da venda para a tela de detalhes
            string idvenda = dataGridViewHistorico.CurrentRow.Cells[0].Value.ToString() ?? "";
            
            FormDetalhesVendas tela = new FormDetalhesVendas(idvenda);
            DateTime datavenda;
            
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewHistorico.CurrentRow != null)
            {
                datavenda = Convert.ToDateTime(dataGridViewHistorico.CurrentRow.Cells[2].Value.ToString() ?? "");
                //Pegar os dados da linha selecionada
                tela.textBoxNomeCliente.Text = dataGridViewHistorico.CurrentRow.Cells[1].Value.ToString() ?? "";
                tela.maskedTextBoxDataVenda.Text = datavenda.ToString("dd/MM/yyyy");
                tela.textBoxTotal.Text = dataGridViewHistorico.CurrentRow.Cells[3].Value.ToString() ?? "";
                tela.textBoxValorPago.Text = dataGridViewHistorico.CurrentRow.Cells[5].Value.ToString() ?? "";

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
                string observacoes = "\n" + dataGridViewHistorico.CurrentRow.Cells[7].Value.ToString() ?? "";
                tela.textBoxObs.Text = sbPagamentos.ToString() + observacoes;

                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                qntd = int.Parse(textBoxQuantidade.Text);
                qntdestoque = int.Parse(textBoxEstoque.Text);

                if (qntd > qntdestoque)
                {
                    MessageBox.Show("Quantidade Indisponível no Estoque!");
                    textBoxQuantidade.Clear();
                    textBoxQuantidade.Focus();
                    return;
                }

                preco = decimal.Parse(textBoxPreco.Text);

                subtotal = qntd * preco;

                total += subtotal;

                //adicionando produto no carrinho
                carrinho.Rows.Add(int.Parse(textBoxID.Text), textBoxDescricao.Text, qntd, preco, subtotal);
                textBoxTotall.Text = total.ToString();

                textBoxID.Clear();
                textBoxDescricao.Clear();
                textBoxPreco.Clear();
                textBoxQuantidade.Clear();
                textBoxEstoque.Clear();
                textBoxID.ReadOnly = false;
                textBoxQuantidade.ReadOnly = true;
                textBoxPreco.ReadOnly = true;
                textBoxEstoque.ReadOnly = true;
                textBoxID.Focus();
            }
            catch (Exception)
            {
                string nomeprod = textBoxDescricao.Text;
                string id = textBoxID.Text;

                if (nomeprod == "")
                {
                    MessageBox.Show("Escolha um produto para ser Adicionado ao Carrinho!");
                    textBoxID.Focus();
                }
                else if (qntd == 0 || qntd == null)
                {
                    MessageBox.Show("Digite a Quantidade do Produto!");
                    textBoxQuantidade.Focus();
                }
                else if (id == "")
                {
                    MessageBox.Show("Digite o Código do Produto!");
                    textBoxID.Focus();
                }
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (carrinho.Rows.Count == 0)
            {
                MessageBox.Show("Não há Produtos no Carrinho para serem removidos.");
                textBoxID.Focus();
                return;
            }

            // Perguntar ao usuário antes de excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Produto do Carrinho?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa a exclusão
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subproduto = decimal.Parse(dataGridViewProdutosCarrinho.CurrentRow.Cells[4].Value.ToString());
            int indice = dataGridViewProdutosCarrinho.CurrentRow.Index; //pega o indice da linha selecionada
            DataRow linha = carrinho.Rows[indice]; //definindo a linha que será excluída
            
            carrinho.Rows.Remove(linha); //removendo a linha
            carrinho.AcceptChanges(); //atualizando a tabela

            total -= subproduto;
            textBoxTotall.Text = total.ToString();

            MessageBox.Show("Produto Removido do Carrinho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPagamento_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" && carrinho.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente foi definido e não há Produtos no Carrinho!");
                maskedTextBoxCpf.Focus();
                return;
            }
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Digite o CPF para definir o Cliente!");
                maskedTextBoxCpf.Focus();
                return;
            }
            if (carrinho.Rows.Count == 0)
            {
                MessageBox.Show("O Carrinho está vazio! Adicione Produtos ao Carrinho.");
                textBoxID.Focus();
                return;
            }
            DateTime dataatual = DateTime.Parse(maskedTextBoxData.Text);
            FormPagamentos tela = new FormPagamentos(cliente, carrinho, dataatual, this);
            tela.textBoxTotal.Text = total.ToString();
            tela.ShowDialog();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            DateTime inicio = Convert.ToDateTime(dateTimePickerDataInicio.Value.ToString("yyyy-MM-dd"));
            DateTime fim = Convert.ToDateTime(dateTimePickerDataFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO vdao = new VendaDAO();
            dataGridViewHistorico.DataSource = vdao.ListarVendas(inicio, fim);
            dataGridViewHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void buttonDetalhes_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaVendas();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            help.LimparTelaVendas(this);
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            maskedTextBoxCpf.ReadOnly = false;
            textBoxNome.ReadOnly = false;
            textBoxID.ReadOnly = false;
            textBoxEstoque.ReadOnly = true;
            textBoxQuantidade.ReadOnly = true;
            textBoxPreco.ReadOnly = true;
            total = 0;
            //limpar dados do carrinho, n so linhas
        }

        private void buttonExibirProds_Click(object sender, EventArgs e)
        {
            FormExibirProdutos tela = new FormExibirProdutos(this);
            tela.ShowDialog();
        }

        private void buttonLimparId_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxDescricao.Clear();
            textBoxPreco.Clear();
            textBoxEstoque.Clear();
            textBoxQuantidade.Clear();
            textBoxID.ReadOnly = false;
            textBoxEstoque.ReadOnly = true;
            textBoxQuantidade.ReadOnly = true;
            textBoxPreco.ReadOnly = true;
            textBoxID.Focus();
        }

        private void buttonLimparCpf_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxCpf.ReadOnly = false;
            textBoxNome.ReadOnly = false;
            maskedTextBoxCpf.Focus();
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            dateTimePickerDataInicio.Value = DateTime.Now;
            dateTimePickerDataFim.Value = DateTime.Now.AddDays(1);

            VendaDAO vdao = new VendaDAO();
            dataGridViewHistorico.DataSource = vdao.ListarVendas(iniciozada, fimzada);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Cancelar a Venda?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa a exclusão
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            help.LimparTelaVendas(this);
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            maskedTextBoxCpf.ReadOnly = false;
            textBoxNome.ReadOnly = false;
            textBoxID.ReadOnly = false;
            textBoxEstoque.ReadOnly = false;
            total = 0;
        }

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cDAO.RetornarClienteCPF(maskedTextBoxCpf.Text);

                if (cliente != null)
                {
                    textBoxNome.Text = cliente.Nome;
                    maskedTextBoxCpf.ReadOnly = true;
                    textBoxNome.ReadOnly = true;
                    textBoxID.Focus();
                }
                else
                {
                    maskedTextBoxCpf.Clear();
                    maskedTextBoxCpf.Focus();
                }
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)        
        {
            if (e.KeyChar == 13)
            {
                produto = pDAO.RetornarProduto(int.Parse(textBoxID.Text));
                
                if (produto != null)
                {
                    textBoxDescricao.Text = produto.Descricao;
                    textBoxPreco.Text = produto.Preco_Venda.ToString();
                    textBoxEstoque.Text = produto.Estoque.ToString();
                    textBoxQuantidade.Focus();
                    textBoxQuantidade.ReadOnly = false;
                    textBoxPreco.ReadOnly = false;
                    textBoxID.ReadOnly = true;
                }
                else
                {
                    textBoxID.Clear();
                    textBoxID.Focus();
                }
            }
        }

        #region Lixos
        private void textBoxID_TextChanged(object sender, EventArgs e) { }
        private void maskedTextBoxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void dataGridViewHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewProdutosCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void FormVendas_KeyPress(object sender, KeyPressEventArgs e) { }
        private void maskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        #endregion
    }
}
