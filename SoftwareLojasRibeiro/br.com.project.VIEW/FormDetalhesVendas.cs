using SoftwareLojasRibeiro.br.com.project.DAO;
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
    public partial class FormDetalhesVendas : BaseForm
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
        }


    }
}
