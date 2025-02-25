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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTroco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObservacoes = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 111);
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
            this.label9.Location = new System.Drawing.Point(216, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Dinheiro (R$):";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(296, 237);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(99, 20);
            this.textBoxPreco.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cartão (R$):";
            // 
            // textBoxCartao
            // 
            this.textBoxCartao.Location = new System.Drawing.Point(296, 289);
            this.textBoxCartao.Name = "textBoxCartao";
            this.textBoxCartao.Size = new System.Drawing.Size(99, 20);
            this.textBoxCartao.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "PIX (R$):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Troco (R$):";
            // 
            // textBoxTroco
            // 
            this.textBoxTroco.Location = new System.Drawing.Point(296, 382);
            this.textBoxTroco.Name = "textBoxTroco";
            this.textBoxTroco.ReadOnly = true;
            this.textBoxTroco.Size = new System.Drawing.Size(99, 20);
            this.textBoxTroco.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total (R$):";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(296, 440);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(99, 20);
            this.textBoxTotal.TabIndex = 56;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(219, 522);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(232, 40);
            this.buttonFinalizar.TabIndex = 58;
            this.buttonFinalizar.Text = "Finalizar Venda";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "PIX",
            "Boleto"});
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(243, 185);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(247, 21);
            this.comboBoxFormaPagamento.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Forma de Pagemento: fazer um ifnesse campo para quando for cartao, ficar readonly" +
    " apagado";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(85, 183);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxData.TabIndex = 14;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Observações:";
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.Location = new System.Drawing.Point(452, 237);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(258, 233);
            this.textBoxObservacoes.TabIndex = 62;
            // 
            // FormPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 588);
            this.Controls.Add(this.textBoxObservacoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCartao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.panel1);
            this.Name = "FormPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Pagamento";
            this.Load += new System.EventHandler(this.FormPagamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTroco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxObservacoes;
    }
}