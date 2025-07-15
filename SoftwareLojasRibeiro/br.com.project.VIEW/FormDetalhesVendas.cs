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
    public partial class FormDetalhesVendas : Form
    {
        string idvenda;
        public FormDetalhesVendas(string vendaid)
        {
            idvenda = vendaid;
            InitializeComponent();
        }

        private void FormDetalhesVendas_Load(object sender, EventArgs e)
        {
            ItensVendaDAO ivdao = new ItensVendaDAO();
            dataGridViewDetalhes.DataSource = ivdao.ListarItensVenda(idvenda);

            dataGridViewDetalhes.DefaultCellStyle.Font = new Font("Arial Rounded MT", 16);
            dataGridViewDetalhes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 18, FontStyle.Bold);
            dataGridViewDetalhes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDetalhes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            new Helpers().AjustarControles(this); // Salva os tamanhos originais dos controles
        }

        #region Lixos
        private void dataGridViewDetalhes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        #endregion
    }
}
