namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormDetalhesCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalhesCompras));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewDetalhes = new System.Windows.Forms.DataGridView();
            this.textBoxIdCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SoftwareLojasRibeiro.Properties.Resources.Logo_Lojas_Ribeiro_Transparente_menor;
            this.pictureBox1.Location = new System.Drawing.Point(942, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 127);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da Compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 143);
            this.panel1.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.buttonCadastrar);
            this.groupBox4.Controls.Add(this.textBoxIdCompra);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxObs);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxTotal);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.maskedTextBoxDataCompra);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(0, 149);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(1111, 181);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObs.Location = new System.Drawing.Point(786, 32);
            this.textBoxObs.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.ReadOnly = true;
            this.textBoxObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObs.Size = new System.Drawing.Size(293, 130);
            this.textBoxObs.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Observações:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(440, 121);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(280, 41);
            this.textBoxTotal.TabIndex = 17;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total (R$):";
            // 
            // maskedTextBoxDataCompra
            // 
            this.maskedTextBoxDataCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataCompra.Location = new System.Drawing.Point(265, 39);
            this.maskedTextBoxDataCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.maskedTextBoxDataCompra.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataCompra.Name = "maskedTextBoxDataCompra";
            this.maskedTextBoxDataCompra.ReadOnly = true;
            this.maskedTextBoxDataCompra.Size = new System.Drawing.Size(280, 39);
            this.maskedTextBoxDataCompra.TabIndex = 15;
            this.maskedTextBoxDataCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data da Compra:";
            // 
            // dataGridViewDetalhes
            // 
            this.dataGridViewDetalhes.AllowUserToAddRows = false;
            this.dataGridViewDetalhes.AllowUserToDeleteRows = false;
            this.dataGridViewDetalhes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetalhes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDetalhes.Location = new System.Drawing.Point(0, 334);
            this.dataGridViewDetalhes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewDetalhes.Name = "dataGridViewDetalhes";
            this.dataGridViewDetalhes.ReadOnly = true;
            this.dataGridViewDetalhes.RowHeadersWidth = 62;
            this.dataGridViewDetalhes.RowTemplate.Height = 28;
            this.dataGridViewDetalhes.Size = new System.Drawing.Size(1111, 316);
            this.dataGridViewDetalhes.TabIndex = 20;
            // 
            // textBoxIdCompra
            // 
            this.textBoxIdCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCompra.Location = new System.Drawing.Point(39, 121);
            this.textBoxIdCompra.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxIdCompra.Name = "textBoxIdCompra";
            this.textBoxIdCompra.ReadOnly = true;
            this.textBoxIdCompra.Size = new System.Drawing.Size(118, 41);
            this.textBoxIdCompra.TabIndex = 21;
            this.textBoxIdCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdCompra.TextChanged += new System.EventHandler(this.textBoxIdCompra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Compra:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(200, 94);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(194, 69);
            this.buttonCadastrar.TabIndex = 21;
            this.buttonCadastrar.Text = "Add Nova Compra desse Produto";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // FormDetalhesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1111, 650);
            this.Controls.Add(this.dataGridViewDetalhes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDetalhesCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Detalhes Compras";
            this.Load += new System.EventHandler(this.FormDetalhesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalhes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxDataCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewDetalhes;
        public System.Windows.Forms.TextBox textBoxIdCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}