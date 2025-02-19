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

        int qntd;
        decimal preco, subtotal, total;

        DataTable carrinho = new DataTable();

        public FormVendas()
        {
            InitializeComponent();
            maskedTextBoxData.ReadOnly = true;
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            carrinho.Columns.Add("ID", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            dataGridViewProdutosCarrinho.DataSource = carrinho;
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
            FormPagamentos tela = new FormPagamentos(cliente, carrinho);
            tela.textBoxTotal.Text = total.ToString();
            tela.ShowDialog();
        }

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cDAO.RetornarClienteCPF(maskedTextBoxCpf.Text);
                textBoxNome.Text = cliente.Nome;
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pDAO.RetornarProduto(int.Parse(textBoxID.Text));
                textBoxDescrição.Text = produto.Descricao;
                textBoxPreco.Text = produto.Preco.ToString();
            }
        }
    }
}
