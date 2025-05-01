using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Org.BouncyCastle.Crypto.Generators;
using BCrypt.Net;
using System.Data;
using SoftwareLojasRibeiro.br.com.project.VIEW;
using System.Drawing;
using System.ComponentModel;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Helpers
    {
        #region LimparTela
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                if (ctrPai is TabControl || ctrPai is GroupBox) // Adicionado suporte para GroupBox
                {
                    foreach (Control ctr1 in ctrPai.Controls)
                    {
                        if (ctr1 is TabPage)
                        {
                            foreach (Control ctr2 in ctr1.Controls)
                            {
                                if (ctr2 is TextBox)
                                {
                                    (ctr2 as TextBox).Text = string.Empty;
                                }
                                else if (ctr2 is MaskedTextBox)
                                {
                                    (ctr2 as MaskedTextBox).Text = string.Empty;
                                }
                                else if (ctr2 is ComboBox)
                                {
                                    (ctr2 as ComboBox).SelectedItem = -1;
                                    (ctr2 as ComboBox).Text = string.Empty;
                                }
                                else if (ctr2 is DataGridView dataGridView && dataGridView.Name == "dataGridViewProdutosCarrinho")
                                {
                                    if (dataGridView.DataSource is DataTable dataTable)
                                    {
                                        dataTable.Clear(); // Limpa apenas os dados, mantendo os cabeçalhos
                                    }
                                    else
                                    {
                                        dataGridView.Rows.Clear(); // Se não houver DataSource, remove todas as linhas
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region HashSenha
        // Método para criptografar a senha antes de salvar no banco
        public static string HashSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
        #endregion

        #region HashSenhaVerificacao
        // Método para criptografar a senha antes de salvar no banco
        public string HashSenhaVerificacao(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
        #endregion

        #region VerificarSenha
        // Método para verificar se a senha digitada corresponde ao hash armazenado
        public static bool VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaArmazenada);
        }
        #endregion

        #region FecharOutrasTelas
        public void FecharOutrasTelas(Form currentForm)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if ((form is FormPagamentos || form is FormVendas) && form != currentForm)
                {
                    form.Invoke((Action)(() => form.Close()));
                }
            }
        }
        #endregion

        #region LimparTelaVendas
        public void LimparTelaVendas(Control tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                LimparControle(ctrPai);
            }
        }
        #endregion

        #region LimparTelaCompras
        public void LimparTelaCompras(Control tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                if (ctrPai is DataGridView)
                {
                    // Ignorar DataGridView, não limpar seus dados
                    continue;
                }
                LimparControleMenosTabela(ctrPai);
            }
        }
        #endregion

        #region LimparControleMenosTabela
        private void LimparControleMenosTabela(Control controle)
        {
            if (controle is DataGridView)
            {
                // Ignorar DataGridView completamente
                return;
            }
            else if (controle is TextBox)
            {
                (controle as TextBox).Clear();
            }
            else if (controle is MaskedTextBox)
            {
                (controle as MaskedTextBox).Clear();
            }
            else if (controle is ComboBox)
            {
                (controle as ComboBox).SelectedIndex = -1;
                (controle as ComboBox).Text = string.Empty;
            }
            else if (controle.HasChildren)
            {
                foreach (Control child in controle.Controls)
                {
                    LimparControleMenosTabela(child);
                }
            }
        }
        #endregion

        #region LimparControle
        private void LimparControle(Control controle)
        {
            if (controle is TextBox)
            {
                (controle as TextBox).Clear();
            }
            else if (controle is MaskedTextBox)
            {
                (controle as MaskedTextBox).Clear();
            }
            else if (controle is ComboBox)
            {
                (controle as ComboBox).SelectedIndex = -1;
                (controle as ComboBox).Text = string.Empty;
            }
            else if (controle is DataGridView dataGridView && dataGridView.Name == "dataGridViewProdutosCarrinho")
            {
                if (dataGridView.DataSource is DataTable dataTable)
                {
                    dataTable.Clear(); // Limpa apenas os dados, mantendo os cabeçalhos
                }
                else
                {
                    dataGridView.Rows.Clear(); // Se não houver DataSource, remove todas as linhas
                }
            }
            else if (controle is DataGridView dataGridViews && dataGridViews.Name == "dataGridViewComprasCarrinho")
            {
                if (dataGridViews.DataSource is DataTable dataTable)
                {
                    dataTable.Clear(); // Limpa apenas os dados, mantendo os cabeçalhos
                }
                else
                {
                    dataGridViews.Rows.Clear(); // Se não houver DataSource, remove todas as linhas
                }
            }
            else if (controle.HasChildren)
            {
                foreach (Control child in controle.Controls)
                {
                    LimparControle(child);
                }
            }
        }
        #endregion

        #region Confirmacao
        public bool Confirmacao()
        {
            // Perguntar ao usuário antes de cadastrar
            DialogResult resultado = MessageBox.Show("Os dados para cadastro estão corretos? Deseja continuar?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Se o usuário clicar em "Não", a função retorna e não executa o cadastro
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion

        #region InputBox
        public static string InputBox(string prompt, string title)
        {
            Form inputBox = new Form()
            {
                Width = 500,
                Height = 300,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 30, Top = 30, Text = prompt, Width = 440 };
            TextBox textBox = new TextBox() { Left = 30, Top = 60, Width = 440 };
            Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 100, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { inputBox.Close(); };

            inputBox.Controls.Add(label);
            inputBox.Controls.Add(textBox);
            inputBox.Controls.Add(confirmation);
            inputBox.AcceptButton = confirmation;

            return inputBox.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
        #endregion

        #region BuscarCep
        public string BuscarCep(string cepzada)
        {
            try
            {
                string cep = cepzada;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";
                string resultado;

                DataSet dados = new DataSet(); //objeto capaz de receber e fazer uma requisição para a API

                dados.ReadXml(xml);
                resultado = $"{dados.Tables[0].Rows[0]["logradouro"]}, " +
                            $"{dados.Tables[0].Rows[0]["bairro"]}, " +
                            $"{dados.Tables[0].Rows[0]["complemento"]}, " +
                            $"{dados.Tables[0].Rows[0]["localidade"]} - " +
                            $"{dados.Tables[0].Rows[0]["uf"]}";
                return resultado;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Endereço não encontrado. Digite manualmente. {error.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
        #endregion

        #region VerificarCamposPreenchidos
        public static bool VerificarCamposPreenchidos(Control parent, List<string> camposIgnorados, string tabPageName)
        {
            // Obter o formulário principal ao qual o controle pertence
            Form form = parent.FindForm();
            if (form == null) return false; // Retorna falso se o formulário não puder ser encontrado

            // Se foi passado o nome de uma TabPage, localizar ela
            if (!string.IsNullOrEmpty(tabPageName))
            {
                Control tabPage = form.Controls.Find(tabPageName, true).FirstOrDefault();
                if (tabPage != null && tabPage is TabPage)
                {
                    parent = tabPage; // agora a função vai trabalhar apenas dentro da TabPage
                }
                else return false; // TabControl não encontrado
            }

            // Usar uma pilha para evitar recursão infinita
            Stack<Control> controles = new Stack<Control>();
            controles.Push(parent);

            while (controles.Count > 0)
            {
                Control controleAtual = controles.Pop();

                // Verificar se o controle deve ser ignorado
                if (camposIgnorados != null && camposIgnorados.Contains(controleAtual.Name))
                {
                    continue; // Pula esse campo
                }

                if (controleAtual is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false; // Campo vazio encontrado
                }
                else if (controleAtual is MaskedTextBox maskedTextBox)
                {
                    // Verifica se o texto "limpo" (sem espaços e símbolos) está vazio
                    string textoSemMascara = maskedTextBox.Text.Replace("(", "")
                                                                .Replace(")", "")
                                                                .Replace("-", "")
                                                                .Replace(".", "")
                                                                .Replace("/", "")
                                                                .Replace("_", "")
                                                                .Replace(" ", "");

                    if (string.IsNullOrWhiteSpace(textoSemMascara))
                    {
                        return false; // Campo MaskedTextBox vazio mesmo que visualmente tenha máscara
                    }
                }
                else if (controleAtual is ComboBox comboBox && (comboBox.SelectedItem == null || string.IsNullOrWhiteSpace(comboBox.Text)))
                {
                    return false; // Campo vazio encontrado
                }

                // Adicionar controles filhos à pilha
                foreach (Control child in controleAtual.Controls)
                {
                    controles.Push(child);
                }
            }
            return true; // Todos os campos estão preenchidos
        }
        #endregion

        #region AjustarControles
        public void AjustarControles(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                // Calcula os limites relativos do controle ao contêiner
                bool anchorLeft = ctrl.Left <= container.Width / 3;
                bool anchorRight = (ctrl.Right >= container.Width * 2 / 3);
                bool anchorTop = ctrl.Top <= container.Height / 3;
                bool anchorBottom = (ctrl.Bottom >= container.Height * 2 / 3);

                AnchorStyles anchor = AnchorStyles.None;
                if (anchorLeft) anchor |= AnchorStyles.Left;
                if (anchorRight) anchor |= AnchorStyles.Right;
                if (anchorTop) anchor |= AnchorStyles.Top;
                if (anchorBottom) anchor |= AnchorStyles.Bottom;

                ctrl.Anchor = anchor;

                // Chamada recursiva para controles filhos (ex: painéis)
                if (ctrl.HasChildren)
                    AjustarControles(ctrl);
            }
        }
        #endregion

        #region AjustarControlesRecursivo
        /// <summary>
        /// Ajusta os controles recursivamente com base nos tamanhos originais.
        /// </summary>
        /// <param name="controle">O controle a ser ajustado.</param>
        /// <param name="originalSizes">Dicionário contendo os tamanhos e posições originais dos controles.</param>
        private void AjustarControlesRecursivo(Control controle, Dictionary<Control, Rectangle> originalSizes)
        {
            foreach (Control child in controle.Controls)
            {
                if (originalSizes.ContainsKey(child))
                {
                    Rectangle original = originalSizes[child];

                    // Calcula a proporção de redimensionamento
                    float xRatio = (float)controle.ClientSize.Width / originalSizes[controle].Width;
                    float yRatio = (float)controle.ClientSize.Height / originalSizes[controle].Height;

                    // Ajusta a posição e o tamanho do controle
                    child.Location = new Point((int)(original.X * xRatio), (int)(original.Y * yRatio));
                    child.Size = new Size((int)(original.Width * xRatio), (int)(original.Height * yRatio));
                }

                // Ajusta os controles filhos recursivamente
                if (child.HasChildren)
                {
                    AjustarControlesRecursivo(child, originalSizes);
                }
            }
        }
        #endregion

        #region SaveOriginalSizes
        /// <summary>
        /// Salva os tamanhos e posições originais dos controles de um formulário.
        /// </summary>
        /// <param name="tela">O formulário cujos tamanhos e posições dos controles serão salvos.</param>
        public void SaveOriginalSizes(Form tela)
        {
            // Cria um dicionário para armazenar os tamanhos e posições originais
            Dictionary<Control, Rectangle> originalSizes = new Dictionary<Control, Rectangle>();

            // Percorre todos os controles do formulário
            foreach (Control controle in tela.Controls)
            {
                // Salva o tamanho e a posição original do controle
                originalSizes[controle] = new Rectangle(controle.Location, controle.Size);

                // Se o controle tiver filhos, salva os tamanhos e posições originais recursivamente
                if (controle.HasChildren)
                {
                    SaveOriginalSizesRecursivo(controle, originalSizes);
                }
            }

            // Armazena o dicionário no Tag do formulário para uso posterior
            tela.Tag = originalSizes;
        }
        #endregion

        #region SaveOriginalSizesRecursivo
        /// <summary>
        /// Salva os tamanhos e posições originais dos controles filhos recursivamente.
        /// </summary>
        /// <param name="controle">O controle pai cujos filhos serão processados.</param>
        /// <param name="originalSizes">O dicionário onde os tamanhos e posições serão armazenados.</param>
        private void SaveOriginalSizesRecursivo(Control controle, Dictionary<Control, Rectangle> originalSizes)
        {
            foreach (Control child in controle.Controls)
            {
                // Salva o tamanho e a posição original do controle filho
                originalSizes[child] = new Rectangle(child.Location, child.Size);

                // Se o controle filho também tiver filhos, chama recursivamente
                if (child.HasChildren)
                {
                    SaveOriginalSizesRecursivo(child, originalSizes);
                }
            }
        }
        #endregion

        #region ConfigurarLinkToolStrip
        public void ConfigurarLinkToolStrip(ToolStripStatusLabel toolStripLabel, string url)
        {
            if (toolStripLabel == null || string.IsNullOrEmpty(url))
                throw new ArgumentNullException("O ToolStripStatusLabel ou a URL não podem ser nulos.");

            // Configura o cursor para indicar que é clicável
            toolStripLabel.IsLink = true;
            toolStripLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            toolStripLabel.LinkColor = Color.Blue;

            // Adiciona o evento de clique
            toolStripLabel.Click += (sender, e) =>
            {
                try
                {
                    System.Diagnostics.Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        #endregion
    }
}
