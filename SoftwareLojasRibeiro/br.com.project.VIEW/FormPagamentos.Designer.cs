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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
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
            this.formVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formVendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinhoPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 111);
            this.panel1.TabIndex = 6;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(-1, -1);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(103, 24);
            this.buttonMenu.TabIndex = 11;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Dinheiro (R$):";
            // 
            // textBoxDinheiro
            // 
            this.textBoxDinheiro.Location = new System.Drawing.Point(204, 199);
            this.textBoxDinheiro.Name = "textBoxDinheiro";
            this.textBoxDinheiro.Size = new System.Drawing.Size(99, 20);
            this.textBoxDinheiro.TabIndex = 48;
            this.textBoxDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDinheiro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cartão de Débito (R$):";
            // 
            // textBoxDebito
            // 
            this.textBoxDebito.Location = new System.Drawing.Point(204, 299);
            this.textBoxDebito.Name = "textBoxDebito";
            this.textBoxDebito.Size = new System.Drawing.Size(99, 20);
            this.textBoxDebito.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "PIX (R$):";
            // 
            // textBoxPix
            // 
            this.textBoxPix.Location = new System.Drawing.Point(204, 350);
            this.textBoxPix.Name = "textBoxPix";
            this.textBoxPix.Size = new System.Drawing.Size(99, 20);
            this.textBoxPix.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(50, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Troco (R$):";
            // 
            // textBoxTroco
            // 
            this.textBoxTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxTroco.Location = new System.Drawing.Point(159, 447);
            this.textBoxTroco.Name = "textBoxTroco";
            this.textBoxTroco.ReadOnly = true;
            this.textBoxTroco.Size = new System.Drawing.Size(99, 30);
            this.textBoxTroco.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(281, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total (R$):";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxTotal.Location = new System.Drawing.Point(430, 447);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(171, 38);
            this.textBoxTotal.TabIndex = 56;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(292, 519);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(232, 40);
            this.buttonFinalizar.TabIndex = 58;
            this.buttonFinalizar.Text = "Finalizar Venda";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(311, 136);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(102, 20);
            this.maskedTextBoxData.TabIndex = 14;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Observações:";
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.Location = new System.Drawing.Point(368, 199);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(186, 188);
            this.textBoxObservacoes.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Cartão de Crédito (R$):";
            // 
            // textBoxCredito
            // 
            this.textBoxCredito.Location = new System.Drawing.Point(204, 249);
            this.textBoxCredito.Name = "textBoxCredito";
            this.textBoxCredito.Size = new System.Drawing.Size(99, 20);
            this.textBoxCredito.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(309, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(309, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(309, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Desconto (R$):";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(203, 392);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(99, 20);
            this.textBoxDesconto.TabIndex = 71;
            this.textBoxDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesconto_KeyPress);
            // 
            // dataGridViewProdutosCarrinhoPagamento
            // 
            this.dataGridViewProdutosCarrinhoPagamento.AllowUserToAddRows = false;
            this.dataGridViewProdutosCarrinhoPagamento.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosCarrinhoPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinhoPagamento.Location = new System.Drawing.Point(607, 140);
            this.dataGridViewProdutosCarrinhoPagamento.Name = "dataGridViewProdutosCarrinhoPagamento";
            this.dataGridViewProdutosCarrinhoPagamento.ReadOnly = true;
            this.dataGridViewProdutosCarrinhoPagamento.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinhoPagamento.Size = new System.Drawing.Size(646, 308);
            this.dataGridViewProdutosCarrinhoPagamento.TabIndex = 74;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(569, 519);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(232, 40);
            this.buttonCancelar.TabIndex = 75;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 588);
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
            this.Name = "FormPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Pagamento";
            this.Load += new System.EventHandler(this.FormPagamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinhoPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formVendasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
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
    }
}