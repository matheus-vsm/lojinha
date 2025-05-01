namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormExibirComprasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExibirComprasCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.dataGridViewHistorico = new System.Windows.Forms.DataGridView();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.buttonLimparPesquisa = new System.Windows.Forms.Button();
            this.textBoxTotalGasto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDetalhes = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dateTimePickerDataFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).BeginInit();
            this.groupBoxConsulta.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelNomeCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 143);
            this.panel1.TabIndex = 19;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.labelNomeCliente.Location = new System.Drawing.Point(58, 52);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(193, 33);
            this.labelNomeCliente.TabIndex = 0;
            this.labelNomeCliente.Text = "Compras de ";
            this.labelNomeCliente.Click += new System.EventHandler(this.labelNomeCliente_Click);
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.AllowUserToAddRows = false;
            this.dataGridViewHistorico.AllowUserToDeleteRows = false;
            this.dataGridViewHistorico.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Location = new System.Drawing.Point(0, 309);
            this.dataGridViewHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.ReadOnly = true;
            this.dataGridViewHistorico.RowHeadersWidth = 62;
            this.dataGridViewHistorico.RowTemplate.Height = 28;
            this.dataGridViewHistorico.Size = new System.Drawing.Size(1111, 341);
            this.dataGridViewHistorico.TabIndex = 21;
            this.dataGridViewHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistorico_CellContentClick);
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxConsulta.Controls.Add(this.buttonLimparPesquisa);
            this.groupBoxConsulta.Controls.Add(this.textBoxTotalGasto);
            this.groupBoxConsulta.Controls.Add(this.label1);
            this.groupBoxConsulta.Controls.Add(this.textBoxTotal);
            this.groupBoxConsulta.Controls.Add(this.label3);
            this.groupBoxConsulta.Controls.Add(this.buttonDetalhes);
            this.groupBoxConsulta.Controls.Add(this.buttonPesquisar);
            this.groupBoxConsulta.Controls.Add(this.dateTimePickerDataFim);
            this.groupBoxConsulta.Controls.Add(this.dateTimePickerDataInicio);
            this.groupBoxConsulta.Controls.Add(this.label10);
            this.groupBoxConsulta.Controls.Add(this.label7);
            this.groupBoxConsulta.Location = new System.Drawing.Point(5, 151);
            this.groupBoxConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxConsulta.Size = new System.Drawing.Size(1101, 151);
            this.groupBoxConsulta.TabIndex = 20;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // buttonLimparPesquisa
            // 
            this.buttonLimparPesquisa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparPesquisa.Location = new System.Drawing.Point(451, 92);
            this.buttonLimparPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
            this.buttonLimparPesquisa.Size = new System.Drawing.Size(247, 49);
            this.buttonLimparPesquisa.TabIndex = 23;
            this.buttonLimparPesquisa.Text = "Limpar Pesquisa";
            this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
            this.buttonLimparPesquisa.Click += new System.EventHandler(this.buttonLimparPesquisa_Click);
            // 
            // textBoxTotalGasto
            // 
            this.textBoxTotalGasto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalGasto.Location = new System.Drawing.Point(838, 114);
            this.textBoxTotalGasto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotalGasto.Name = "textBoxTotalGasto";
            this.textBoxTotalGasto.ReadOnly = true;
            this.textBoxTotalGasto.Size = new System.Drawing.Size(241, 32);
            this.textBoxTotalGasto.TabIndex = 21;
            this.textBoxTotalGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTotalGasto.TextChanged += new System.EventHandler(this.textBoxTotalGasto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Gasto (R$):";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(838, 44);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(241, 32);
            this.textBoxTotal.TabIndex = 19;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(862, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total de Compras";
            // 
            // buttonDetalhes
            // 
            this.buttonDetalhes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetalhes.Location = new System.Drawing.Point(583, 33);
            this.buttonDetalhes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDetalhes.Name = "buttonDetalhes";
            this.buttonDetalhes.Size = new System.Drawing.Size(227, 49);
            this.buttonDetalhes.TabIndex = 16;
            this.buttonDetalhes.Text = "Exibir Detalhes";
            this.buttonDetalhes.UseVisualStyleBackColor = true;
            this.buttonDetalhes.Click += new System.EventHandler(this.buttonDetalhes_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(331, 33);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(227, 49);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dateTimePickerDataFim
            // 
            this.dateTimePickerDataFim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFim.Location = new System.Drawing.Point(140, 75);
            this.dateTimePickerDataFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            this.dateTimePickerDataFim.Size = new System.Drawing.Size(161, 32);
            this.dateTimePickerDataFim.TabIndex = 15;
            this.dateTimePickerDataFim.Value = new System.DateTime(2025, 2, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(140, 39);
            this.dateTimePickerDataInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(161, 32);
            this.dateTimePickerDataInicio.TabIndex = 14;
            this.dateTimePickerDataInicio.Value = new System.DateTime(2025, 1, 1, 22, 9, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Data Fim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Início:";
            // 
            // FormExibirComprasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1111, 650);
            this.Controls.Add(this.dataGridViewHistorico);
            this.Controls.Add(this.groupBoxConsulta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormExibirComprasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Compras do Cliente";
            this.Load += new System.EventHandler(this.FormExibirComprasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).EndInit();
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNomeCliente;
        public System.Windows.Forms.DataGridView dataGridViewHistorico;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.Button buttonDetalhes;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxTotalGasto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLimparPesquisa;
    }
}