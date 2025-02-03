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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            dataGridViewClientes.DataSource = dao.ListarClientes(cli);
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

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cli = new Cliente { Nome = textBoxPesquisaNome.Text };
            dataGridViewClientes.DataSource = dao.ListarClientes(cli);
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewClientes.CurrentRow != null)
            {
                //Pegar os dados da linha selecionada
                textBoxNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString() ?? "";
                maskedTextBoxRg.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() ?? "";
                maskedTextBoxCpf.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString() ?? "";
                maskedTextBoxNumero.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString() ?? "";
                textBoxEmail.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString() ?? "";
                maskedTextBoxData.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString() ?? "";
                textBoxEndereco.Text = dataGridViewClientes.CurrentRow.Cells[7].Value.ToString() ?? "";
            }

        }
    }
}
