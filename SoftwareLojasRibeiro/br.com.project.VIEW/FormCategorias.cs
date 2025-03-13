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
        public FormCategorias()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }

        public void SelecionarLinhaTabelaCategoriasProdutos()
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewCatProd.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxID.Text = dataGridViewCatProd.CurrentRow.Cells[0].Value.ToString() ?? "";
                textBoxNome.Text = dataGridViewCatProd.CurrentRow.Cells[1].Value.ToString() ?? "";
                textBoxDescricao.Text = dataGridViewCatProd.CurrentRow.Cells[2].Value.ToString() ?? "";
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
                textBoxNome.Text = dataGridViewCatPub.CurrentRow.Cells[1].Value.ToString() ?? "";
                textBoxDescricao.Text = dataGridViewCatPub.CurrentRow.Cells[2].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PesquisarProd()
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria { Nome = textBoxPesquisaNomeProd.Text };
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto");
        }
        public void PesquisarPub()
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria { Nome = textBoxPesquisaNomePub.Text };
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico");
        }

        #region lixo
        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu telamenu = new FormMenu();
            telamenu.Show();
            this.Hide();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria { Nome = textBoxPesquisaNomeProd.Text };
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto");
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
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
                new Helpers().LimparTela(this);
                buttonCadastrar.Text = "Cadastrar";
                tabPageCadastrar.Text = "Cadastrar";

                // Criar novo objeto vazio
                cat = new Categoria();

                dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto"); //atualizar tabela
                dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico"); //atualizar tabela
            }
        }

        private void buttonPesquisarProd_Click(object sender, EventArgs e)
        {
            PesquisarProd();
        }

        private void buttonPesquisarPub_Click(object sender, EventArgs e)
        {
            PesquisarPub();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            comboBoxTipoCat.Enabled = true;
            buttonCadastrar.Text = "Cadastrar";
            tabPageCadastrar.Text = "Cadastrar";
        }

        private void buttonLimparPesquisaProd_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomeProd.Clear();
            PesquisarProd();
        }

        private void buttonPub_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNomePub.Clear();
            PesquisarPub();
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
            Categoria cat = new Categoria();
            textBoxID.Text = dataGridViewCatProd.CurrentRow.Cells[0].Value.ToString() ?? "";
            cat.Id = textBoxID.Text;

            CategoriaDAO dao = new CategoriaDAO();
            dao.ExcluirCategoria(cat, "Produto");
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto"); //atualizar tabela
            textBoxID.Clear();
        }

        private void buttonExcluirPub_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            textBoxID.Text = dataGridViewCatPub.CurrentRow.Cells[0].Value.ToString() ?? "";
            cat.Id = textBoxID.Text;

            CategoriaDAO dao = new CategoriaDAO();
            dao.ExcluirCategoria(cat, "Publico");
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico"); //atualizar tabela
            textBoxID.Clear();
        }

        private void textBoxPesquisaNomeProd_TextChanged(object sender, EventArgs e)
        {
            Categoria cat = new Categoria { Nome = textBoxPesquisaNomeProd.Text };
            CategoriaDAO dao = new CategoriaDAO();
            dataGridViewCatProd.DataSource = dao.ListarCategorias(cat, "Produto");
        }

        private void textBoxPesquisaNomePub_TextChanged(object sender, EventArgs e)
        {
            Categoria cat = new Categoria { Nome = textBoxPesquisaNomePub.Text };
            CategoriaDAO dao = new CategoriaDAO();
            dataGridViewCatPub.DataSource = dao.ListarCategorias(cat, "Publico");
        }
    }
}
