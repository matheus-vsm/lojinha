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
        DataTable carrinhoCompras = new DataTable();
        decimal totalcompra, subtotal;

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

            new Helpers().LimparTela(this);

            carrinhoCompras.Columns.Add("Produto", typeof(string));
            carrinhoCompras.Columns.Add("Marca", typeof(string));
            carrinhoCompras.Columns.Add("Cor", typeof(string));
            carrinhoCompras.Columns.Add("Tamanho", typeof(string));
            carrinhoCompras.Columns.Add("Descrição", typeof(string));
            carrinhoCompras.Columns.Add("Quantidade", typeof(int));
            carrinhoCompras.Columns.Add("Preço Custo", typeof(decimal));
            carrinhoCompras.Columns.Add("Subtotal", typeof(decimal));

            dataGridViewComprasCarrinho.DataSource = carrinhoCompras;
        }

        public void SelecionarLinhaTabelaProdutos()
        {
            ////Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewCompras.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                //textBoxID.Text = dataGridViewCompras.CurrentRow.Cells[0].Value.ToString() ?? "";
                //textBoxNomeProd.Text = dataGridViewCompras.CurrentRow.Cells[1].Value.ToString() ?? "";
                //textBoxMarca.Text = dataGridViewCompras.CurrentRow.Cells[2].Value.ToString() ?? "";
                //textBoxCor.Text = dataGridViewCompras.CurrentRow.Cells[3].Value.ToString() ?? "";
                //textBoxTamanho.Text = dataGridViewCompras.CurrentRow.Cells[4].Value.ToString() ?? "";
                //textBoxPreco.Text = dataGridViewCompras.CurrentRow.Cells[5].Value.ToString() ?? "";
                //textBoxEstoque.Text = dataGridViewCompras.CurrentRow.Cells[6].Value.ToString() ?? "";
                //comboBoxCategProd.Text = dataGridViewCompras.CurrentRow.Cells[7].Value.ToString() ?? "";
                //comboBoxCategPub.Text = dataGridViewCompras.CurrentRow.Cells[8].Value.ToString() ?? "";
                //textBoxDescrição.Text = dataGridViewCompras.CurrentRow.Cells[9].Value.ToString() ?? "";
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
                Subtotal = decimal.Parse(total.ToString()),
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

            //foreach (DataRow linha in carrinhoCompras.Rows)
            //{
            //    ItensCompras item = new ItensCompras
            //    {
            //        Id_Venda = vdao.RetornarIdLastVenda(),
            //        Id_Produto = linha["ID"].ToString(),
            //        Quantidade = int.Parse(linha["Quantidade"].ToString()),
            //        Preco_Unitario = double.Parse(linha["Preço"].ToString()),
            //        Subtotal = double.Parse(linha["Subtotal"].ToString()),
            //    };

            //    //remove a quantidade de produtos do estoque
            //    qtdestoque = pdao.RetornaEstoqueAtual(item.Id_Produto);
            //    qtdcomprada = item.Quantidade;

            //    if (qtdestoque < qtdcomprada)
            //    {
            //        MessageBox.Show("Quantidade de produtos insuficiente no estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    qtdatualizada = qtdestoque - qtdcomprada;
            //    pdao.RemoverEstoque(item.Id_Produto, qtdatualizada);

            //    ItensVendaDAO ivdao = new ItensVendaDAO();
            //    ivdao.CadastrarItensVenda(item);
            //}

            //MessageBox.Show("Venda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddNovaIgual_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            subtotal = decimal.Parse(textBoxPrecoCusto.Text) * int.Parse(textBoxQuantidade.Text);
            carrinhoCompras.Rows.Add(textBoxNomeProd.Text, textBoxMarca.Text, textBoxCor.Text, textBoxTamanho.Text, textBoxDescrição.Text, textBoxQuantidade.Text, decimal.Parse(textBoxPrecoCusto.Text), subtotal);
            totalcompra += subtotal;
            textBoxTotalCompra.Text = totalcompra.ToString();

            textBoxNomeProd.Clear();
            textBoxMarca.Clear();
            textBoxCor.Clear();
            textBoxTamanho.Clear();
            textBoxDescrição.Clear();
            textBoxQuantidade.Clear();
            textBoxPrecoCusto.Clear();
            textBoxPrecoVenda.Clear();
            textBoxObs.Clear();
            comboBoxCategProd.SelectedItem = -1;
            comboBoxCategProd.Text = string.Empty;
            comboBoxCategPub.SelectedItem = -1;
            comboBoxCategPub.Text = string.Empty;
            comboBoxFornecedor.SelectedItem = -1;
            comboBoxFornecedor.Text = string.Empty;
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

            decimal subproduto = decimal.Parse(dataGridViewComprasCarrinho.CurrentRow.Cells[7].Value.ToString());
            int indice = dataGridViewComprasCarrinho.CurrentRow.Index; //pega o indice da linha selecionada
            DataRow linha = carrinhoCompras.Rows[indice]; //definindo a linha que será excluída

            carrinhoCompras.Rows.Remove(linha); //removendo a linha
            carrinhoCompras.AcceptChanges(); //atualizando a tabela

            totalcompra -= subproduto;
            textBoxTotalCompra.Text = totalcompra.ToString();

            MessageBox.Show("Produto Removido do Carrinho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
