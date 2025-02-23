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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDetalhes = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxObs);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxTotal);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxNomeCliente);
            this.groupBox4.Controls.Add(this.maskedTextBoxDataVenda);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1053, 186);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da Venda";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 170);
            this.panel1.TabIndex = 17;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(99, 54);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.ReadOnly = true;
            this.textBoxNomeCliente.Size = new System.Drawing.Size(376, 26);
            this.textBoxNomeCliente.TabIndex = 13;
            // 
            // maskedTextBoxDataVenda
            // 
            this.maskedTextBoxDataVenda.Location = new System.Drawing.Point(146, 123);
            this.maskedTextBoxDataVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxDataVenda.Mask = "00/00/0000";
            this.maskedTextBoxDataVenda.Name = "maskedTextBoxDataVenda";
            this.maskedTextBoxDataVenda.ReadOnly = true;
            this.maskedTextBoxDataVenda.Size = new System.Drawing.Size(140, 26);
            this.maskedTextBoxDataVenda.TabIndex = 15;
            this.maskedTextBoxDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data da Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cliente:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(669, 53);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(261, 26);
            this.textBoxTotal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total da Venda (R$):";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(669, 89);
            this.textBoxObs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.ReadOnly = true;
            this.textBoxObs.Size = new System.Drawing.Size(261, 89);
            this.textBoxObs.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Observações:";
            // 
            // dataGridViewDetalhes
            // 
            this.dataGridViewDetalhes.AllowUserToAddRows = false;
            this.dataGridViewDetalhes.AllowUserToDeleteRows = false;
            this.dataGridViewDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalhes.Location = new System.Drawing.Point(12, 407);
            this.dataGridViewDetalhes.Name = "dataGridViewDetalhes";
            this.dataGridViewDetalhes.ReadOnly = true;
            this.dataGridViewDetalhes.RowHeadersWidth = 62;
            this.dataGridViewDetalhes.RowTemplate.Height = 28;
            this.dataGridViewDetalhes.Size = new System.Drawing.Size(1052, 301);
            this.dataGridViewDetalhes.TabIndex = 18;
            // 
            // FormDetalhesVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 724);
            this.Controls.Add(this.dataGridViewDetalhes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormDetalhesVendas";
            this.Text = "FormDetalhesVendas";
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
    }
}