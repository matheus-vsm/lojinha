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

            dataGridViewProdutosCarrinhoPagamento.DefaultCellStyle.Font = new Font("Arial Rounded MT", 16);
            dataGridViewProdutosCarrinhoPagamento.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 18, FontStyle.Bold);
            dataGridViewProdutosCarrinhoPagamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProdutosCarrinhoPagamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            v_total = double.Parse(textBoxTotal.Text);

            v_pago = v_dinheiro + v_credito + v_debito + v_pix;

            Venda ven;

            if (v_total > v_pago)
            {
                // Perguntar ao usuário antes de seguir com a finalização da compra
                DialogResult resultadoo = MessageBox.Show("Valor pago menor que o total da compra!\nDeseja ADICIONAR esse Cliente a LISTA de DEVEDORES?\n" + 
                                                        $"Dívida = R${v_total - v_pago}",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                status = "Pendente";
                // Se o usuário clicar em "Não", retorna
                if (resultadoo == DialogResult.No)
                {
                    return;
                }
            }

            //v_troco = v_pago - v_total;
            //textBoxTroco.Text = v_troco.ToString();

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

            VendaDAO vdao = new VendaDAO();
            PagamentoDAO pagaDAO = new PagamentoDAO();

            vdao.CadastrarVenda(ven);

            string idVenda = vdao.RetornarIdLastVenda();

            if (status == "Pendente")
            {
                Devedores devedor = new Devedores
                {
                    Id_Cliente = cliente.Id,
                    Id_Venda = idVenda,
                    Divida_Inicial = v_total - v_pago,
                    Divida_Atual = v_total - v_pago,
                    Data_Inicio = dataatual
                };

                DevedoresDAO devedoresDAO = new DevedoresDAO();
                devedoresDAO.CadastrarClienteDevedor(devedor);
            }

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
                    Preco_Unitario = double.Parse(linha["Preço (R$)"].ToString()),
                    Subtotal = double.Parse(linha["Subtotal (R$)"].ToString()),
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

        #region troco antes
        //private void textBoxDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        double totaltudo = double.Parse(telavendas.textBoxTotall.Text);
        //        double dinheiro = double.Parse(textBoxDinheiro.Text);
        //        double desconto = double.Parse(textBoxDesconto.Text);
        //        double total = double.Parse(textBoxTotal.Text);

        //        if (textBoxDesconto.Text != "0")
        //        {
        //            textBoxTroco.Text = (dinheiro - total - desconto).ToString();
        //        }
        //        else
        //        {
        //            textBoxTroco.Text = (dinheiro - totaltudo).ToString();
        //        }
        //    }
        //}

        //private void textBoxDesconto_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        double totaltudo = double.Parse(telavendas.textBoxTotall.Text);
        //        double desconto = double.Parse(textBoxDesconto.Text);
        //        double dinheiro = double.Parse(textBoxDinheiro.Text);
        //        if (textBoxDinheiro.Text != "0")
        //        {
        //            textBoxTotal.Text = (totaltudo - desconto).ToString();
        //            textBoxTroco.Text = (dinheiro - double.Parse(textBoxTotal.Text)).ToString();
        //        }
        //        else
        //        {
        //            textBoxTotal.Text = (totaltudo - desconto).ToString();
        //        }
        //    }
        //}
        #endregion

        private void textBoxDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Verifica se a tecla Enter foi pressionada
            {
                // Validações e conversões seguras
                if (!double.TryParse(telavendas.textBoxTotall.Text, out double totaltudo))
                {
                    MessageBox.Show("Valor Total Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(textBoxDinheiro.Text, out double dinheiro))
                {
                    MessageBox.Show("Valor em Dinheiro Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(textBoxDesconto.Text, out double desconto))
                {
                    desconto = 0; // Assume desconto como 0 se não for válido
                }

                // Cálculo do troco
                double total = totaltudo - desconto;
                double troco = dinheiro - total;

                // Atualiza o campo de troco
                textBoxTroco.Text = troco >= 0 ? troco.ToString("F2") : "0.00";

                // Exibe mensagem se o troco for negativo
                if (troco < 0)
                {
                    MessageBox.Show("O Valor em Dinheiro é Insuficiente para Calcular o Troco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Verifica se a tecla Enter foi pressionada
            {
                double v_descontin = double.Parse(textBoxDesconto.Text);
                double v_totalzin = double.Parse(telavendas.textBoxTotall.Text);

                // Validações e conversões seguras
                if (!double.TryParse(telavendas.textBoxTotall.Text, out double totaltudo))
                {
                    MessageBox.Show("Valor total inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(textBoxDesconto.Text, out double desconto))
                {
                    desconto = 0; // Assume desconto como 0 se não for válido
                }
                if (!double.TryParse(textBoxDinheiro.Text, out double dinheiro))
                {
                    dinheiro = 0; // Assume dinheiro como 0 se não for válido
                }
                if (v_descontin > v_totalzin)
                {
                    MessageBox.Show("Desconto maior que o total da compra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cálculo do total com desconto
                double total = v_totalzin - desconto;
                textBoxTotal.Text = total.ToString("F2");

                // Cálculo do troco
                double troco = dinheiro - total;
                textBoxTroco.Text = troco >= 0 ? troco.ToString("F2") : "0.00";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Lixos
        private void textBoxTotal_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}
