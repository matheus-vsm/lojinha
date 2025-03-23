namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonLimparPesquisa = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.comboBoxCategProd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCategPub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.textBoxTamanho = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
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
            this.tabControlProdutos = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.tabPageCadastrar.SuspendLayout();
            this.tabControlProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Produtos";
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
            this.panel1.TabIndex = 3;
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
            this.buttonMenu.Location = new System.Drawing.Point(-1, -1);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(125, 39);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Size = new System.Drawing.Size(1363, 569);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Atualizar Estoque";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Size = new System.Drawing.Size(1363, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Atualizar Preço";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonLimparPesquisa);
            this.tabPage3.Controls.Add(this.buttonPesquisar);
            this.tabPage3.Controls.Add(this.buttonExcluir);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.buttonAlterar);
            this.tabPage3.Controls.Add(this.textBoxPesquisaProd);
            this.tabPage3.Controls.Add(this.dataGridViewProdutos);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1363, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Produtos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonLimparPesquisa
            // 
            this.buttonLimparPesquisa.Location = new System.Drawing.Point(271, 69);
            this.buttonLimparPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
            this.buttonLimparPesquisa.Size = new System.Drawing.Size(96, 33);
            this.buttonLimparPesquisa.TabIndex = 4;
            this.buttonLimparPesquisa.Text = "Limpar";
            this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
            this.buttonLimparPesquisa.Click += new System.EventHandler(this.buttonLimparPesquisa_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(551, 27);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(213, 46);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(1091, 27);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(213, 46);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nome do Produto:";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(817, 27);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(213, 46);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // textBoxPesquisaProd
            // 
            this.textBoxPesquisaProd.Location = new System.Drawing.Point(168, 39);
            this.textBoxPesquisaProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPesquisaProd.Name = "textBoxPesquisaProd";
            this.textBoxPesquisaProd.Size = new System.Drawing.Size(328, 23);
            this.textBoxPesquisaProd.TabIndex = 0;
            this.textBoxPesquisaProd.TextChanged += new System.EventHandler(this.textBoxPesquisaProd_TextChanged);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(3, 110);
            this.dataGridViewProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(1353, 459);
            this.dataGridViewProdutos.TabIndex = 5;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.comboBoxCategProd);
            this.tabPageCadastrar.Controls.Add(this.label7);
            this.tabPageCadastrar.Controls.Add(this.comboBoxCategPub);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Controls.Add(this.textBoxEstoque);
            this.tabPageCadastrar.Controls.Add(this.textBoxDescrição);
            this.tabPageCadastrar.Controls.Add(this.textBoxTamanho);
            this.tabPageCadastrar.Controls.Add(this.textBoxMarca);
            this.tabPageCadastrar.Controls.Add(this.textBoxID);
            this.tabPageCadastrar.Controls.Add(this.textBoxPreco);
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
            // comboBoxCategProd
            // 
            this.comboBoxCategProd.FormattingEnabled = true;
            this.comboBoxCategProd.Location = new System.Drawing.Point(223, 92);
            this.comboBoxCategProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCategProd.Name = "comboBoxCategProd";
            this.comboBoxCategProd.Size = new System.Drawing.Size(328, 23);
            this.comboBoxCategProd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "Categoria do Produto:";
            // 
            // comboBoxCategPub
            // 
            this.comboBoxCategPub.FormattingEnabled = true;
            this.comboBoxCategPub.Location = new System.Drawing.Point(223, 158);
            this.comboBoxCategPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCategPub.Name = "comboBoxCategPub";
            this.comboBoxCategPub.Size = new System.Drawing.Size(328, 23);
            this.comboBoxCategPub.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria do Público:";
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Location = new System.Drawing.Point(780, 277);
            this.textBoxEstoque.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(304, 23);
            this.textBoxEstoque.TabIndex = 8;
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Location = new System.Drawing.Point(780, 153);
            this.textBoxDescrição.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.Size = new System.Drawing.Size(304, 23);
            this.textBoxDescrição.TabIndex = 6;
            // 
            // textBoxTamanho
            // 
            this.textBoxTamanho.Location = new System.Drawing.Point(780, 45);
            this.textBoxTamanho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTamanho.Name = "textBoxTamanho";
            this.textBoxTamanho.Size = new System.Drawing.Size(304, 23);
            this.textBoxTamanho.TabIndex = 4;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(223, 277);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(328, 23);
            this.textBoxMarca.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(223, 45);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(64, 23);
            this.textBoxID.TabIndex = 43;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(780, 215);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(304, 23);
            this.textBoxPreco.TabIndex = 7;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(780, 92);
            this.textBoxCor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(304, 23);
            this.textBoxCor.TabIndex = 5;
            // 
            // textBoxNomeProd
            // 
            this.textBoxNomeProd.Location = new System.Drawing.Point(223, 220);
            this.textBoxNomeProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNomeProd.Name = "textBoxNomeProd";
            this.textBoxNomeProd.Size = new System.Drawing.Size(328, 23);
            this.textBoxNomeProd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Marca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tamanho:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(529, 425);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(309, 46);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(529, 355);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(309, 46);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Descrição:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Preço (R$):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 285);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Estoque:";
            // 
            // tabControlProdutos
            // 
            this.tabControlProdutos.Controls.Add(this.tabPageCadastrar);
            this.tabControlProdutos.Controls.Add(this.tabPage3);
            this.tabControlProdutos.Controls.Add(this.tabPage4);
            this.tabControlProdutos.Controls.Add(this.tabPage5);
            this.tabControlProdutos.Location = new System.Drawing.Point(0, 149);
            this.tabControlProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlProdutos.Name = "tabControlProdutos";
            this.tabControlProdutos.SelectedIndex = 0;
            this.tabControlProdutos.Size = new System.Drawing.Size(1374, 600);
            this.tabControlProdutos.TabIndex = 0;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1373, 747);
            this.Controls.Add(this.tabControlProdutos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabControlProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.ComboBox comboBoxCategProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCategPub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEstoque;
        private System.Windows.Forms.TextBox textBoxDescrição;
        private System.Windows.Forms.TextBox textBoxTamanho;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPreco;
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
        private System.Windows.Forms.TabControl tabControlProdutos;
        private System.Windows.Forms.Button buttonLimparPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxPesquisaProd;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}