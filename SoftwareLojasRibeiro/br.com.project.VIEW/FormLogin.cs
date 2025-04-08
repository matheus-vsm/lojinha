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
    public partial class FormLogin : BaseForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            //Botão entrar
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            FuncionarioDAO dAO = new FuncionarioDAO();

            dAO.EfetuarLogin(usuario, senha);

            if (dAO.EfetuarLogin(usuario, senha) == true)
            {
                FormMenu menu = new FormMenu();
                menu.Show();

                this.Hide();

            }
        }
    }
}
