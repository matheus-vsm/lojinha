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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.dataGridViewProdutosCarrinhoPagamento = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formVendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinhoPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label9.Location = new System.Drawing.Point(165, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Dinheiro (R$):";
            // 
            // textBoxDinheiro
            // 
            this.textBoxDinheiro.Location = new System.Drawing.Point(272, 230);
            this.textBoxDinheiro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDinheiro.Name = "textBoxDinheiro";
            this.textBoxDinheiro.Size = new System.Drawing.Size(131, 23);
            this.textBoxDinheiro.TabIndex = 48;
            this.textBoxDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDinheiro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cartão de Débito (R$):";
            // 
            // textBoxDebito
            // 
            this.textBoxDebito.Location = new System.Drawing.Point(272, 345);
            this.textBoxDebito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDebito.Name = "textBoxDebito";
            this.textBoxDebito.Size = new System.Drawing.Size(131, 23);
            this.textBoxDebito.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "PIX (R$):";
            // 
            // textBoxPix
            // 
            this.textBoxPix.Location = new System.Drawing.Point(272, 404);
            this.textBoxPix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPix.Name = "textBoxPix";
            this.textBoxPix.Size = new System.Drawing.Size(131, 23);
            this.textBoxPix.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label4.Location = new System.Drawing.Point(76, 520);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Troco (R$):";
            // 
            // textBoxTroco
            // 
            this.textBoxTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxTroco.Location = new System.Drawing.Point(212, 516);
            this.textBoxTroco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTroco.Name = "textBoxTroco";
            this.textBoxTroco.ReadOnly = true;
            this.textBoxTroco.Size = new System.Drawing.Size(131, 30);
            this.textBoxTroco.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.label5.Location = new System.Drawing.Point(375, 516);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total (R$):";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxTotal.Location = new System.Drawing.Point(533, 516);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(227, 38);
            this.textBoxTotal.TabIndex = 56;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(389, 599);
            this.buttonFinalizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(309, 46);
            this.buttonFinalizar.TabIndex = 58;
            this.buttonFinalizar.Text = "Finalizar Venda";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(387, 172);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.ReadOnly = true;
            this.maskedTextBoxData.Size = new System.Drawing.Size(135, 23);
            this.maskedTextBoxData.TabIndex = 14;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "Observações:";
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.Location = new System.Drawing.Point(491, 230);
            this.textBoxObservacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(247, 216);
            this.textBoxObservacoes.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 15);
            this.label10.TabIndex = 64;
            this.label10.Text = "Cartão de Crédito (R$):";
            // 
            // textBoxCredito
            // 
            this.textBoxCredito.Location = new System.Drawing.Point(272, 287);
            this.textBoxCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCredito.Name = "textBoxCredito";
            this.textBoxCredito.Size = new System.Drawing.Size(131, 23);
            this.textBoxCredito.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 15);
            this.label12.TabIndex = 67;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 291);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(412, 348);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(412, 407);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 15);
            this.label15.TabIndex = 70;
            this.label15.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 456);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 72;
            this.label11.Text = "Desconto (R$):";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(271, 452);
            this.textBoxDesconto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(131, 23);
            this.textBoxDesconto.TabIndex = 71;
            this.textBoxDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesconto_KeyPress);
            // 
            // dataGridViewProdutosCarrinhoPagamento
            // 
            this.dataGridViewProdutosCarrinhoPagamento.AllowUserToAddRows = false;
            this.dataGridViewProdutosCarrinhoPagamento.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosCarrinhoPagamento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutosCarrinhoPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinhoPagamento.Location = new System.Drawing.Point(809, 162);
            this.dataGridViewProdutosCarrinhoPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewProdutosCarrinhoPagamento.Name = "dataGridViewProdutosCarrinhoPagamento";
            this.dataGridViewProdutosCarrinhoPagamento.ReadOnly = true;
            this.dataGridViewProdutosCarrinhoPagamento.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinhoPagamento.Size = new System.Drawing.Size(861, 355);
            this.dataGridViewProdutosCarrinhoPagamento.TabIndex = 74;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(759, 599);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(309, 46);
            this.buttonCancelar.TabIndex = 75;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
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
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewProdutosCarrinhoPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinhoPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.DataGridView dataGridViewProdutosCarrinhoPagamento;
        private System.Windows.Forms.BindingSource formVendasBindingSource;
        private System.Windows.Forms.BindingSource formVendasBindingSource1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}