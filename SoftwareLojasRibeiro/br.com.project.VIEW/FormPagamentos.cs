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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormPagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrin = new DataTable();
        DateTime dataatual;
        private FormVendas telavendas;


        public FormPagamentos()
        {
            InitializeComponent();
        }
        public FormPagamentos(Cliente cli, DataTable carr, DateTime dataatu, FormVendas telaven)
        {
            InitializeComponent();
            cliente = cli;
            carrin = carr;
            dataatual = dataatu;
            telavendas = telaven;
            maskedTextBoxData.ReadOnly = true;
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dataGridViewProdutosCarrinhoPagamento.DataSource = carrin;
        }

        private void FormPagamentos_Load(object sender, EventArgs e)
        {
            textBoxTroco.Text = "0";
            textBoxDebito.Text = "0";
            textBoxDinheiro.Text = "0";
            textBoxCredito.Text = "0";
            textBoxPix.Text = "0";
            textBoxDesconto.Text = "0";
            dataGridViewProdutosCarrinhoPagamento.DataSource = carrin;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de alterar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja prosseguir com o Pagamento?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", cancelar a operação
            if (resultado == DialogResult.No)
            {
                return;
            }

            double v_dinheiro, v_debito, v_credito, v_pix, v_total, v_troco, v_desconto, v_pago;
            int qtdestoque, qtdcomprada, qtdatualizada;
            string status = "Concluída";

            ProdutoDAO pdao = new ProdutoDAO();

            v_debito = double.Parse(textBoxDebito.Text);
            v_credito = double.Parse(textBoxCredito.Text);
            v_dinheiro = double.Parse(textBoxDinheiro.Text);
            v_pix = double.Parse(textBoxPix.Text);
            v_desconto = double.Parse(textBoxDesconto.Text);
            v_total = double.Parse(textBoxTotal.Text) - v_desconto;

            if (v_desconto > v_total)
            {
                MessageBox.Show("Desconto maior que o total da compra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            v_pago = v_dinheiro + v_credito + v_debito + v_pix;

            Venda ven;

            if (v_total > v_pago)
            {
                // Perguntar ao usuário antes de seguir com a finalização da compra
                DialogResult resultadoo = MessageBox.Show("Valor pago menor que o total da compra!\nDeseja ADICIONAR esse Cliente a LISTA de DEVEDORES?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                status = "Pendente";
                // Se o usuário clicar em "Não", retorna
                if (resultadoo == DialogResult.No)
                {
                    return;
                }
                //adicionar implementação para adicionar o cliente na tabela de devedores
            }

            v_troco = v_pago - v_total;

            ven = new Venda
            {
                Id_Cliente = cliente.Id,
                Data_Venda = dataatual,
                Total_Venda = v_total,
                Desconto = v_desconto,
                Valor_Pago = v_pago,
                Status = status,
                Observacoes = textBoxObservacoes.Text
            };

            textBoxTroco.Text = v_troco.ToString();

            VendaDAO vdao = new VendaDAO();
            PagamentoDAO pagaDAO = new PagamentoDAO();

            vdao.CadastrarVenda(ven);

            string idVenda = vdao.RetornarIdLastVenda();

            Dictionary<string, double> pagamentos = new Dictionary<string, double>
                {
                    { "Cartão de Débito", v_debito },
                    { "Cartão de Crédito", v_credito },
                    { "Dinheiro", v_dinheiro },
                    { "PIX", v_pix }
                };

            foreach (var pagamento in pagamentos)
            {
                if (pagamento.Value > 0)
                {
                    Pagamento paga = new Pagamento
                    {
                        Id_Venda = idVenda,//idvendapag.ToString(),
                        Forma_Pagamento = pagamento.Key,
                        Valor_Pago = pagamento.Value
                    };
                    pagaDAO.CadastrarPagamento(paga);
                }
            }

            foreach (DataRow linha in carrin.Rows)
            {
                ItensVenda item = new ItensVenda
                {
                    Id_Venda = vdao.RetornarIdLastVenda(),
                    Id_Produto = linha["ID"].ToString(),
                    Quantidade = int.Parse(linha["Quantidade"].ToString()),
                    Preco_Unitario = double.Parse(linha["Preço"].ToString()),
                    Subtotal = double.Parse(linha["Subtotal"].ToString()),
                };

                //remove a quantidade de produtos do estoque
                qtdestoque = pdao.RetornaEstoqueAtual(item.Id_Produto);
                qtdcomprada = item.Quantidade;

                if (qtdestoque < qtdcomprada)
                {
                    MessageBox.Show("Quantidade de produtos insuficiente no estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                qtdatualizada = qtdestoque - qtdcomprada;
                pdao.RemoverEstoque(item.Id_Produto, qtdatualizada);

                ItensVendaDAO ivdao = new ItensVendaDAO();
                ivdao.CadastrarItensVenda(item);
            }

            MessageBox.Show("Venda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new Helpers().LimparTelaVendas(telavendas);
            telavendas.dataGridViewHistorico.DataSource = vdao.ListarTodasVendas();
            telavendas.maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            telavendas.textBoxNome.ReadOnly = false;
            telavendas.maskedTextBoxCpf.ReadOnly = false;

            this.Close();
        }

        private void textBoxDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                double totaltudo = double.Parse(telavendas.textBoxTotall.Text);
                double dinheiro = double.Parse(textBoxDinheiro.Text);
                double desconto = double.Parse(textBoxDesconto.Text);
                double total = double.Parse(textBoxTotal.Text);

                if (textBoxDesconto.Text != "0")
                {
                    textBoxTroco.Text = (dinheiro - total - desconto).ToString();
                }
                else
                {
                    textBoxTroco.Text = (dinheiro - totaltudo).ToString();
                }
            }
        }

        private void textBoxDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                double totaltudo = double.Parse(telavendas.textBoxTotall.Text);
                double desconto = double.Parse(textBoxDesconto.Text);
                double dinheiro = double.Parse(textBoxDinheiro.Text);
                if (textBoxDinheiro.Text != "0")
                {
                    textBoxTotal.Text = (totaltudo - desconto).ToString();
                    textBoxTroco.Text = (dinheiro - double.Parse(textBoxTotal.Text)).ToString();
                }
                else
                {
                    textBoxTotal.Text = (totaltudo - desconto).ToString();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e) { }
    }
}
