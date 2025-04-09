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
    public partial class FormDetalhesCompras : Form
    {
        string idcompra;

        public FormDetalhesCompras(string compraid)
        {
            idcompra = compraid;
            InitializeComponent();
        }

        private void textBoxIdCompra_TextChanged(object sender, EventArgs e) { }

        private void FormDetalhesCompras_Load(object sender, EventArgs e)
        {
            ItensCompraProdutosDAO icdao = new ItensCompraProdutosDAO();
            dataGridViewDetalhes.DataSource = icdao.ListarItensCompra(idcompra);

            dataGridViewDetalhes.DefaultCellStyle.Font = new Font("Arial Rounded MT", 16);
            dataGridViewDetalhes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 18, FontStyle.Bold);
            dataGridViewDetalhes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDetalhes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void buttonAdicionarNova_Click(object sender, EventArgs e)
        {
            FormCompras tela = new FormCompras();
            if (dataGridViewDetalhes.CurrentRow != null)
            {
                string forn = tela.comboBoxFornecedor.Text = dataGridViewDetalhes.CurrentRow.Cells[2].Value.ToString() ?? "";
                string nome = tela.textBoxNomeProd.Text = dataGridViewDetalhes.CurrentRow.Cells[3].Value.ToString() ?? "";
                string marca = tela.textBoxMarca.Text = dataGridViewDetalhes.CurrentRow.Cells[4].Value.ToString() ?? "";
                string cor = tela.textBoxCor.Text = dataGridViewDetalhes.CurrentRow.Cells[5].Value.ToString() ?? "";
                string tam = tela.textBoxTamanho.Text = dataGridViewDetalhes.CurrentRow.Cells[6].Value.ToString() ?? "";
                string desc = tela.textBoxDescricao.Text = dataGridViewDetalhes.CurrentRow.Cells[7].Value.ToString() ?? "";
                string catprod = tela.comboBoxCategProd.Text = dataGridViewDetalhes.CurrentRow.Cells[8].Value.ToString() ?? "";
                string catpub = tela.comboBoxCategPub.Text = dataGridViewDetalhes.CurrentRow.Cells[9].Value.ToString() ?? "";
                string precusto = tela.textBoxPrecoCusto.Text = dataGridViewDetalhes.CurrentRow.Cells[11].Value.ToString() ?? "";
                string tot = tela.textBoxTotalCompra.Text = dataGridViewDetalhes.CurrentRow.Cells[12].Value.ToString() ?? "";
                
                this.Hide();
                tela.tabControlCompras.SelectedTab = tela.tabPageCadastrar;
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
