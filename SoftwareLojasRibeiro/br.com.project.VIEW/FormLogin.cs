using MySqlX.XDevAPI;
using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public partial class FormLogin : BaseForm
    {
        public static string nomeusuario;
        public static string tipousuario;
        Helpers help = new Helpers();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            help.AjustarControles(this); // Salva os tamanhos originais dos controles
            help.ConfigurarLinkToolStrip(toolStripStatusLabelDevMath, "https://www.linkedin.com/in/matheus-v-275924208/");
            help.ConfigurarLinkToolStrip(toolStripStatusLabelDevLeandro, "https://www.linkedin.com/in/matheus-v-275924208/");
        }

        private void FormLogin_Resize(object sender, EventArgs e) { }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string login = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            string senhahash = help.HashSenhaVerificacao(senha);

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

            Usuario usuariologado;

            if (funcDAO.Login(funcionario, senha))
            {
                usuariologado = new Usuario(funcDAO.RetorndarDadosUsuarioLogado(funcionario));
                nomeusuario = usuariologado.ToString();
                tipousuario = usuariologado.ToString();
                this.Hide();
            }
        }

        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) buttonEntrar_Click(this, EventArgs.Empty);
        }

        #region Lixos
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}
