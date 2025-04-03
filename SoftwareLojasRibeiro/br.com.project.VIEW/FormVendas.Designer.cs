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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.buttonLimparCpf = new System.Windows.Forms.Button();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.buttonLimparId = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.buttonExibirProds = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 143);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SoftwareLojasRibeiro.Properties.Resources.Logo_Lojas_Ribeiro_Transparente_menor;
            this.pictureBox1.Location = new System.Drawing.Point(1200, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 127);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Red;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.buttonMenu.Location = new System.Drawing.Point(-1, -1);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(125, 39);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.buttonLimparCpf);
            this.groupBoxCliente.Controls.Add(this.maskedTextBoxData);
            this.groupBoxCliente.Controls.Add(this.label5);
            this.groupBoxCliente.Controls.Add(this.textBoxNome);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.maskedTextBoxCpf);
            this.groupBoxCliente.Controls.Add(this.label6);
            this.groupBoxCliente.Location = new System.Drawing.Point(5, 13);
            this.groupBoxCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCliente.Size = new System.Drawing.Size(552, 158);
            this.groupBoxCliente.TabIndex = 6;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // buttonLimparCpf
            // 
            this.buttonLimparCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCpf.Location = new System.Drawing.Point(417, 53);
            this.buttonLimparCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparCpf.Name = "buttonLimparCpf";
            this.buttonLimparCpf.Size = new System.Drawing.Size(112, 60);
            this.buttonLimparCpf.TabIndex = 4;
            this.buttonLimparCpf.Text = "Limpar Cliente";
            this.buttonLimparCpf.UseVisualStyleBackColor = true;
            this.buttonLimparCpf.Click += new System.EventHandler(this.buttonLimparCpf_Click);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(155, 32);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.ReadOnly = true;
            this.maskedTextBoxData.Size = new System.Drawing.Size(151, 23);
            this.maskedTextBoxData.TabIndex = 3;
            this.maskedTextBoxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxData_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(69, 115);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(328, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(156, 73);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxCpf.Mask = "###,###,###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(151, 23);
            this.maskedTextBoxCpf.TabIndex = 0;
            this.maskedTextBoxCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCpf_MaskInputRejected);
            this.maskedTextBoxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPF:";
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.buttonLimparId);
            this.groupBoxProduto.Controls.Add(this.label11);
            this.groupBoxProduto.Controls.Add(this.textBoxEstoque);
            this.groupBoxProduto.Controls.Add(this.buttonExibirProds);
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
            this.groupBoxProduto.Location = new System.Drawing.Point(5, 201);
            this.groupBoxProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxProduto.Size = new System.Drawing.Size(552, 290);
            this.groupBoxProduto.TabIndex = 7;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Produto";
            // 
            // buttonLimparId
            // 
            this.buttonLimparId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparId.Location = new System.Drawing.Point(368, 224);
            this.buttonLimparId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparId.Name = "buttonLimparId";
            this.buttonLimparId.Size = new System.Drawing.Size(161, 46);
            this.buttonLimparId.TabIndex = 4;
            this.buttonLimparId.Text = "Limpar Produto";
            this.buttonLimparId.UseVisualStyleBackColor = true;
            this.buttonLimparId.Click += new System.EventHandler(this.buttonLimparId_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 22);
            this.label11.TabIndex = 54;
            this.label11.Text = "Estoque:";
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstoque.Location = new System.Drawing.Point(386, 140);
            this.textBoxEstoque.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.ReadOnly = true;
            this.textBoxEstoque.Size = new System.Drawing.Size(69, 29);
            this.textBoxEstoque.TabIndex = 5;
            this.textBoxEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExibirProds
            // 
            this.buttonExibirProds.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExibirProds.Location = new System.Drawing.Point(215, 29);
            this.buttonExibirProds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExibirProds.Name = "buttonExibirProds";
            this.buttonExibirProds.Size = new System.Drawing.Size(167, 30);
            this.buttonExibirProds.TabIndex = 52;
            this.buttonExibirProds.Text = "Exibir Produtos";
            this.buttonExibirProds.UseVisualStyleBackColor = true;
            this.buttonExibirProds.Click += new System.EventHandler(this.buttonExibirProds_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(191, 224);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(161, 46);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.Text = "Remover Item";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(20, 224);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(161, 46);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar Item";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "Quantidade:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidade.Location = new System.Drawing.Point(287, 183);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(131, 29);
            this.textBoxQuantidade.TabIndex = 1;
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(117, 31);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(64, 29);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 22);
            this.label12.TabIndex = 48;
            this.label12.Text = "ID:";
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrição.Location = new System.Drawing.Point(117, 76);
            this.textBoxDescrição.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.ReadOnly = true;
            this.textBoxDescrição.Size = new System.Drawing.Size(313, 29);
            this.textBoxDescrição.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "Preço (R$):";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreco.Location = new System.Drawing.Point(117, 140);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(131, 29);
            this.textBoxPreco.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Descrição:";
            // 
            // dataGridViewProdutosCarrinho
            // 
            this.dataGridViewProdutosCarrinho.AllowUserToAddRows = false;
            this.dataGridViewProdutosCarrinho.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosCarrinho.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutosCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinho.Location = new System.Drawing.Point(580, 13);
            this.dataGridViewProdutosCarrinho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewProdutosCarrinho.Name = "dataGridViewProdutosCarrinho";
            this.dataGridViewProdutosCarrinho.ReadOnly = true;
            this.dataGridViewProdutosCarrinho.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinho.Size = new System.Drawing.Size(763, 426);
            this.dataGridViewProdutosCarrinho.TabIndex = 1;
            this.dataGridViewProdutosCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutosCarrinho_CellContentClick);
            // 
            // groupBoxCarrinho
            // 
            this.groupBoxCarrinho.Controls.Add(this.buttonCancelar);
            this.groupBoxCarrinho.Controls.Add(this.buttonPagamento);
            this.groupBoxCarrinho.Controls.Add(this.textBoxTotall);
            this.groupBoxCarrinho.Controls.Add(this.label4);
            this.groupBoxCarrinho.Location = new System.Drawing.Point(580, 445);
            this.groupBoxCarrinho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCarrinho.Name = "groupBoxCarrinho";
            this.groupBoxCarrinho.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCarrinho.Size = new System.Drawing.Size(763, 158);
            this.groupBoxCarrinho.TabIndex = 10;
            this.groupBoxCarrinho.TabStop = false;
            this.groupBoxCarrinho.Text = "Carrinho";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(387, 85);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(228, 46);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonPagamento
            // 
            this.buttonPagamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagamento.Location = new System.Drawing.Point(130, 85);
            this.buttonPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPagamento.Name = "buttonPagamento";
            this.buttonPagamento.Size = new System.Drawing.Size(228, 46);
            this.buttonPagamento.TabIndex = 0;
            this.buttonPagamento.Text = "Pagamento";
            this.buttonPagamento.UseVisualStyleBackColor = true;
            this.buttonPagamento.Click += new System.EventHandler(this.buttonPagamento_Click);
            // 
            // textBoxTotall
            // 
            this.textBoxTotall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotall.Location = new System.Drawing.Point(334, 32);
            this.textBoxTotall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotall.Name = "textBoxTotall";
            this.textBoxTotall.ReadOnly = true;
            this.textBoxTotall.Size = new System.Drawing.Size(171, 41);
            this.textBoxTotall.TabIndex = 2;
            this.textBoxTotall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total (R$):";
            // 
            // tabControlVendas
            // 
            this.tabControlVendas.Controls.Add(this.tabPageVenda);
            this.tabControlVendas.Controls.Add(this.tabPageHistorico);
            this.tabControlVendas.Location = new System.Drawing.Point(0, 148);
            this.tabControlVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlVendas.Name = "tabControlVendas";
            this.tabControlVendas.SelectedIndex = 0;
            this.tabControlVendas.Size = new System.Drawing.Size(1373, 643);
            this.tabControlVendas.TabIndex = 0;
            // 
            // tabPageVenda
            // 
            this.tabPageVenda.Controls.Add(this.buttonLimparCampos);
            this.tabPageVenda.Controls.Add(this.groupBoxCarrinho);
            this.tabPageVenda.Controls.Add(this.groupBoxCliente);
            this.tabPageVenda.Controls.Add(this.dataGridViewProdutosCarrinho);
            this.tabPageVenda.Controls.Add(this.groupBoxProduto);
            this.tabPageVenda.Location = new System.Drawing.Point(4, 24);
            this.tabPageVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVenda.Name = "tabPageVenda";
            this.tabPageVenda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVenda.Size = new System.Drawing.Size(1365, 615);
            this.tabPageVenda.TabIndex = 0;
            this.tabPageVenda.Text = "Venda";
            this.tabPageVenda.UseVisualStyleBackColor = true;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCampos.Location = new System.Drawing.Point(145, 530);
            this.buttonLimparCampos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(228, 46);
            this.buttonLimparCampos.TabIndex = 0;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // tabPageHistorico
            // 
            this.tabPageHistorico.Controls.Add(this.dataGridViewHistorico);
            this.tabPageHistorico.Controls.Add(this.groupBoxConsulta);
            this.tabPageHistorico.Location = new System.Drawing.Point(4, 24);
            this.tabPageHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHistorico.Name = "tabPageHistorico";
            this.tabPageHistorico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHistorico.Size = new System.Drawing.Size(1365, 615);
            this.tabPageHistorico.TabIndex = 1;
            this.tabPageHistorico.Text = "Histórico";
            this.tabPageHistorico.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.AllowUserToAddRows = false;
            this.dataGridViewHistorico.AllowUserToDeleteRows = false;
            this.dataGridViewHistorico.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Location = new System.Drawing.Point(3, 153);
            this.dataGridViewHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.ReadOnly = true;
            this.dataGridViewHistorico.RowHeadersWidth = 62;
            this.dataGridViewHistorico.RowTemplate.Height = 28;
            this.dataGridViewHistorico.Size = new System.Drawing.Size(1362, 460);
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
            this.groupBoxConsulta.Location = new System.Drawing.Point(8, 9);
            this.groupBoxConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxConsulta.Size = new System.Drawing.Size(840, 140);
            this.groupBoxConsulta.TabIndex = 0;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // buttonDetalhes
            // 
            this.buttonDetalhes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetalhes.Location = new System.Drawing.Point(575, 46);
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
            this.buttonPesquisar.Location = new System.Drawing.Point(324, 46);
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
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1373, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlVendas);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormVendas_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.GroupBox groupBoxCarrinho;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlVendas;
        private System.Windows.Forms.TabPage tabPageVenda;
        private System.Windows.Forms.TabPage tabPageHistorico;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonDetalhes;
        private System.Windows.Forms.Button buttonLimparCampos;
        public System.Windows.Forms.TextBox textBoxTotall;
        public System.Windows.Forms.DataGridView dataGridViewProdutosCarrinho;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxDescrição;
        public System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button buttonExibirProds;
        public System.Windows.Forms.DataGridView dataGridViewHistorico;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Button buttonLimparId;
        public System.Windows.Forms.TextBox textBoxEstoque;
        public System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Button buttonLimparCpf;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        public System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}