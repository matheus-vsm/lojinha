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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormClientes telacli = new FormClientes();
            telacli.Show();
            this.Hide();
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios telacli = new FormFuncionarios();
            telacli.Show();
            this.Hide();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            //FormFuncionarios telacli = new FormFuncionarios();
            //telacli.Show();
            //this.Hide();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos telacli = new FormProdutos();
            telacli.Show();
            this.Hide();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            FormVendas telacli = new FormVendas();
            telacli.Show();
            this.Hide();
        }
    }
}
