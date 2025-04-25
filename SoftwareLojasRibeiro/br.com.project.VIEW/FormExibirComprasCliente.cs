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
    public partial class FormExibirComprasCliente : Form
    {
        string clienteid, clientenome;
        DateTime iniciozada = Convert.ToDateTime("2000-01-01");
        DateTime fimzada = Convert.ToDateTime("3000-01-01");
        PagamentoDAO pagaDAO = new PagamentoDAO();

        public FormExibirComprasCliente(string idcliente, string nomecliente)
        {
            clienteid = idcliente;
            clientenome = nomecliente;
            InitializeComponent();
        }

        private void FormExibirComprasCliente_Load(object sender, EventArgs e)
        {
            labelNomeCliente.Text += clientenome;

            dateTimePickerDataInicio.Value = DateTime.Now;
            dateTimePickerDataFim.Value = DateTime.Now.AddDays(1);

            Cliente cliente = new Cliente { Id = clienteid };
            ClienteDAO cliDAO = new ClienteDAO();
            dataGridViewHistorico.DataSource = cliDAO.ListarCompras(iniciozada, fimzada, cliente);
            textBoxTotal.Text = cliDAO.RetornarTotalCompras(cliente);
            textBoxTotalGasto.Text = cliDAO.RetornarTotalGasto(cliente);
        }


        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            DateTime inicio = Convert.ToDateTime(dateTimePickerDataInicio.Value.ToString("yyyy-MM-dd"));
            DateTime fim = Convert.ToDateTime(dateTimePickerDataFim.Value.ToString("yyyy-MM-dd"));

            Cliente cliente = new Cliente { Id = clienteid };
            ClienteDAO clidao = new ClienteDAO();
            dataGridViewHistorico.DataSource = clidao.ListarCompras(inicio, fim, cliente);
            dataGridViewHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void buttonDetalhes_Click(object sender, EventArgs e)
        {

            //passando id da venda para a tela de detalhes
            string idvenda = dataGridViewHistorico.CurrentRow.Cells[0].Value.ToString() ?? "";

            FormDetalhesVendas tela = new FormDetalhesVendas(idvenda);
            DateTime datavenda;

            //Garantir que a linha esteja realmente selecionada antes de tentar acessa-la
            if (dataGridViewHistorico.CurrentRow != null)
            {
                datavenda = Convert.ToDateTime(dataGridViewHistorico.CurrentRow.Cells[1].Value.ToString() ?? "");
                //Pegar os dados da linha selecionada
                tela.textBoxNomeCliente.Text = clientenome;
                tela.maskedTextBoxDataVenda.Text = datavenda.ToString("dd/MM/yyyy");
                tela.textBoxTotal.Text = dataGridViewHistorico.CurrentRow.Cells[2].Value.ToString() ?? "";
                tela.textBoxValorPago.Text = dataGridViewHistorico.CurrentRow.Cells[4].Value.ToString() ?? "";

                // Obter as formas de pagamento
                List<Pagamento> pagamentos = pagaDAO.RetornarPagamentos(idvenda);
                StringBuilder sbPagamentos = new StringBuilder();

                sbPagamentos.AppendLine("Forma(s) de Pagamento:");
                if (pagamentos != null && pagamentos.Count > 0)
                {
                    foreach (var pagamento in pagamentos)
                    {
                        sbPagamentos.AppendLine($"{pagamento.Forma_Pagamento}: R${pagamento.Valor_Pago:F2}");
                    }
                }
                else
                {
                    sbPagamentos.AppendLine("Nenhuma Forma de Pagamento foi encontrada.");
                }

                // Concatenar as informações de pagamento com as observações
                string observacoes = "\n" + dataGridViewHistorico.CurrentRow.Cells[6].Value.ToString() ?? "";
                tela.textBoxObs.Text = sbPagamentos.ToString() + observacoes;

                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Lixos
        private void labelNomeCliente_Click(object sender, EventArgs e) { }
        private void textBoxTotal_TextChanged(object sender, EventArgs e) { }
        private void textBoxTotalGasto_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}
