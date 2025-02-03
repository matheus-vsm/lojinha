using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareLojasRibeiro.br.com.project.DAO;
using SoftwareLojasRibeiro.br.com.project.MODEL;

namespace SoftwareLojasRibeiro
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dataGridViewClientes.DataSource = dao.ListarClientes();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Receber os dados dentro do objeto modelo de Cliente
            Cliente cli = new Cliente
            {
                Nome = textBoxNome.Text,
                Rg = maskedTextBoxRg.Text.Replace(',', '.'),
                Cpf = maskedTextBoxCpf.Text.Replace(',', '.'),
                Numero = maskedTextBoxNumero.Text,
                Datanasc = DateTime.Parse(maskedTextBoxData.Text),
                Email = textBoxEmail.Text,
                Endereco = textBoxEndereco.Text
            };

            //Criar um objeto da classe ClienteDAO e chamar o método CadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(cli);

        }
    }
}
