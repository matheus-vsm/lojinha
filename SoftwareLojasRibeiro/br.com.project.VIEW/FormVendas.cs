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

        int qntd;
        decimal preco, subtotal, total;

        DataTable carrinho = new DataTable();

        public FormVendas()
        {
            InitializeComponent(); 
            this.Size = new Size(1567, 1051); // Define o tamanho do formulário
            this.WindowState = FormWindowState.Normal; // Abre o formulário no estado normal

            maskedTextBoxData.ReadOnly = true;
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            carrinho.Columns.Add("ID", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            dataGridViewProdutosCarrinho.DataSource = carrinho;
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            VendaDAO vdao = new VendaDAO();

            dataGridViewHistorico.DataSource = vdao.ListarTodasVendas();
            dataGridViewHistorico.DefaultCellStyle.ForeColor = Color.Black;

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
                tela.textBoxObs.Text = dataGridViewHistorico.CurrentRow.Cells[7].Value.ToString() ?? "";
                
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
                preco = decimal.Parse(textBoxPreco.Text);

                subtotal = qntd * preco;

                total += subtotal;

                //adicionando produto no carrinho
                carrinho.Rows.Add(int.Parse(textBoxID.Text), textBoxDescrição.Text, qntd, preco, subtotal);
                textBoxTotal.Text = total.ToString();

                textBoxID.Clear();
                textBoxDescrição.Clear();
                textBoxPreco.Clear();
                textBoxQuantidade.Clear();
                textBoxID.Focus();
            }
            catch (Exception error)
            {
                MessageBox.Show("Digite o Código do Produto!");
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
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
            textBoxTotal.Text = total.ToString();

            MessageBox.Show("Produto Removido do Carrinho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(maskedTextBoxData.Text);
            FormPagamentos tela = new FormPagamentos(cliente, carrinho, dataatual);
            tela.textBoxTotal.Text = total.ToString();
            tela.ShowDialog();
            new Helpers().LimparTela(this);
            //if (tela.ShowDialog() == DialogResult.OK)
            //{
            //    new Helpers().LimparTela(this);
            //}
        }

        private void maskedTextBoxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
            new Helpers().LimparTela(this);
        }

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cDAO.RetornarClienteCPF(maskedTextBoxCpf.Text);

                if (cliente != null)
                {
                    textBoxNome.Text = cliente.Nome;
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
                    textBoxDescrição.Text = produto.Descricao;
                    textBoxPreco.Text = produto.Preco.ToString();
                }
                else
                {
                    textBoxID.Clear();
                    textBoxID.Focus();
                }

            }
        }
    }
}
