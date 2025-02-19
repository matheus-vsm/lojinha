using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormPagamentos: Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        public FormPagamentos(Cliente cli, DataTable carr)
        {
            InitializeComponent();
            cliente = cli;
            carrinho = carr;
        }
    }
}
