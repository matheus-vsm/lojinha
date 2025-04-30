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
    public partial class FormLogin : BaseForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            new Helpers().AjustarControles(this); // Salva os tamanhos originais dos controles
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string login = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha Todos os Campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario funcionario = new Funcionario();
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            funcionario.Login = login;
            string id = funcDAO.RetornarIdLoginUsuario(funcionario).ToString();
            funcionario.Id = id;

            funcionario.Senha = funcDAO.ObterSenhaFuncionario(id);

            if (funcDAO.Login(funcionario))
            {
                FormMenu tela = new FormMenu();
                tela.Show();
                this.Hide();
            }
        }

        #region Lixos
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}
