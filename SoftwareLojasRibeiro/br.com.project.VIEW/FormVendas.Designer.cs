namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewProdutosCarrinho = new System.Windows.Forms.DataGridView();
            this.groupBoxCarrinho = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonPagamento = new System.Windows.Forms.Button();
            this.textBoxTotall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlVendas = new System.Windows.Forms.TabControl();
            this.tabPageVenda = new System.Windows.Forms.TabPage();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.tabPageHistorico = new System.Windows.Forms.TabPage();
            this.dataGridViewHistorico = new System.Windows.Forms.DataGridView();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.buttonDetalhes = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dateTimePickerDataFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).BeginInit();
            this.groupBoxCarrinho.SuspendLayout();
            this.tabControlVendas.SuspendLayout();
            this.tabPageVenda.SuspendLayout();
            this.tabPageHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).BeginInit();
            this.groupBoxConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Vendas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 111);
            this.panel1.TabIndex = 5;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(-1, -1);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(103, 24);
            this.buttonMenu.TabIndex = 11;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.maskedTextBoxData);
            this.groupBoxCliente.Controls.Add(this.label5);
            this.groupBoxCliente.Controls.Add(this.textBoxNome);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.maskedTextBoxCpf);
            this.groupBoxCliente.Controls.Add(this.label6);
            this.groupBoxCliente.Location = new System.Drawing.Point(4, 11);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(414, 137);
            this.groupBoxCliente.TabIndex = 6;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(51, 28);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.ReadOnly = true;
            this.maskedTextBoxData.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxData.TabIndex = 12;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxData_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(52, 100);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(247, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(52, 63);
            this.maskedTextBoxCpf.Mask = "###,###,###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxCpf.TabIndex = 2;
            this.maskedTextBoxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPF:";
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.button1);
            this.groupBoxProduto.Controls.Add(this.buttonRemover);
            this.groupBoxProduto.Controls.Add(this.buttonAdicionar);
            this.groupBoxProduto.Controls.Add(this.label3);
            this.groupBoxProduto.Controls.Add(this.textBoxQuantidade);
            this.groupBoxProduto.Controls.Add(this.textBoxID);
            this.groupBoxProduto.Controls.Add(this.label12);
            this.groupBoxProduto.Controls.Add(this.textBoxDescrição);
            this.groupBoxProduto.Controls.Add(this.label9);
            this.groupBoxProduto.Controls.Add(this.textBoxPreco);
            this.groupBoxProduto.Controls.Add(this.label8);
            this.groupBoxProduto.Location = new System.Drawing.Point(4, 163);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(414, 251);
            this.groupBoxProduto.TabIndex = 7;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Produto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 52;
            this.button1.Text = "Buscar Produto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(208, 194);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(171, 40);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.Text = "Remover Item";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(15, 194);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(171, 40);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar Item";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Quantidade:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(280, 121);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(99, 20);
            this.textBoxQuantidade.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(87, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(49, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "ID:";
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Location = new System.Drawing.Point(87, 68);
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.ReadOnly = true;
            this.textBoxDescrição.Size = new System.Drawing.Size(229, 20);
            this.textBoxDescrição.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Preço (R$):";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(87, 121);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(99, 20);
            this.textBoxPreco.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Descrição:";
            // 
            // dataGridViewProdutosCarrinho
            // 
            this.dataGridViewProdutosCarrinho.AllowUserToAddRows = false;
            this.dataGridViewProdutosCarrinho.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinho.Location = new System.Drawing.Point(435, 11);
            this.dataGridViewProdutosCarrinho.Name = "dataGridViewProdutosCarrinho";
            this.dataGridViewProdutosCarrinho.ReadOnly = true;
            this.dataGridViewProdutosCarrinho.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinho.Size = new System.Drawing.Size(572, 308);
            this.dataGridViewProdutosCarrinho.TabIndex = 8;
            this.dataGridViewProdutosCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutosCarrinho_CellContentClick);
            // 
            // groupBoxCarrinho
            // 
            this.groupBoxCarrinho.Controls.Add(this.buttonCancelar);
            this.groupBoxCarrinho.Controls.Add(this.buttonPagamento);
            this.groupBoxCarrinho.Controls.Add(this.textBoxTotall);
            this.groupBoxCarrinho.Controls.Add(this.label4);
            this.groupBoxCarrinho.Location = new System.Drawing.Point(435, 332);
            this.groupBoxCarrinho.Name = "groupBoxCarrinho";
            this.groupBoxCarrinho.Size = new System.Drawing.Size(572, 137);
            this.groupBoxCarrinho.TabIndex = 10;
            this.groupBoxCarrinho.TabStop = false;
            this.groupBoxCarrinho.Text = "Carrinho";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(222, 74);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(171, 40);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonPagamento
            // 
            this.buttonPagamento.Location = new System.Drawing.Point(29, 74);
            this.buttonPagamento.Name = "buttonPagamento";
            this.buttonPagamento.Size = new System.Drawing.Size(171, 40);
            this.buttonPagamento.TabIndex = 0;
            this.buttonPagamento.Text = "Pagamento";
            this.buttonPagamento.UseVisualStyleBackColor = true;
            this.buttonPagamento.Click += new System.EventHandler(this.buttonPagamento_Click);
            // 
            // textBoxTotall
            // 
            this.textBoxTotall.Location = new System.Drawing.Point(94, 35);
            this.textBoxTotall.Name = "textBoxTotall";
            this.textBoxTotall.ReadOnly = true;
            this.textBoxTotall.Size = new System.Drawing.Size(247, 20);
            this.textBoxTotall.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total (R$):";
            // 
            // tabControlVendas
            // 
            this.tabControlVendas.Controls.Add(this.tabPageVenda);
            this.tabControlVendas.Controls.Add(this.tabPageHistorico);
            this.tabControlVendas.Location = new System.Drawing.Point(1, 121);
            this.tabControlVendas.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlVendas.Name = "tabControlVendas";
            this.tabControlVendas.SelectedIndex = 0;
            this.tabControlVendas.Size = new System.Drawing.Size(1024, 524);
            this.tabControlVendas.TabIndex = 11;
            // 
            // tabPageVenda
            // 
            this.tabPageVenda.Controls.Add(this.buttonLimparCampos);
            this.tabPageVenda.Controls.Add(this.groupBoxCarrinho);
            this.tabPageVenda.Controls.Add(this.groupBoxCliente);
            this.tabPageVenda.Controls.Add(this.dataGridViewProdutosCarrinho);
            this.tabPageVenda.Controls.Add(this.groupBoxProduto);
            this.tabPageVenda.Location = new System.Drawing.Point(4, 22);
            this.tabPageVenda.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageVenda.Name = "tabPageVenda";
            this.tabPageVenda.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageVenda.Size = new System.Drawing.Size(1016, 498);
            this.tabPageVenda.TabIndex = 0;
            this.tabPageVenda.Text = "Venda";
            this.tabPageVenda.UseVisualStyleBackColor = true;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(109, 433);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(171, 40);
            this.buttonLimparCampos.TabIndex = 52;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // tabPageHistorico
            // 
            this.tabPageHistorico.Controls.Add(this.dataGridViewHistorico);
            this.tabPageHistorico.Controls.Add(this.groupBoxConsulta);
            this.tabPageHistorico.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHistorico.Name = "tabPageHistorico";
            this.tabPageHistorico.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHistorico.Size = new System.Drawing.Size(1016, 498);
            this.tabPageHistorico.TabIndex = 1;
            this.tabPageHistorico.Text = "Histórico";
            this.tabPageHistorico.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.AllowUserToAddRows = false;
            this.dataGridViewHistorico.AllowUserToDeleteRows = false;
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Location = new System.Drawing.Point(6, 133);
            this.dataGridViewHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.ReadOnly = true;
            this.dataGridViewHistorico.RowHeadersWidth = 62;
            this.dataGridViewHistorico.RowTemplate.Height = 28;
            this.dataGridViewHistorico.Size = new System.Drawing.Size(1006, 361);
            this.dataGridViewHistorico.TabIndex = 1;
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.buttonDetalhes);
            this.groupBoxConsulta.Controls.Add(this.buttonPesquisar);
            this.groupBoxConsulta.Controls.Add(this.dateTimePickerDataFim);
            this.groupBoxConsulta.Controls.Add(this.dateTimePickerDataInicio);
            this.groupBoxConsulta.Controls.Add(this.label10);
            this.groupBoxConsulta.Controls.Add(this.label7);
            this.groupBoxConsulta.Location = new System.Drawing.Point(6, 8);
            this.groupBoxConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConsulta.Size = new System.Drawing.Size(477, 121);
            this.groupBoxConsulta.TabIndex = 0;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // buttonDetalhes
            // 
            this.buttonDetalhes.Location = new System.Drawing.Point(356, 48);
            this.buttonDetalhes.Name = "buttonDetalhes";
            this.buttonDetalhes.Size = new System.Drawing.Size(91, 28);
            this.buttonDetalhes.TabIndex = 16;
            this.buttonDetalhes.Text = "Exibir Detalhes";
            this.buttonDetalhes.UseVisualStyleBackColor = true;
            this.buttonDetalhes.Click += new System.EventHandler(this.buttonDetalhes_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(228, 48);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(91, 28);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dateTimePickerDataFim
            // 
            this.dateTimePickerDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFim.Location = new System.Drawing.Point(93, 63);
            this.dateTimePickerDataFim.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            this.dateTimePickerDataFim.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataFim.TabIndex = 15;
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(93, 33);
            this.dateTimePickerDataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataInicio.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Data Fim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Início:";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).EndInit();
            this.groupBoxCarrinho.ResumeLayout(false);
            this.groupBoxCarrinho.PerformLayout();
            this.tabControlVendas.ResumeLayout(false);
            this.tabPageVenda.ResumeLayout(false);
            this.tabPageHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).EndInit();
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDescrição;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.GroupBox groupBoxCarrinho;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlVendas;
        private System.Windows.Forms.TabPage tabPageVenda;
        private System.Windows.Forms.TabPage tabPageHistorico;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.DataGridView dataGridViewHistorico;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonDetalhes;
        private System.Windows.Forms.Button buttonLimparCampos;
        public System.Windows.Forms.TextBox textBoxTotall;
        public System.Windows.Forms.DataGridView dataGridViewProdutosCarrinho;
        private System.Windows.Forms.Button button1;
    }
}