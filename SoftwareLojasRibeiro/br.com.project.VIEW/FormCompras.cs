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

            carrinhoCompras.Columns.Add("Fornecedor", typeof(string));
            carrinhoCompras.Columns.Add("Produto", typeof(string));
            carrinhoCompras.Columns.Add("Marca", typeof(string));
            carrinhoCompras.Columns.Add("Cor", typeof(string));
            carrinhoCompras.Columns.Add("Tamanho", typeof(string));
            carrinhoCompras.Columns.Add("Categ Prod", typeof(string));
            carrinhoCompras.Columns.Add("Categ Pub", typeof(string));
            carrinhoCompras.Columns.Add("Descrição", typeof(string));
            carrinhoCompras.Columns.Add("Quantidade", typeof(int));
            carrinhoCompras.Columns.Add("Preço Custo", typeof(decimal));
            carrinhoCompras.Columns.Add("Subtotal", typeof(decimal));
            carrinhoCompras.Columns.Add("Preço Venda", typeof(decimal));

            dataGridViewComprasCarrinho.DataSource = carrinhoCompras;
        }

        public void SelecionarLinhaTabelaComprasDetalhes()
        {
            ////passando id da venda para a tela de detalhes
            //string idvenda = dataGridViewCompras.CurrentRow.Cells[0].Value.ToString() ?? "";

            //FormDetalhesVendas tela = new FormDetalhesVendas(idvenda);

            ////Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            //if (dataGridViewCompras.CurrentRow != null)
            //{
            //    datavenda = Convert.ToDateTime(dataGridViewHistorico.CurrentRow.Cells[2].Value.ToString() ?? "");
            //    //Pegar os dados da linha selecionada
            //    tela.textBoxNomeCliente.Text = dataGridViewHistorico.CurrentRow.Cells[1].Value.ToString() ?? "";
            //    tela.maskedTextBoxDataVenda.Text = datavenda.ToString("dd/MM/yyyy");
            //    tela.textBoxTotal.Text = dataGridViewHistorico.CurrentRow.Cells[3].Value.ToString() ?? "";
            //    tela.textBoxValorPago.Text = dataGridViewHistorico.CurrentRow.Cells[5].Value.ToString() ?? "";

            //    // Obter as formas de pagamento
            //    List<Pagamento> pagamentos = pagaDAO.RetornarPagamentos(idvenda);
            //    StringBuilder sbPagamentos = new StringBuilder();

            //    sbPagamentos.AppendLine("Forma(s) de Pagamento:");
            //    if (pagamentos != null && pagamentos.Count > 0)
            //    {
            //        foreach (var pagamento in pagamentos)
            //        {
            //            sbPagamentos.AppendLine($"{pagamento.Forma_Pagamento}: R${pagamento.Valor_Pago:F2}");
            //        }
            //    }
            //    else
            //    {
            //        sbPagamentos.AppendLine("Nenhuma Forma de Pagamento foi encontrada.");
            //    }

            //    // Concatenar as informações de pagamento com as observações
            //    string observacoes = "\n" + dataGridViewHistorico.CurrentRow.Cells[7].Value.ToString() ?? "";
            //    tela.textBoxObs.Text = sbPagamentos.ToString() + observacoes;

            //    tela.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        public void SelecionarLinhaTabelaCompras()
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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            subtotal = decimal.Parse(textBoxPrecoCusto.Text) * int.Parse(textBoxQuantidade.Text);
            
            carrinhoCompras.Rows.Add(comboBoxFornecedor.Text, textBoxNomeProd.Text, textBoxMarca.Text, 
                textBoxCor.Text, textBoxTamanho.Text, comboBoxCategProd.Text, comboBoxCategPub.Text, 
                textBoxDescrição.Text, textBoxQuantidade.Text, decimal.Parse(textBoxPrecoCusto.Text), 
                subtotal, decimal.Parse(textBoxPrecoVenda.Text));
            
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            bool confimacao = new Helpers().Confirmacao();
            if (confimacao == false)
            {
                return;
            }

            // Exibir o InputBox para obter a observação
            string observacao = Helpers.InputBox("Digite a observação para a compra:", "Observação");

            double total = double.Parse(textBoxTotalCompra.Text);

            CompraProdutos compra = new CompraProdutos
            {
                Total_Compra = total,
                Observacoes = observacao,
            };

            CompraProdutosDAO compraProdutosDAO = new CompraProdutosDAO();

            bool sucessocompra = false;
            sucessocompra = compraProdutosDAO.CadastrarCompra(compra);

            string lastcompra = compraProdutosDAO.RetornarIdLastCompra();

            bool sucessoprod = false;
            CategoriaDAO catDAO = new CategoriaDAO();
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            foreach (DataRow linha in carrinhoCompras.Rows)
            {
                int idprod = catDAO.RetornarIdCat("produto", linha["Categ Prod"].ToString());
                int idpub = catDAO.RetornarIdCat("publico", linha["Categ Pub"].ToString());
                int idforn = fornecedorDAO.RetornarIdFornecedor(linha["Fornecedor"].ToString());
                if (idprod == 0 || idpub == 0 || idforn == 0)
                {
                    MessageBox.Show("Erro ao cadastrar produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ItensCompraProdutos item = new ItensCompraProdutos
                {
                    Id_Compra = lastcompra,
                    Id_Fornecedor = idforn.ToString(),
                    Nome_Produto = linha["Produto"].ToString(),
                    Marca = linha["Marca"].ToString(),
                    Cor = linha["Cor"].ToString(),
                    Tamanho = linha["Tamanho"].ToString(),
                    Descricao = linha["Descrição"].ToString(),
                    Quantidade = int.Parse(linha["Quantidade"].ToString()),
                    Id_Cat_Prod = idprod,
                    Id_Cat_Publ = idpub,
                    Preco_Custo = decimal.Parse(linha["Preço Custo"].ToString()),
                    Preco_Medio = 0.00m,
                    Subtotal = decimal.Parse(linha["Subtotal"].ToString()),
                };

                Produto prod = new Produto
                {
                    Nome = linha["Produto"].ToString(),
                    Marca = linha["Marca"].ToString(),
                    Cor = linha["Cor"].ToString(),
                    Tamanho = linha["Tamanho"].ToString(),
                    Descricao = linha["Descrição"].ToString(),
                    Preco_Venda = decimal.Parse(linha["Preço Venda"].ToString()),
                    Preco_Medio = 0.00m,
                    Estoque = int.Parse(linha["Quantidade"].ToString()),
                    Id_Cat_Prod = idprod,
                    Id_Cat_Pub = idpub,
                };

                ProdutoDAO produtoDAO = new ProdutoDAO();
                
                produtoDAO.CadastrarProduto(prod);
                sucessoprod = true;

                ItensCompraProdutosDAO icdao = new ItensCompraProdutosDAO();
                icdao.CadastrarItensCompra(item);
                sucessocompra = true;
            }

            if (sucessocompra && sucessoprod)
            {
                new Helpers().LimparTelaVendas(this);
                //buttonCadastrar.Text = "Cadastrar";
                //tabPageCadastrar.Text = "Cadastrar";
                CompraProdutosDAO compradao = new CompraProdutosDAO();
                CompraProdutos compras = new CompraProdutos();
                dataGridViewCompras.DataSource = compradao.ListarCompras(compras);
            }

            //MessageBox.Show("Compra registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddNovaIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
