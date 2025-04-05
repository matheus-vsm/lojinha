namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCompras = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTotalCompra = new System.Windows.Forms.TextBox();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.dataGridViewComprasCarrinho = new System.Windows.Forms.DataGridView();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.textBoxPrecoCusto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCategProd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCategPub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.textBoxTamanho = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPrecoVenda = new System.Windows.Forms.TextBox();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.textBoxNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLimparPesquisa = new System.Windows.Forms.Button();
            this.buttonAddNovaIgual = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlCompras.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasCarrinho)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Compras";
            // 
            // tabControlCompras
            // 
            this.tabControlCompras.Controls.Add(this.tabPageCadastrar);
            this.tabControlCompras.Controls.Add(this.tabPage3);
            this.tabControlCompras.Location = new System.Drawing.Point(0, 149);
            this.tabControlCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlCompras.Name = "tabControlCompras";
            this.tabControlCompras.SelectedIndex = 0;
            this.tabControlCompras.Size = new System.Drawing.Size(1374, 600);
            this.tabControlCompras.TabIndex = 0;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.label16);
            this.tabPageCadastrar.Controls.Add(this.textBoxTotalCompra);
            this.tabPageCadastrar.Controls.Add(this.buttonRemover);
            this.tabPageCadastrar.Controls.Add(this.buttonAdicionar);
            this.tabPageCadastrar.Controls.Add(this.dataGridViewComprasCarrinho);
            this.tabPageCadastrar.Controls.Add(this.comboBoxFornecedor);
            this.tabPageCadastrar.Controls.Add(this.textBoxPrecoCusto);
            this.tabPageCadastrar.Controls.Add(this.label14);
            this.tabPageCadastrar.Controls.Add(this.label13);
            this.tabPageCadastrar.Controls.Add(this.comboBoxCategProd);
            this.tabPageCadastrar.Controls.Add(this.label7);
            this.tabPageCadastrar.Controls.Add(this.comboBoxCategPub);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Controls.Add(this.textBoxQuantidade);
            this.tabPageCadastrar.Controls.Add(this.textBoxDescrição);
            this.tabPageCadastrar.Controls.Add(this.textBoxTamanho);
            this.tabPageCadastrar.Controls.Add(this.textBoxMarca);
            this.tabPageCadastrar.Controls.Add(this.textBoxID);
            this.tabPageCadastrar.Controls.Add(this.textBoxPrecoVenda);
            this.tabPageCadastrar.Controls.Add(this.textBoxCor);
            this.tabPageCadastrar.Controls.Add(this.textBoxNomeProd);
            this.tabPageCadastrar.Controls.Add(this.label2);
            this.tabPageCadastrar.Controls.Add(this.label4);
            this.tabPageCadastrar.Controls.Add(this.label5);
            this.tabPageCadastrar.Controls.Add(this.label12);
            this.tabPageCadastrar.Controls.Add(this.label6);
            this.tabPageCadastrar.Controls.Add(this.buttonLimpar);
            this.tabPageCadastrar.Controls.Add(this.buttonCadastrar);
            this.tabPageCadastrar.Controls.Add(this.label8);
            this.tabPageCadastrar.Controls.Add(this.label9);
            this.tabPageCadastrar.Controls.Add(this.label10);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(1366, 572);
            this.tabPageCadastrar.TabIndex = 0;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(622, 460);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 24);
            this.label16.TabIndex = 62;
            this.label16.Text = "Total (R$):";
            // 
            // textBoxTotalCompra
            // 
            this.textBoxTotalCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalCompra.Location = new System.Drawing.Point(623, 492);
            this.textBoxTotalCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotalCompra.Name = "textBoxTotalCompra";
            this.textBoxTotalCompra.ReadOnly = true;
            this.textBoxTotalCompra.Size = new System.Drawing.Size(115, 35);
            this.textBoxTotalCompra.TabIndex = 16;
            this.textBoxTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(17, 509);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(287, 46);
            this.buttonRemover.TabIndex = 15;
            this.buttonRemover.Text = "Remover do Carrinho";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(17, 446);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(287, 46);
            this.buttonAdicionar.TabIndex = 12;
            this.buttonAdicionar.Text = "Adicionar ao Carrinho";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // dataGridViewComprasCarrinho
            // 
            this.dataGridViewComprasCarrinho.AllowUserToAddRows = false;
            this.dataGridViewComprasCarrinho.AllowUserToDeleteRows = false;
            this.dataGridViewComprasCarrinho.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComprasCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComprasCarrinho.Location = new System.Drawing.Point(746, 424);
            this.dataGridViewComprasCarrinho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewComprasCarrinho.Name = "dataGridViewComprasCarrinho";
            this.dataGridViewComprasCarrinho.ReadOnly = true;
            this.dataGridViewComprasCarrinho.RowHeadersWidth = 62;
            this.dataGridViewComprasCarrinho.Size = new System.Drawing.Size(612, 142);
            this.dataGridViewComprasCarrinho.TabIndex = 17;
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(294, 203);
            this.comboBoxFornecedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(328, 36);
            this.comboBoxFornecedor.TabIndex = 2;
            // 
            // textBoxPrecoCusto
            // 
            this.textBoxPrecoCusto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecoCusto.Location = new System.Drawing.Point(903, 233);
            this.textBoxPrecoCusto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPrecoCusto.Name = "textBoxPrecoCusto";
            this.textBoxPrecoCusto.Size = new System.Drawing.Size(328, 35);
            this.textBoxPrecoCusto.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(680, 233);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 28);
            this.label14.TabIndex = 54;
            this.label14.Text = "Preço Custo (R$):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(131, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 28);
            this.label13.TabIndex = 52;
            this.label13.Text = "Fornecedor:";
            // 
            // comboBoxCategProd
            // 
            this.comboBoxCategProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategProd.FormattingEnabled = true;
            this.comboBoxCategProd.Location = new System.Drawing.Point(294, 93);
            this.comboBoxCategProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCategProd.Name = "comboBoxCategProd";
            this.comboBoxCategProd.Size = new System.Drawing.Size(328, 36);
            this.comboBoxCategProd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "Categoria do Produto:";
            // 
            // comboBoxCategPub
            // 
            this.comboBoxCategPub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategPub.FormattingEnabled = true;
            this.comboBoxCategPub.Location = new System.Drawing.Point(294, 145);
            this.comboBoxCategPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCategPub.Name = "comboBoxCategPub";
            this.comboBoxCategPub.Size = new System.Drawing.Size(328, 36);
            this.comboBoxCategPub.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria do Público:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidade.Location = new System.Drawing.Point(903, 309);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(328, 35);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrição.Location = new System.Drawing.Point(903, 169);
            this.textBoxDescrição.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.Size = new System.Drawing.Size(328, 35);
            this.textBoxDescrição.TabIndex = 7;
            // 
            // textBoxTamanho
            // 
            this.textBoxTamanho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTamanho.Location = new System.Drawing.Point(294, 374);
            this.textBoxTamanho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTamanho.Name = "textBoxTamanho";
            this.textBoxTamanho.Size = new System.Drawing.Size(328, 35);
            this.textBoxTamanho.TabIndex = 5;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(294, 313);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(328, 35);
            this.textBoxMarca.TabIndex = 4;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(654, 45);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(64, 35);
            this.textBoxID.TabIndex = 18;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrecoVenda
            // 
            this.textBoxPrecoVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecoVenda.Location = new System.Drawing.Point(903, 370);
            this.textBoxPrecoVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPrecoVenda.Name = "textBoxPrecoVenda";
            this.textBoxPrecoVenda.Size = new System.Drawing.Size(328, 35);
            this.textBoxPrecoVenda.TabIndex = 11;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCor.Location = new System.Drawing.Point(903, 91);
            this.textBoxCor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(328, 35);
            this.textBoxCor.TabIndex = 6;
            // 
            // textBoxNomeProd
            // 
            this.textBoxNomeProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeProd.Location = new System.Drawing.Point(294, 261);
            this.textBoxNomeProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNomeProd.Name = "textBoxNomeProd";
            this.textBoxNomeProd.Size = new System.Drawing.Size(328, 35);
            this.textBoxNomeProd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(832, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Marca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(661, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 28);
            this.label12.TabIndex = 42;
            this.label12.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tamanho:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(329, 509);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(286, 46);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar Campos";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(329, 446);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(287, 46);
            this.buttonCadastrar.TabIndex = 13;
            this.buttonCadastrar.Text = "Cadastrar Compra";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(756, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "Descrição:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(673, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 28);
            this.label9.TabIndex = 40;
            this.label9.Text = "Preço Venda (R$):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(741, 312);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 28);
            this.label10.TabIndex = 41;
            this.label10.Text = "Quantidade:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonLimparPesquisa);
            this.tabPage3.Controls.Add(this.buttonAddNovaIgual);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.buttonAlterar);
            this.tabPage3.Controls.Add(this.textBoxPesquisaProd);
            this.tabPage3.Controls.Add(this.dataGridViewCompras);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1366, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Compras";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1108, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLimparPesquisa
            // 
            this.buttonLimparPesquisa.Location = new System.Drawing.Point(294, 59);
            this.buttonLimparPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
            this.buttonLimparPesquisa.Size = new System.Drawing.Size(72, 29);
            this.buttonLimparPesquisa.TabIndex = 4;
            this.buttonLimparPesquisa.Text = "Limpar";
            this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
            // 
            // buttonAddNovaIgual
            // 
            this.buttonAddNovaIgual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNovaIgual.Location = new System.Drawing.Point(821, 23);
            this.buttonAddNovaIgual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddNovaIgual.Name = "buttonAddNovaIgual";
            this.buttonAddNovaIgual.Size = new System.Drawing.Size(248, 46);
            this.buttonAddNovaIgual.TabIndex = 3;
            this.buttonAddNovaIgual.Text = "Add Nova Compra";
            this.buttonAddNovaIgual.UseVisualStyleBackColor = true;
            this.buttonAddNovaIgual.Click += new System.EventHandler(this.buttonAddNovaIgual_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nome do Produto:";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(546, 23);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(248, 46);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Exibir Detalhes";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisaProd
            // 
            this.textBoxPesquisaProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaProd.Location = new System.Drawing.Point(173, 27);
            this.textBoxPesquisaProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPesquisaProd.Name = "textBoxPesquisaProd";
            this.textBoxPesquisaProd.Size = new System.Drawing.Size(328, 26);
            this.textBoxPesquisaProd.TabIndex = 0;
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.AllowUserToAddRows = false;
            this.dataGridViewCompras.AllowUserToDeleteRows = false;
            this.dataGridViewCompras.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(0, 94);
            this.dataGridViewCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.ReadOnly = true;
            this.dataGridViewCompras.Size = new System.Drawing.Size(1366, 478);
            this.dataGridViewCompras.TabIndex = 5;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1373, 747);
            this.Controls.Add(this.tabControlCompras);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlCompras.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasCarrinho)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlCompras;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.ComboBox comboBoxCategProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCategPub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxDescrição;
        private System.Windows.Forms.TextBox textBoxTamanho;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPrecoVenda;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.TextBox textBoxNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonLimparPesquisa;
        private System.Windows.Forms.Button buttonAddNovaIgual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxPesquisaProd;
        private System.Windows.Forms.DataGridView dataGridViewCompras;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.TextBox textBoxPrecoCusto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridViewComprasCarrinho;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTotalCompra;
    }
}