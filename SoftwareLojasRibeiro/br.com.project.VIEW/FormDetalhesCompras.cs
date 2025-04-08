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
    }
}
