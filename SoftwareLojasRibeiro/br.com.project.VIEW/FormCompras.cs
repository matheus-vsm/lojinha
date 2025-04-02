using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormCompras : BaseForm
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            FornecedorDAO forndao = new FornecedorDAO();;
            comboBoxFornecedor.DataSource = forndao.ListarFornecedoresCombo();
            comboBoxFornecedor.DisplayMember = "Nome";
            comboBoxFornecedor.ValueMember = "Id_Fornecedor";

            CategoriaDAO catdao = new CategoriaDAO();
            comboBoxCategProd.DataSource = catdao.ListarNomeCategorias("Produto");
            comboBoxCategProd.DisplayMember = "Nome";
            comboBoxCategProd.ValueMember = "Id_Categoria_Prod";

            comboBoxCategPub.DataSource = catdao.ListarNomeCategorias("Publico");
            comboBoxCategPub.DisplayMember = "Nome";
            comboBoxCategPub.ValueMember = "Id_Categoria_Pub";

            CompraProdutosDAO compradao = new CompraProdutosDAO();
            CompraProdutos compra = new CompraProdutos();
            dataGridViewCompras.DataSource = compradao.ListarCompras(compra);

        }

        public void SelecionarLinhaTabelaProdutos()
        {
            ////Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            //if (dataGridViewCompras.CurrentRow != null)
            //{
            //    //Pegar os dados da linha selecionada
            //    textBoxID.Text = dataGridViewCompras.CurrentRow.Cells[0].Value.ToString() ?? "";
            //    textBoxNomeProd.Text = dataGridViewCompras.CurrentRow.Cells[1].Value.ToString() ?? "";
            //    textBoxMarca.Text = dataGridViewCompras.CurrentRow.Cells[2].Value.ToString() ?? "";
            //    textBoxCor.Text = dataGridViewCompras.CurrentRow.Cells[3].Value.ToString() ?? "";
            //    textBoxTamanho.Text = dataGridViewCompras.CurrentRow.Cells[4].Value.ToString() ?? "";
            //    textBoxPreco.Text = dataGridViewCompras.CurrentRow.Cells[5].Value.ToString() ?? "";
            //    textBoxEstoque.Text = dataGridViewCompras.CurrentRow.Cells[6].Value.ToString() ?? "";
            //    comboBoxCategProd.Text = dataGridViewCompras.CurrentRow.Cells[7].Value.ToString() ?? "";
            //    comboBoxCategPub.Text = dataGridViewCompras.CurrentRow.Cells[8].Value.ToString() ?? "";
            //    textBoxDescrição.Text = dataGridViewCompras.CurrentRow.Cells[9].Value.ToString() ?? "";
            //}
            //else
            //{
            //    MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            bool confimacao = new Helpers().Confirmacao();
            if (confimacao == false)
            {
                return;
            }

            double total = double.Parse(textBoxPrecoCusto.Text) * int.Parse(textBoxQuantidade.Text);

            CompraProdutos compra = new CompraProdutos
            {
                Id_Fornecedor = comboBoxFornecedor.SelectedValue.ToString(),
                Nome_Produto = textBoxNomeProd.Text,
                Total_Compra = total,
                Observacoes = textBoxObs.Text,
            };

            CompraProdutosDAO compraProdutosDAO = new CompraProdutosDAO();
            bool sucessocompra = false;
            if (buttonCadastrar.Text == "Cadastrar")
            {
                sucessocompra = compraProdutosDAO.CadastrarCompra(compra);
            }

            string lastcompra = compraProdutosDAO.RetornarIdLastCompra();
            ItensCompraProdutos itens = new ItensCompraProdutos
            {
                Id_Compra = lastcompra,
                Nome_Produto = textBoxNomeProd.Text,
                Marca = textBoxMarca.Text,
                Cor = textBoxCor.Text,
                Tamanho = textBoxTamanho.Text,
                Descricao = textBoxDescrição.Text,
                Preco_Custo = decimal.Parse(textBoxPrecoCusto.Text),
                Preco_Medio = 0.00m,
                Quantidade = int.Parse(textBoxQuantidade.Text),
                Subtotal = int.Parse(comboBoxCategProd.SelectedValue.ToString()),
            };

            ItensCompraProdutosDAO itensDAO = new ItensCompraProdutosDAO();
            if (buttonCadastrar.Text == "Cadastrar")
            {
                itensDAO.CadastrarItensCompra(itens);
            }

            Produto prod = new Produto
            {
                Nome = textBoxNomeProd.Text,
                Marca = textBoxMarca.Text,
                Cor = textBoxCor.Text,
                Tamanho = textBoxTamanho.Text,
                Descricao = textBoxDescrição.Text,
                Preco_Venda = decimal.Parse(textBoxPrecoVenda.Text),
                Preco_Medio = 0.00m,
                Estoque = int.Parse(textBoxQuantidade.Text),
                Id_Cat_Prod = int.Parse(comboBoxCategProd.SelectedValue.ToString()),
                Id_Cat_Pub = int.Parse(comboBoxCategPub.SelectedValue.ToString()),
            };

            ProdutoDAO produtoDAO = new ProdutoDAO();
            bool sucessoprod = false;
            if (buttonCadastrar.Text == "Cadastrar")
            {
                sucessoprod = produtoDAO.CadastrarProduto(prod);
            }

            if (sucessocompra && sucessoprod)
            {
                new Helpers().LimparTela(this);
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";
                CompraProdutosDAO compradao = new CompraProdutosDAO();
                CompraProdutos compras = new CompraProdutos();
                dataGridViewCompras.DataSource = compradao.ListarCompras(compras);
            }
        }

        private void buttonAddNovaIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
