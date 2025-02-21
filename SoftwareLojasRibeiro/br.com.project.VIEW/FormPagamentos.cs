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
    public partial class FormPagamentos: Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public FormPagamentos(Cliente cli, DataTable carr, DateTime dataatu)
        {
            InitializeComponent();
            cliente = cli;
            carrinho = carr;
            dataatual = dataatu;
            maskedTextBoxData.ReadOnly = true;
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FormPagamentos_Load(object sender, EventArgs e)
        {
            textBoxTroco.Text = "0";
            textBoxCartao.Text = "0";
            textBoxPreco.Text = "0";
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            double v_dinheiro, v_cartao, v_total, v_troco, v_desconto, v_pago;
            int qtdestoque, qtdcomprada, qtdatualizada;

            ProdutoDAO pdao = new ProdutoDAO();

            v_cartao = double.Parse(textBoxCartao.Text);
            v_dinheiro = double.Parse(textBoxPreco.Text);
            v_total = double.Parse(textBoxTotal.Text);

            v_pago = v_cartao + v_dinheiro;

            if(v_total > v_pago)
            {
                MessageBox.Show("Valor pago menor que o total da compra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                v_troco = v_pago - v_total;

                Venda ven = new Venda {
                    Id_Cliente = cliente.Id,
                    Data_Venda = dataatual,
                    Total_Venda = v_total,
                    Desconto = 0,
                    Forma_Pagamento = "Dinheiro",
                    Valor_Pago = v_pago,
                    Status = "Pendente",
                    Observacoes = textBoxObservacoes.Text,
                };
                textBoxTroco.Text = v_troco.ToString();

                VendaDAO vdao = new VendaDAO();
                vdao.CadastrarVenda(ven);

                foreach(DataRow linha in carrinho.Rows)
                {
                    ItensVenda item = new ItensVenda {
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
                this.Dispose();

                new FormVendas().ShowDialog();
            }
        }
    }
}
