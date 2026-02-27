using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormProdutos : BaseForm
    {
        Helpers help = new Helpers();

        public FormProdutos()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            comboBoxCategProd.DataSource = catdao.ListarNomeCategorias("Produto");
            comboBoxCategProd.DisplayMember = "Nome";
            comboBoxCategProd.ValueMember = "Id_Categoria_Prod";

            comboBoxCategPub.DataSource = catdao.ListarNomeCategorias("Publico");
            comboBoxCategPub.DisplayMember = "Nome";
            comboBoxCategPub.ValueMember = "Id_Categoria_Pub";

            ProdutoDAO prodao = new ProdutoDAO();
            Produto prod = new Produto();
            dataGridViewProdutos.DataSource = prodao.ListarProdutos(prod);
            dataGridViewProdutosOff.DataSource = prodao.ListarProdutosDesativados(prod);

            List<DataGridView> tabelas = new List<DataGridView>
            {
                dataGridViewProdutos,
                dataGridViewProdutosOff
            };

            foreach (DataGridView t in tabelas)
            {
                t.DefaultCellStyle.Font = new Font("Arial Rounded MT", 16);
                t.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 18, FontStyle.Bold);
                t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

            toolStripStatusLabelUsuario.Text = FormMenu.nomeusuariologado;
            toolStripStatusLabelTipoUsuario.Text = FormMenu.tipousuariologado;

            help.ConfigurarLinkToolStrip(toolStripStatusLabelDevMath, "https://www.linkedin.com/in/matheus-v-275924208/");

            help.LimparTela(this);
            help.AjustarControles(this); // Salva os tamanhos originais dos controles
        }

        public void SelecionarLinhaTabelaProdutos()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewProdutos.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNomeProd.Text = dataGridViewProdutos.CurrentRow.Cells[2].Value.ToString() ?? "";
                textBoxMarca.Text = dataGridViewProdutos.CurrentRow.Cells[3].Value.ToString() ?? "";
                textBoxCor.Text = dataGridViewProdutos.CurrentRow.Cells[4].Value.ToString() ?? "";
                textBoxTamanho.Text = dataGridViewProdutos.CurrentRow.Cells[5].Value.ToString() ?? "";
                textBoxPreco.Text = dataGridViewProdutos.CurrentRow.Cells[6].Value.ToString() ?? "";
                textBoxEstoque.Text = dataGridViewProdutos.CurrentRow.Cells[7].Value.ToString() ?? "";
                comboBoxCategProd.Text = dataGridViewProdutos.CurrentRow.Cells[9].Value.ToString() ?? "";
                comboBoxCategPub.Text = dataGridViewProdutos.CurrentRow.Cells[11].Value.ToString() ?? "";
                textBoxDescrição.Text = dataGridViewProdutos.CurrentRow.Cells[12].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Pesquisar(string nome, DataGridView tabela)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto prod = new Produto { Nome = nome };
            tabela.DataSource = dao.ListarProdutos(prod);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!Helpers.VerificarCamposPreenchidos(this, new List<string> { "textBoxID" }, "tabPageCadastrar"))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Produto prod = new Produto
            {
                Nome = textBoxNomeProd.Text,
                Marca = textBoxMarca.Text,
                Cor = textBoxCor.Text,
                Tamanho = textBoxTamanho.Text,
                Descricao = textBoxDescrição.Text,
                Preco_Venda = decimal.Parse(textBoxPreco.Text),
                Preco_Medio = 0.00m,
                Estoque = int.Parse(textBoxEstoque.Text),
                Id_Cat_Prod = int.Parse(comboBoxCategProd.SelectedValue.ToString()),
                Id_Cat_Pub = int.Parse(comboBoxCategPub.SelectedValue.ToString()),
            };

            ProdutoDAO dao = new ProdutoDAO();
            bool sucesso = false;

            if (buttonCadastrar.Text == "Cadastrar")
            {
                sucesso = dao.CadastrarProduto(prod);
            }
            else if (buttonCadastrar.Text == "Alterar")
            {
                prod.Id = textBoxID.Text;
                sucesso = dao.AlterarProduto(prod);
            }

            if (sucesso)
            {
                help.LimparTela(this);
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";

                prod= new Produto();
                dataGridViewProdutos.DataSource = dao.ListarProdutos(prod);
            }
            comboBoxCategProd.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            help.LimparTela(this);
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
            comboBoxCategProd.Focus();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaProdutos();
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            tabControlProdutos.SelectedTab = tabPageCadastrar;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Desativar esse Produto?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produto prod = new Produto { Id = dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString() ?? "" };

            ProdutoDAO dao = new ProdutoDAO();
            //dao.ExcluirProduto(prod);
            dao.DesativarProduto(prod);
            dataGridViewProdutos.DataSource = dao.ListarProdutos(prod); //atualizar tabela
            dataGridViewProdutosOff.DataSource = dao.ListarProdutosDesativados(prod); //atualizar tabela
        }

        private void buttonAtivar_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Ativar esse Produto?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produto prod = new Produto { Id = dataGridViewProdutosOff.CurrentRow.Cells[0].Value.ToString() ?? "" };

            ProdutoDAO dao = new ProdutoDAO();
            //dao.ExcluirProduto(prod);
            dao.AtivarProduto(prod);
            dataGridViewProdutos.DataSource = dao.ListarProdutos(prod); //atualizar tabela
            dataGridViewProdutosOff.DataSource = dao.ListarProdutosDesativados(prod); //atualizar tabela
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaProd.Text, dataGridViewProdutos);
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisaProd.Clear();
            Pesquisar(textBoxPesquisaProd.Text, dataGridViewProdutos);
        }

        private void buttonLimparPesquisaOff_Click(object sender, EventArgs e)
        {
            textBoxPesquisaProdOff.Clear();
            Pesquisar(textBoxPesquisaProdOff.Text, dataGridViewProdutosOff);
        }

        private void textBoxPesquisaProd_TextChanged(object sender, EventArgs e)
        {
            Produto prod = new Produto { Nome = textBoxPesquisaProd.Text };
            ProdutoDAO dao = new ProdutoDAO();
            dataGridViewProdutos.DataSource = dao.ListarProdutos(prod);
        }

        private void textBoxPesquisaProdOff_TextChanged(object sender, EventArgs e)
        {
            Produto prod = new Produto { Nome = textBoxPesquisaProdOff.Text };
            ProdutoDAO dao = new ProdutoDAO();
            dataGridViewProdutosOff.DataSource = dao.ListarProdutosDesativados(prod);
        }

        #region Lixos
        private void comboBoxCategProd_SelectedIndexChanged(object sender, EventArgs e) { }
        #endregion
    }
}
