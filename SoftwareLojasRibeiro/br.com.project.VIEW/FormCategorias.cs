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
    public partial class FormCategorias : BaseForm
    {
        Helpers help = new Helpers();

        public FormCategorias()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria { Nome = textBoxPesquisaNomeProd.Text };
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto");
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico");
            dataGridViewCatProdOff.DataSource = dao.ListarCategoriasDesativadas(cat, "Produto");
            dataGridViewCatPubOff.DataSource = dao.ListarCategoriasDesativadas(cat, "Publico");

            List<DataGridView> tabelas = new List<DataGridView>
            {
                dataGridViewCatProd,
                dataGridViewCatPub,
                dataGridViewCatProdOff,
                dataGridViewCatPubOff
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
            help.ConfigurarLinkToolStrip(toolStripStatusLabelDevLeandro, "https://www.linkedin.com/in/matheus-v-275924208/");

            help.AjustarControles(this); // Salva os tamanhos originais dos controles
        }

        public void SelecionarLinhaTabelaCategoriasProdutos()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewCatProd.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewCatProd.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNome.Text = dataGridViewCatProd.CurrentRow.Cells[2].Value.ToString() ?? "";
                textBoxDescricao.Text = dataGridViewCatProd.CurrentRow.Cells[3].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SelecionarLinhaTabelaCategoriasPublico()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewCatPub.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewCatPub.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNome.Text = dataGridViewCatPub.CurrentRow.Cells[2].Value.ToString() ?? "";
                textBoxDescricao.Text = dataGridViewCatPub.CurrentRow.Cells[3].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Pesquisar(string nome, DataGridView tabela)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria { Nome = nome };
            tabela.DataSource = dao.ListarCategorias(cat, "Produto");
            tabela.DataSource = dao.ListarCategoriasDesativadas(cat, "Produto");
        }

        public bool VerificacaoAtivaDesativa(string opcao)
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show($"Tem certeza que deseja {opcao} essa Categoria?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
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
            if (!Helpers.VerificarCamposPreenchidos(this, new List<string> { "textBoxID" }, "tabPageCadastrar"))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Receber os dados dentro do objeto modelo de Cliente
            Categoria cat = new Categoria
            {
                Nome = textBoxNome.Text,
                Descricao = textBoxDescricao.Text,
            };

            //Criar um objeto da classe ClienteDAO e chamar o método CadastrarCliente
            CategoriaDAO dao = new CategoriaDAO();
            bool sucesso = false; // Variável para verificar sucesso da operação

            if (buttonCadastrar.Text == "Cadastrar")
            {
                if (comboBoxTipoCat.SelectedIndex == 0)
                {
                    sucesso = dao.CadastrarCategoria(cat, "Produto");
                }
                else
                {
                    sucesso = dao.CadastrarCategoria(cat, "Publico");
                }
            }
            else if (buttonCadastrar.Text == "Alterar")
            {
                cat.Id = textBoxID.Text;
                if (comboBoxTipoCat.SelectedIndex == 0)
                {
                    sucesso = dao.AlterarCategoria(cat, "Produto");
                }
                else
                {
                    sucesso = dao.AlterarCategoria(cat, "Publico");
                }
                comboBoxTipoCat.Enabled = true;
            }

            if (sucesso)
            {
                //LimparCampos();
                help.LimparTela(this);
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";

                // Criar novo objeto vazio
                cat = new Categoria();

                dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto"); //atualizar tabela
                dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico"); //atualizar tabela
            }
            comboBoxTipoCat.Focus();
        }

        private void buttonPesquisarProd_Click(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomeProd.Text, dataGridViewCatProd);
        }

        private void buttonPesquisarPub_Click(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomePub.Text, dataGridViewCatPub);
        }

        private void buttonPesquisarProdOff_Click(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomeProdOff.Text, dataGridViewCatProdOff);
        }

        private void buttonPesquisarPubOff_Click(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomePubOff.Text, dataGridViewCatPubOff);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            help.LimparTela(this);
            comboBoxTipoCat.Enabled = true;
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
            comboBoxTipoCat.Focus();
        }

        private void buttonLimparPesquisaProd_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomeProd.Clear();
            Pesquisar(textBoxPesquisaNomeProd.Text, dataGridViewCatProd);
        }

        private void buttonPub_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomePub.Clear();
            Pesquisar(textBoxPesquisaNomePub.Text, dataGridViewCatPub);
        }

        private void buttonLimparProdOff_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomeProdOff.Clear();
            Pesquisar(textBoxPesquisaNomeProdOff.Text, dataGridViewCatProdOff);
        }

        private void buttonLimparPubOff_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomePubOff.Clear();
            Pesquisar(textBoxPesquisaNomePubOff.Text, dataGridViewCatPubOff);
        }

        private void buttonAlterarProd_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaCategoriasProdutos();
            comboBoxTipoCat.Text = "Produto";
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            comboBoxTipoCat.Enabled = false;
            tabControlCategorias.SelectedTab = tabPageCadastrar;
        }

        private void buttonAlterarPub_Click(object sender, EventArgs e)
        {
            SelecionarLinhaTabelaCategoriasPublico();
            comboBoxTipoCat.Text = "Publico";
            buttonCadastrar.Text = "Alterar";
            tabPageCadastrar.Text = "Alterar";
            comboBoxTipoCat.Enabled = false;
            tabControlCategorias.SelectedTab = tabPageCadastrar;
        }

        private void buttonExcluirProd_Click(object sender, EventArgs e)
        {
            if (!VerificacaoAtivaDesativa("Excluir"))
            {
                return;
            }

            Categoria cat = new Categoria();
            cat.Id = dataGridViewCatProd.CurrentRow.Cells[0].Value.ToString() ?? "";

            CategoriaDAO dao = new CategoriaDAO();
            //dao.ExcluirCategoria(cat, "Produto");
            dao.DesativarCategoria(cat, "Produto");
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto"); //atualizar tabela
            dataGridViewCatProdOff.DataSource = dao.ListarCategoriasDesativadas(cat, "Produto"); //atualizar tabela
        }

        private void buttonExcluirPub_Click(object sender, EventArgs e)
        {
            if (!VerificacaoAtivaDesativa("Excluir"))
            {
                return;
            }

            Categoria cat = new Categoria();
            cat.Id = dataGridViewCatPub.CurrentRow.Cells[0].Value.ToString() ?? "";

            CategoriaDAO dao = new CategoriaDAO();
            //dao.ExcluirCategoria(cat, "Publico");
            dao.DesativarCategoria(cat, "Publico");
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico"); //atualizar tabela
            dataGridViewCatPubOff.DataSource = dao.ListarCategoriasDesativadas(cat, "Publico"); //atualizar tabela
        }

        private void buttonAtivarProd_Click(object sender, EventArgs e)
        {
            if (!VerificacaoAtivaDesativa("Ativar"))
            {
                return;
            }

            Categoria cat = new Categoria();
            cat.Id = dataGridViewCatProdOff.CurrentRow.Cells[0].Value.ToString() ?? "";

            CategoriaDAO dao = new CategoriaDAO();
            //dao.ExcluirCategoria(cat, "Produto");
            dao.AtivarCategoria(cat, "Produto");
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto"); //atualizar tabela
            dataGridViewCatProdOff.DataSource = dao.ListarCategoriasDesativadas(cat, "Produto"); //atualizar tabela
        }

        private void buttonAtivarPub_Click(object sender, EventArgs e)
        {
            if (!VerificacaoAtivaDesativa("Ativar"))
            {
                return;
            }

            Categoria cat = new Categoria();
            cat.Id = dataGridViewCatPubOff.CurrentRow.Cells[0].Value.ToString() ?? "";

            CategoriaDAO dao = new CategoriaDAO();
            //dao.ExcluirCategoria(cat, "Publico");
            dao.AtivarCategoria(cat, "Publico");
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico"); //atualizar tabela
            dataGridViewCatPubOff.DataSource = dao.ListarCategoriasDesativadas(cat, "Publico"); //atualizar tabela
        }

        private void textBoxPesquisaNomeProd_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomeProd.Text, dataGridViewCatProd);
        }

        private void textBoxPesquisaNomePub_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomePub.Text, dataGridViewCatPub);
        }

        private void textBoxPesquisaNomeProdOff_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomeProdOff.Text, dataGridViewCatProdOff);
        }

        private void textBoxPesquisaNomePubOff_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBoxPesquisaNomePubOff.Text, dataGridViewCatPubOff);
        }

        #region Lixos
        private void buttonLimparPesquisa_Click(object sender, EventArgs e) { }
        private void buttonExcluir_Click(object sender, EventArgs e) { }
        private void buttonAlterar_Click(object sender, EventArgs e) { }
        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void buttonPesquisar_Click(object sender, EventArgs e) { }
        #endregion
    }
}
