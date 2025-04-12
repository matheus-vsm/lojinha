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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormMenu : BaseForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.ActiveControl = null;
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
            FormCategorias telacat = new FormCategorias();
            telacat.Show();
            this.Hide();
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

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedoress telaforne = new FormFornecedoress();
            telaforne.Show();
            this.Hide();
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            FormCompras tela = new FormCompras();
            tela.Show();
            this.Hide();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormLogin tela = new FormLogin();
            tela.Show();
            this.Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D0 || keyData == Keys.NumPad0) // tecla 0
            {
                this.Close();
                return true;
            }
            else if (keyData == Keys.D1 || keyData == Keys.NumPad1) // tecla 1
            {
                buttonClientes_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.D2 || keyData == Keys.NumPad2) // tecla 2
            {
                buttonFuncionarios_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.D3 || keyData == Keys.NumPad3) // tecla 3
            {
                buttonFornecedores_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.D4 || keyData == Keys.NumPad4) // tecla 4
            {
                buttonCategorias_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.D5 || keyData == Keys.NumPad5) // tecla 5
            {
                buttonCompras_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.D6 || keyData == Keys.NumPad6) // tecla 6
            {
                buttonProdutos_Click(this, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.D7 || keyData == Keys.NumPad7) // tecla 7
            {
                buttonVendas_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Lixos
        private void FormMenu_KeyPress(object sender, KeyPressEventArgs e) { }
        #endregion
    }
}
