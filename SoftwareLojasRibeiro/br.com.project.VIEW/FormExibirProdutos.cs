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
    public partial class FormExibirProdutos: Form
    {
        private Form telinha; //para passar os dados da tabela para a tela de vendas
        public FormExibirProdutos(Form tela)
        {
            InitializeComponent();
            telinha = tela;
            FormClosed += FormExibirProdutos_FormClosed;
            //labelTeste.Text += telinha.Text;
        }

        private void FormExibirProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar se o formulário de destino possui o controle "textBoxQuantidade"
            var textBoxQuantidade = telinha.Controls.Find("textBoxQuantidade", true).FirstOrDefault() as TextBox;
            var textBoxPrecoCusto = telinha.Controls.Find("textBoxPrecoCusto", true).FirstOrDefault() as TextBox;
            
            if(telinha.Text == "Lojas Ribeiro - Vendas")
            {
                if (textBoxQuantidade != null)
                {
                    telinha.BeginInvoke((Action)(() =>
                    {
                        textBoxQuantidade.Focus();
                    }));
                }
            }
            else
            {
                if (textBoxPrecoCusto != null)
                {
                    telinha.BeginInvoke((Action)(() =>
                    {
                        textBoxPrecoCusto.Focus();
                    }));
                }
            }
        }

        private void FormExibirProdutos_Load(object sender, EventArgs e)
        {
            ProdutoDAO prodao = new ProdutoDAO();
            Produto prod = new Produto();
            dataGridViewProds.DataSource = prodao.ListarProdutos(prod);

            dataGridViewProds.DefaultCellStyle.Font = new Font("Arial Rounded MT", 12);
            dataGridViewProds.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 14, FontStyle.Bold);
            dataGridViewProds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProds.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            new Helpers().AjustarControles(this); // Salva os tamanhos originais dos controles
        }

        public void Pesquisar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto prod = new Produto { Nome = textBoxPesquisar.Text };
            dataGridViewProds.DataSource = dao.ListarProdutos(prod);
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            Produto prod = new Produto { Nome = textBoxPesquisar.Text };
            ProdutoDAO dao = new ProdutoDAO();
            dataGridViewProds.DataSource = dao.ListarProdutos(prod);
        }

        private void dataGridViewProds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se uma linha está selecionada
            if (dataGridViewProds.CurrentRow == null || dataGridViewProds.CurrentRow.Index < 0)
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se o formulário de destino é "Lojas Ribeiro - Vendas"
            if (telinha.Text == "Lojas Ribeiro - Vendas")
            {
                // Localizar os controles dinamicamente no formulário "telinha"
                var textBoxID = telinha.Controls.Find("textBoxID", true).FirstOrDefault() as TextBox;
                var textBoxDescricao = telinha.Controls.Find("textBoxDescricao", true).FirstOrDefault() as TextBox;
                var textBoxPreco = telinha.Controls.Find("textBoxPreco", true).FirstOrDefault() as TextBox;
                var textBoxEstoque = telinha.Controls.Find("textBoxEstoque", true).FirstOrDefault() as TextBox;
                var textBoxQuantidade = telinha.Controls.Find("textBoxQuantidade", true).FirstOrDefault() as TextBox;

                if (textBoxID != null)
                    textBoxID.Text = dataGridViewProds.CurrentRow.Cells[0].Value.ToString();
                if (textBoxDescricao != null)
                    textBoxDescricao.Text = dataGridViewProds.CurrentRow.Cells[2].Value.ToString();
                if (textBoxPreco != null)
                    textBoxPreco.Text = dataGridViewProds.CurrentRow.Cells[6].Value.ToString();
                if (textBoxEstoque != null)
                    textBoxEstoque.Text = dataGridViewProds.CurrentRow.Cells[7].Value.ToString();

                if (textBoxID != null)
                    textBoxID.ReadOnly = true;
                textBoxPreco.ReadOnly = false;
                textBoxQuantidade.ReadOnly = false;
            }
            else
            {
                // Localizar os controles dinamicamente no formulário "telinha"
                var comboBoxCategProd = telinha.Controls.Find("comboBoxCategProd", true).FirstOrDefault() as ComboBox;
                var comboBoxCategPub = telinha.Controls.Find("comboBoxCategPub", true).FirstOrDefault() as ComboBox;
                var textBoxNomeProd = telinha.Controls.Find("textBoxNomeProd", true).FirstOrDefault() as TextBox;
                var textBoxMarca = telinha.Controls.Find("textBoxMarca", true).FirstOrDefault() as TextBox;
                var textBoxTamanho = telinha.Controls.Find("textBoxTamanho", true).FirstOrDefault() as TextBox;
                var textBoxCor = telinha.Controls.Find("textBoxCor", true).FirstOrDefault() as TextBox;
                var textBoxDescricao = telinha.Controls.Find("textBoxDescricao", true).FirstOrDefault() as TextBox;
                var textBoxPrecoVenda = telinha.Controls.Find("textBoxPrecoVenda", true).FirstOrDefault() as TextBox;

                if (comboBoxCategProd != null)
                    comboBoxCategProd.Text = dataGridViewProds.CurrentRow.Cells[9].Value.ToString();
                if (comboBoxCategPub != null)
                    comboBoxCategPub.Text = dataGridViewProds.CurrentRow.Cells[11].Value.ToString();
                if (textBoxNomeProd != null)
                    textBoxNomeProd.Text = dataGridViewProds.CurrentRow.Cells[2].Value.ToString();
                if (textBoxMarca != null)
                    textBoxMarca.Text = dataGridViewProds.CurrentRow.Cells[3].Value.ToString();
                if (textBoxTamanho != null)
                    textBoxTamanho.Text = dataGridViewProds.CurrentRow.Cells[5].Value.ToString();
                if (textBoxCor != null)
                    textBoxCor.Text = dataGridViewProds.CurrentRow.Cells[4].Value.ToString();
                if (textBoxDescricao != null)
                    textBoxDescricao.Text = dataGridViewProds.CurrentRow.Cells[12].Value.ToString();
                if (textBoxPrecoVenda != null)
                    textBoxPrecoVenda.Text = dataGridViewProds.CurrentRow.Cells[6].Value.ToString();
            }

            this.Close();
        }

        #region Lixos
        private void dataGridViewProds_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        #endregion
    }
}
