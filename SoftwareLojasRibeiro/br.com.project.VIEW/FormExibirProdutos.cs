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
        private FormVendas telavendas; //para passar os dados da tabela para a tela de vendas
        public FormExibirProdutos(FormVendas telavendas)
        {
            InitializeComponent();
            this.telavendas = telavendas;
            this.FormClosed += FormExibirProdutos_FormClosed;
        }

        private void FormExibirProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            telavendas.BeginInvoke((Action)(() =>
            {
                telavendas.textBoxQuantidade.Focus();
            }));
        }

        private void FormExibirProdutos_Load(object sender, EventArgs e)
        {
            ProdutoDAO prodao = new ProdutoDAO();
            Produto prod = new Produto();
            dataGridViewProds.DataSource = prodao.ListarProdutos(prod);
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
            telavendas.textBoxID.Text = dataGridViewProds.CurrentRow.Cells[0].Value.ToString();
            telavendas.textBoxDescrição.Text = dataGridViewProds.CurrentRow.Cells[1].Value.ToString();
            telavendas.textBoxPreco.Text = dataGridViewProds.CurrentRow.Cells[5].Value.ToString();
            telavendas.textBoxEstoque.Text = dataGridViewProds.CurrentRow.Cells[6].Value.ToString();
            telavendas.textBoxID.ReadOnly = true;
            this.Close();
        }

        private void dataGridViewProds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
