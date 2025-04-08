namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormPagamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDinheiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDebito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTroco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObservacoes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCredito = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.dataGridViewProdutosCarrinhoPagamento = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.formVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formVendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinhoPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1687, 143);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SoftwareLojasRibeiro.Properties.Resources.Logo_Lojas_Ribeiro_Transparente_menor;
            this.pictureBox1.Location = new System.Drawing.Point(1517, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 127);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 22);
            this.label9.TabIndex = 49;
            this.label9.Text = "Dinheiro (R$):";
            // 
            // textBoxDinheiro
            // 
            this.textBoxDinheiro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDinheiro.Location = new System.Drawing.Point(272, 230);
            this.textBoxDinheiro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDinheiro.Name = "textBoxDinheiro";
            this.textBoxDinheiro.Size = new System.Drawing.Size(166, 29);
            this.textBoxDinheiro.TabIndex = 0;
            this.textBoxDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDinheiro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cartão de Débito (R$):";
            // 
            // textBoxDebito
            // 
            this.textBoxDebito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebito.Location = new System.Drawing.Point(272, 345);
            this.textBoxDebito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDebito.Name = "textBoxDebito";
            this.textBoxDebito.Size = new System.Drawing.Size(166, 29);
            this.textBoxDebito.TabIndex = 2;
            this.textBoxDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "PIX (R$):";
            // 
            // textBoxPix
            // 
            this.textBoxPix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPix.Location = new System.Drawing.Point(272, 404);
            this.textBoxPix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPix.Name = "textBoxPix";
            this.textBoxPix.Size = new System.Drawing.Size(166, 29);
            this.textBoxPix.TabIndex = 3;
            this.textBoxPix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 519);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 55;
            this.label4.Text = "Troco (R$):";
            // 
            // textBoxTroco
            // 
            this.textBoxTroco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.textBoxTroco.Location = new System.Drawing.Point(212, 513);
            this.textBoxTroco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTroco.Name = "textBoxTroco";
            this.textBoxTroco.ReadOnly = true;
            this.textBoxTroco.Size = new System.Drawing.Size(131, 41);
            this.textBoxTroco.TabIndex = 54;
            this.textBoxTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total (R$):";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.textBoxTotal.Location = new System.Drawing.Point(533, 512);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(227, 45);
            this.textBoxTotal.TabIndex = 56;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.Location = new System.Drawing.Point(389, 599);
            this.buttonFinalizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(309, 46);
            this.buttonFinalizar.TabIndex = 6;
            this.buttonFinalizar.Text = "Finalizar Venda";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxData.Location = new System.Drawing.Point(356, 180);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.ReadOnly = true;
            this.maskedTextBoxData.Size = new System.Drawing.Size(196, 29);
            this.maskedTextBoxData.TabIndex = 14;
            this.maskedTextBoxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 61;
            this.label8.Text = "Observações:";
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservacoes.Location = new System.Drawing.Point(499, 245);
            this.textBoxObservacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(247, 216);
            this.textBoxObservacoes.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 22);
            this.label10.TabIndex = 64;
            this.label10.Text = "Cartão de Crédito (R$):";
            // 
            // textBoxCredito
            // 
            this.textBoxCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCredito.Location = new System.Drawing.Point(272, 287);
            this.textBoxCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCredito.Name = "textBoxCredito";
            this.textBoxCredito.Size = new System.Drawing.Size(166, 29);
            this.textBoxCredito.TabIndex = 1;
            this.textBoxCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(119, 456);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 22);
            this.label11.TabIndex = 72;
            this.label11.Text = "Desconto (R$):";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesconto.Location = new System.Drawing.Point(271, 452);
            this.textBoxDesconto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(166, 29);
            this.textBoxDesconto.TabIndex = 4;
            this.textBoxDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesconto_KeyPress);
            // 
            // dataGridViewProdutosCarrinhoPagamento
            // 
            this.dataGridViewProdutosCarrinhoPagamento.AllowUserToAddRows = false;
            this.dataGridViewProdutosCarrinhoPagamento.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosCarrinhoPagamento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutosCarrinhoPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinhoPagamento.Location = new System.Drawing.Point(809, 194);
            this.dataGridViewProdutosCarrinhoPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewProdutosCarrinhoPagamento.Name = "dataGridViewProdutosCarrinhoPagamento";
            this.dataGridViewProdutosCarrinhoPagamento.ReadOnly = true;
            this.dataGridViewProdutosCarrinhoPagamento.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinhoPagamento.Size = new System.Drawing.Size(861, 355);
            this.dataGridViewProdutosCarrinhoPagamento.TabIndex = 74;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(759, 599);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(309, 46);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar Pagamento";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1185, 161);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 22);
            this.label16.TabIndex = 76;
            this.label16.Text = "Carrinho:";
            // 
            // formVendasBindingSource
            // 
            this.formVendasBindingSource.DataSource = typeof(SoftwareLojasRibeiro.br.com.project.VIEW.FormVendas);
            // 
            // formVendasBindingSource1
            // 
            this.formVendasBindingSource1.DataSource = typeof(SoftwareLojasRibeiro.br.com.project.VIEW.FormVendas);
            // 
            // FormPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1687, 678);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewProdutosCarrinhoPagamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCredito);
            this.Controls.Add(this.textBoxObservacoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDebito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDinheiro);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Pagamento";
            this.Load += new System.EventHandler(this.FormPagamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinhoPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDinheiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDebito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTroco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFinalizar;
        public System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxObservacoes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCredito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.DataGridView dataGridViewProdutosCarrinhoPagamento;
        private System.Windows.Forms.BindingSource formVendasBindingSource;
        private System.Windows.Forms.BindingSource formVendasBindingSource1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
    }
}