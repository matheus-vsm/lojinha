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
    }
}
