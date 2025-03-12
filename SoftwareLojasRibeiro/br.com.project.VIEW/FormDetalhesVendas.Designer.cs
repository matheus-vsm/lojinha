namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormDetalhesVendas
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDetalhes = new System.Windows.Forms.DataGridView();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxValorPago);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxObs);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxTotal);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxNomeCliente);
            this.groupBox4.Controls.Add(this.maskedTextBoxDataVenda);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(8, 133);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(823, 121);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(552, 43);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.ReadOnly = true;
            this.textBoxObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObs.Size = new System.Drawing.Size(261, 73);
            this.textBoxObs.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Observações:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(552, 19);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(175, 20);
            this.textBoxTotal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total da Venda (R$):";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(66, 35);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.ReadOnly = true;
            this.textBoxNomeCliente.Size = new System.Drawing.Size(252, 20);
            this.textBoxNomeCliente.TabIndex = 13;
            // 
            // maskedTextBoxDataVenda
            // 
            this.maskedTextBoxDataVenda.Location = new System.Drawing.Point(97, 80);
            this.maskedTextBoxDataVenda.Mask = "00/00/0000";
            this.maskedTextBoxDataVenda.Name = "maskedTextBoxDataVenda";
            this.maskedTextBoxDataVenda.ReadOnly = true;
            this.maskedTextBoxDataVenda.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBoxDataVenda.TabIndex = 15;
            this.maskedTextBoxDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data da Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da Venda";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 111);
            this.panel1.TabIndex = 17;
            // 
            // dataGridViewDetalhes
            // 
            this.dataGridViewDetalhes.AllowUserToAddRows = false;
            this.dataGridViewDetalhes.AllowUserToDeleteRows = false;
            this.dataGridViewDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalhes.Location = new System.Drawing.Point(8, 265);
            this.dataGridViewDetalhes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDetalhes.Name = "dataGridViewDetalhes";
            this.dataGridViewDetalhes.ReadOnly = true;
            this.dataGridViewDetalhes.RowHeadersWidth = 62;
            this.dataGridViewDetalhes.RowTemplate.Height = 28;
            this.dataGridViewDetalhes.Size = new System.Drawing.Size(823, 297);
            this.dataGridViewDetalhes.TabIndex = 18;
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Location = new System.Drawing.Point(377, 80);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.ReadOnly = true;
            this.textBoxValorPago.Size = new System.Drawing.Size(83, 20);
            this.textBoxValorPago.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor Pago (R$):";
            // 
            // FormDetalhesVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 563);
            this.Controls.Add(this.dataGridViewDetalhes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetalhesVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Detalhes Vendas";
            this.Load += new System.EventHandler(this.FormDetalhesVendas_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalhes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDetalhes;
        public System.Windows.Forms.TextBox textBoxObs;
        public System.Windows.Forms.TextBox textBoxTotal;
        public System.Windows.Forms.TextBox textBoxNomeCliente;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxDataVenda;
        public System.Windows.Forms.TextBox textBoxValorPago;
        private System.Windows.Forms.Label label5;
    }
}