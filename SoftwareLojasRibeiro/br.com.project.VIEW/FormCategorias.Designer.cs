namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            this.tabControlCategorias = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.comboBoxTipoCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageConsultar = new System.Windows.Forms.TabPage();
            this.buttonLimparPesquisaProd = new System.Windows.Forms.Button();
            this.buttonExcluirProd = new System.Windows.Forms.Button();
            this.buttonAlterarProd = new System.Windows.Forms.Button();
            this.dataGridViewCatProd = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarProd = new System.Windows.Forms.Button();
            this.textBoxPesquisaNomeProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPagePub = new System.Windows.Forms.TabPage();
            this.buttonPub = new System.Windows.Forms.Button();
            this.buttonExcluirPub = new System.Windows.Forms.Button();
            this.buttonAlterarPub = new System.Windows.Forms.Button();
            this.dataGridViewCatPub = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarPub = new System.Windows.Forms.Button();
            this.textBoxPesquisaNomePub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCategorias.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatProd)).BeginInit();
            this.tabPagePub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatPub)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCategorias
            // 
            this.tabControlCategorias.Controls.Add(this.tabPageCadastrar);
            this.tabControlCategorias.Controls.Add(this.tabPageConsultar);
            this.tabControlCategorias.Controls.Add(this.tabPagePub);
            this.tabControlCategorias.Location = new System.Drawing.Point(4, 182);
            this.tabControlCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlCategorias.Name = "tabControlCategorias";
            this.tabControlCategorias.SelectedIndex = 0;
            this.tabControlCategorias.Size = new System.Drawing.Size(1369, 565);
            this.tabControlCategorias.TabIndex = 0;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.comboBoxTipoCat);
            this.tabPageCadastrar.Controls.Add(this.label5);
            this.tabPageCadastrar.Controls.Add(this.textBoxDescricao);
            this.tabPageCadastrar.Controls.Add(this.label2);
            this.tabPageCadastrar.Controls.Add(this.textBoxID);
            this.tabPageCadastrar.Controls.Add(this.textBoxNome);
            this.tabPageCadastrar.Controls.Add(this.label12);
            this.tabPageCadastrar.Controls.Add(this.buttonLimpar);
            this.tabPageCadastrar.Controls.Add(this.buttonCadastrar);
            this.tabPageCadastrar.Controls.Add(this.label7);
            this.tabPageCadastrar.Controls.Add(this.label4);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(1361, 537);
            this.tabPageCadastrar.TabIndex = 0;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoCat
            // 
            this.comboBoxTipoCat.FormattingEnabled = true;
            this.comboBoxTipoCat.Items.AddRange(new object[] {
            "Produto",
            "Publico"});
            this.comboBoxTipoCat.Location = new System.Drawing.Point(529, 128);
            this.comboBoxTipoCat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTipoCat.Name = "comboBoxTipoCat";
            this.comboBoxTipoCat.Size = new System.Drawing.Size(328, 23);
            this.comboBoxTipoCat.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Categoria:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(529, 256);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(328, 23);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Descrição:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(643, 66);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(64, 23);
            this.textBoxID.TabIndex = 25;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(529, 190);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(328, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(661, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(529, 411);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(309, 46);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(529, 342);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(309, 46);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 27);
            this.label7.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 1;
            // 
            // tabPageConsultar
            // 
            this.tabPageConsultar.Controls.Add(this.buttonLimparPesquisaProd);
            this.tabPageConsultar.Controls.Add(this.buttonExcluirProd);
            this.tabPageConsultar.Controls.Add(this.buttonAlterarProd);
            this.tabPageConsultar.Controls.Add(this.dataGridViewCatProd);
            this.tabPageConsultar.Controls.Add(this.buttonPesquisarProd);
            this.tabPageConsultar.Controls.Add(this.textBoxPesquisaNomeProd);
            this.tabPageConsultar.Controls.Add(this.label11);
            this.tabPageConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageConsultar.Name = "tabPageConsultar";
            this.tabPageConsultar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageConsultar.Size = new System.Drawing.Size(1361, 539);
            this.tabPageConsultar.TabIndex = 2;
            this.tabPageConsultar.Text = "Consultar Dados Produtos";
            this.tabPageConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparPesquisaProd
            // 
            this.buttonLimparPesquisaProd.Location = new System.Drawing.Point(276, 77);
            this.buttonLimparPesquisaProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparPesquisaProd.Name = "buttonLimparPesquisaProd";
            this.buttonLimparPesquisaProd.Size = new System.Drawing.Size(96, 33);
            this.buttonLimparPesquisaProd.TabIndex = 27;
            this.buttonLimparPesquisaProd.Text = "Limpar";
            this.buttonLimparPesquisaProd.UseVisualStyleBackColor = true;
            this.buttonLimparPesquisaProd.Click += new System.EventHandler(this.buttonLimparPesquisaProd_Click);
            // 
            // buttonExcluirProd
            // 
            this.buttonExcluirProd.Location = new System.Drawing.Point(1096, 35);
            this.buttonExcluirProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExcluirProd.Name = "buttonExcluirProd";
            this.buttonExcluirProd.Size = new System.Drawing.Size(213, 46);
            this.buttonExcluirProd.TabIndex = 26;
            this.buttonExcluirProd.Text = "Excluir";
            this.buttonExcluirProd.UseVisualStyleBackColor = true;
            this.buttonExcluirProd.Click += new System.EventHandler(this.buttonExcluirProd_Click);
            // 
            // buttonAlterarProd
            // 
            this.buttonAlterarProd.Location = new System.Drawing.Point(823, 35);
            this.buttonAlterarProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAlterarProd.Name = "buttonAlterarProd";
            this.buttonAlterarProd.Size = new System.Drawing.Size(213, 46);
            this.buttonAlterarProd.TabIndex = 25;
            this.buttonAlterarProd.Text = "Alterar";
            this.buttonAlterarProd.UseVisualStyleBackColor = true;
            this.buttonAlterarProd.Click += new System.EventHandler(this.buttonAlterarProd_Click);
            // 
            // dataGridViewCatProd
            // 
            this.dataGridViewCatProd.AllowUserToAddRows = false;
            this.dataGridViewCatProd.AllowUserToDeleteRows = false;
            this.dataGridViewCatProd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCatProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatProd.Location = new System.Drawing.Point(8, 118);
            this.dataGridViewCatProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewCatProd.Name = "dataGridViewCatProd";
            this.dataGridViewCatProd.ReadOnly = true;
            this.dataGridViewCatProd.Size = new System.Drawing.Size(1339, 404);
            this.dataGridViewCatProd.TabIndex = 24;
            // 
            // buttonPesquisarProd
            // 
            this.buttonPesquisarProd.Location = new System.Drawing.Point(556, 35);
            this.buttonPesquisarProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPesquisarProd.Name = "buttonPesquisarProd";
            this.buttonPesquisarProd.Size = new System.Drawing.Size(213, 46);
            this.buttonPesquisarProd.TabIndex = 23;
            this.buttonPesquisarProd.Text = "Pesquisar";
            this.buttonPesquisarProd.UseVisualStyleBackColor = true;
            this.buttonPesquisarProd.Click += new System.EventHandler(this.buttonPesquisarProd_Click);
            // 
            // textBoxPesquisaNomeProd
            // 
            this.textBoxPesquisaNomeProd.Location = new System.Drawing.Point(173, 47);
            this.textBoxPesquisaNomeProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPesquisaNomeProd.Name = "textBoxPesquisaNomeProd";
            this.textBoxPesquisaNomeProd.Size = new System.Drawing.Size(328, 23);
            this.textBoxPesquisaNomeProd.TabIndex = 3;
            this.textBoxPesquisaNomeProd.TextChanged += new System.EventHandler(this.textBoxPesquisaNomeProd_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome da Categoria\r\nde Produtos:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPagePub
            // 
            this.tabPagePub.Controls.Add(this.buttonPub);
            this.tabPagePub.Controls.Add(this.buttonExcluirPub);
            this.tabPagePub.Controls.Add(this.buttonAlterarPub);
            this.tabPagePub.Controls.Add(this.dataGridViewCatPub);
            this.tabPagePub.Controls.Add(this.buttonPesquisarPub);
            this.tabPagePub.Controls.Add(this.textBoxPesquisaNomePub);
            this.tabPagePub.Controls.Add(this.label6);
            this.tabPagePub.Location = new System.Drawing.Point(4, 22);
            this.tabPagePub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPagePub.Name = "tabPagePub";
            this.tabPagePub.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPagePub.Size = new System.Drawing.Size(1361, 539);
            this.tabPagePub.TabIndex = 3;
            this.tabPagePub.Text = "Consultar Dados Públicos";
            this.tabPagePub.UseVisualStyleBackColor = true;
            // 
            // buttonPub
            // 
            this.buttonPub.Location = new System.Drawing.Point(276, 77);
            this.buttonPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPub.Name = "buttonPub";
            this.buttonPub.Size = new System.Drawing.Size(96, 33);
            this.buttonPub.TabIndex = 4;
            this.buttonPub.Text = "Limpar";
            this.buttonPub.UseVisualStyleBackColor = true;
            this.buttonPub.Click += new System.EventHandler(this.buttonPub_Click);
            // 
            // buttonExcluirPub
            // 
            this.buttonExcluirPub.Location = new System.Drawing.Point(1096, 35);
            this.buttonExcluirPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExcluirPub.Name = "buttonExcluirPub";
            this.buttonExcluirPub.Size = new System.Drawing.Size(213, 46);
            this.buttonExcluirPub.TabIndex = 3;
            this.buttonExcluirPub.Text = "Excluir";
            this.buttonExcluirPub.UseVisualStyleBackColor = true;
            this.buttonExcluirPub.Click += new System.EventHandler(this.buttonExcluirPub_Click);
            // 
            // buttonAlterarPub
            // 
            this.buttonAlterarPub.Location = new System.Drawing.Point(823, 35);
            this.buttonAlterarPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAlterarPub.Name = "buttonAlterarPub";
            this.buttonAlterarPub.Size = new System.Drawing.Size(213, 46);
            this.buttonAlterarPub.TabIndex = 2;
            this.buttonAlterarPub.Text = "Alterar";
            this.buttonAlterarPub.UseVisualStyleBackColor = true;
            this.buttonAlterarPub.Click += new System.EventHandler(this.buttonAlterarPub_Click);
            // 
            // dataGridViewCatPub
            // 
            this.dataGridViewCatPub.AllowUserToAddRows = false;
            this.dataGridViewCatPub.AllowUserToDeleteRows = false;
            this.dataGridViewCatPub.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCatPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatPub.Location = new System.Drawing.Point(8, 118);
            this.dataGridViewCatPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewCatPub.Name = "dataGridViewCatPub";
            this.dataGridViewCatPub.ReadOnly = true;
            this.dataGridViewCatPub.Size = new System.Drawing.Size(1339, 404);
            this.dataGridViewCatPub.TabIndex = 6;
            // 
            // buttonPesquisarPub
            // 
            this.buttonPesquisarPub.Location = new System.Drawing.Point(556, 35);
            this.buttonPesquisarPub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPesquisarPub.Name = "buttonPesquisarPub";
            this.buttonPesquisarPub.Size = new System.Drawing.Size(213, 46);
            this.buttonPesquisarPub.TabIndex = 1;
            this.buttonPesquisarPub.Text = "Pesquisar";
            this.buttonPesquisarPub.UseVisualStyleBackColor = true;
            this.buttonPesquisarPub.Click += new System.EventHandler(this.buttonPesquisarPub_Click);
            // 
            // textBoxPesquisaNomePub
            // 
            this.textBoxPesquisaNomePub.Location = new System.Drawing.Point(173, 47);
            this.textBoxPesquisaNomePub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPesquisaNomePub.Name = "textBoxPesquisaNomePub";
            this.textBoxPesquisaNomePub.Size = new System.Drawing.Size(328, 23);
            this.textBoxPesquisaNomePub.TabIndex = 0;
            this.textBoxPesquisaNomePub.TextChanged += new System.EventHandler(this.textBoxPesquisaNomePub_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nome da Categoria\r\nde Públicos:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 165);
            this.panel1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Categorias";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlCategorias);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Categorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.tabControlCategorias.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageConsultar.ResumeLayout(false);
            this.tabPageConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatProd)).EndInit();
            this.tabPagePub.ResumeLayout(false);
            this.tabPagePub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatPub)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCategorias;
        private System.Windows.Forms.TabPage tabPageConsultar;
        private System.Windows.Forms.Button buttonLimparPesquisaProd;
        private System.Windows.Forms.Button buttonExcluirProd;
        private System.Windows.Forms.Button buttonAlterarProd;
        private System.Windows.Forms.DataGridView dataGridViewCatProd;
        private System.Windows.Forms.Button buttonPesquisarProd;
        private System.Windows.Forms.TextBox textBoxPesquisaNomeProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPagePub;
        private System.Windows.Forms.Button buttonPub;
        private System.Windows.Forms.Button buttonExcluirPub;
        private System.Windows.Forms.Button buttonAlterarPub;
        private System.Windows.Forms.DataGridView dataGridViewCatPub;
        private System.Windows.Forms.Button buttonPesquisarPub;
        private System.Windows.Forms.TextBox textBoxPesquisaNomePub;
        private System.Windows.Forms.Label label6;
    }
}