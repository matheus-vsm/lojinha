using System;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlFornecedores = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageConsultar = new System.Windows.Forms.TabPage();
            this.buttonLimparPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAltera = new System.Windows.Forms.Button();
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisaNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlFornecedores.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Fornecedores";
            // 
            // tabControlFornecedores
            // 
            this.tabControlFornecedores.Controls.Add(this.tabPageCadastrar);
            this.tabControlFornecedores.Controls.Add(this.tabPageConsultar);
            this.tabControlFornecedores.Location = new System.Drawing.Point(0, 149);
            this.tabControlFornecedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlFornecedores.Name = "tabControlFornecedores";
            this.tabControlFornecedores.SelectedIndex = 0;
            this.tabControlFornecedores.Size = new System.Drawing.Size(1373, 600);
            this.tabControlFornecedores.TabIndex = 1;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxCelular);
            this.tabPageCadastrar.Controls.Add(this.label6);
            this.tabPageCadastrar.Controls.Add(this.textBoxID);
            this.tabPageCadastrar.Controls.Add(this.textBoxEndereco);
            this.tabPageCadastrar.Controls.Add(this.textBoxEmail);
            this.tabPageCadastrar.Controls.Add(this.textBoxNome);
            this.tabPageCadastrar.Controls.Add(this.buttonBuscar);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxCep);
            this.tabPageCadastrar.Controls.Add(this.label13);
            this.tabPageCadastrar.Controls.Add(this.label12);
            this.tabPageCadastrar.Controls.Add(this.buttonLimpar);
            this.tabPageCadastrar.Controls.Add(this.buttonCadastrar);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxTelefone);
            this.tabPageCadastrar.Controls.Add(this.label10);
            this.tabPageCadastrar.Controls.Add(this.label9);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxCnpj);
            this.tabPageCadastrar.Controls.Add(this.label7);
            this.tabPageCadastrar.Controls.Add(this.label5);
            this.tabPageCadastrar.Controls.Add(this.label4);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Controls.Add(this.label2);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(1365, 572);
            this.tabPageCadastrar.TabIndex = 0;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(913, 191);
            this.maskedTextBoxCelular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxCelular.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(215, 35);
            this.maskedTextBoxCelular.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label6.Location = new System.Drawing.Point(800, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "Celular:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.textBoxID.Location = new System.Drawing.Point(673, 54);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(64, 35);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.textBoxEndereco.Location = new System.Drawing.Point(913, 325);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(368, 35);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.textBoxEmail.Location = new System.Drawing.Point(275, 325);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(356, 35);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.textBoxNome.Location = new System.Drawing.Point(275, 125);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(356, 35);
            this.textBoxNome.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(1081, 263);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(64, 26);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.maskedTextBoxCep.Location = new System.Drawing.Point(913, 259);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(152, 35);
            this.maskedTextBoxCep.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label13.Location = new System.Drawing.Point(842, 262);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 28);
            this.label13.TabIndex = 26;
            this.label13.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label12.Location = new System.Drawing.Point(682, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(569, 489);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(309, 46);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(569, 406);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(309, 46);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(913, 128);
            this.maskedTextBoxTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxTelefone.Mask = "(00) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(215, 35);
            this.maskedTextBoxTelefone.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label10.Location = new System.Drawing.Point(785, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label9.Location = new System.Drawing.Point(773, 328);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Endereço:";
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(275, 229);
            this.maskedTextBoxCnpj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxCnpj.Mask = "##,###,###/####-##";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(278, 35);
            this.maskedTextBoxCnpj.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 27);
            this.label7.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label5.Location = new System.Drawing.Point(175, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label4.Location = new System.Drawing.Point(175, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Fornecedor:";
            // 
            // tabPageConsultar
            // 
            this.tabPageConsultar.Controls.Add(this.buttonLimparPesquisa);
            this.tabPageConsultar.Controls.Add(this.buttonExcluir);
            this.tabPageConsultar.Controls.Add(this.buttonAltera);
            this.tabPageConsultar.Controls.Add(this.dataGridViewFornecedores);
            this.tabPageConsultar.Controls.Add(this.textBoxPesquisaNome);
            this.tabPageConsultar.Controls.Add(this.label11);
            this.tabPageConsultar.Location = new System.Drawing.Point(4, 24);
            this.tabPageConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageConsultar.Name = "tabPageConsultar";
            this.tabPageConsultar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageConsultar.Size = new System.Drawing.Size(1365, 572);
            this.tabPageConsultar.TabIndex = 2;
            this.tabPageConsultar.Text = "Consultar Dados";
            this.tabPageConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparPesquisa
            // 
            this.buttonLimparPesquisa.Location = new System.Drawing.Point(385, 65);
            this.buttonLimparPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
            this.buttonLimparPesquisa.Size = new System.Drawing.Size(72, 29);
            this.buttonLimparPesquisa.TabIndex = 27;
            this.buttonLimparPesquisa.Text = "Limpar";
            this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
            this.buttonLimparPesquisa.Click += new System.EventHandler(this.buttonLimparPesquisa_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(1034, 24);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(271, 46);
            this.buttonExcluir.TabIndex = 26;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAltera
            // 
            this.buttonAltera.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltera.Location = new System.Drawing.Point(677, 24);
            this.buttonAltera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAltera.Name = "buttonAltera";
            this.buttonAltera.Size = new System.Drawing.Size(271, 46);
            this.buttonAltera.TabIndex = 25;
            this.buttonAltera.Text = "Alterar";
            this.buttonAltera.UseVisualStyleBackColor = true;
            this.buttonAltera.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.AllowUserToAddRows = false;
            this.dataGridViewFornecedores.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(0, 97);
            this.dataGridViewFornecedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.ReadOnly = true;
            this.dataGridViewFornecedores.RowHeadersWidth = 51;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(1365, 475);
            this.dataGridViewFornecedores.TabIndex = 24;
            // 
            // textBoxPesquisaNome
            // 
            this.textBoxPesquisaNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaNome.Location = new System.Drawing.Point(259, 30);
            this.textBoxPesquisaNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPesquisaNome.Name = "textBoxPesquisaNome";
            this.textBoxPesquisaNome.Size = new System.Drawing.Size(328, 29);
            this.textBoxPesquisaNome.TabIndex = 3;
            this.textBoxPesquisaNome.TextChanged += new System.EventHandler(this.textBoxPesquisaNome_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome do Fornecedor:";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1373, 747);
            this.Controls.Add(this.tabControlFornecedores);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Fornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlFornecedores.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageConsultar.ResumeLayout(false);
            this.tabPageConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.ResumeLayout(false);

        }
        // Remover a assinatura duplicada do evento buttonLimparPesquisar_Click
        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            // Limpar o campo de pesquisa
            textBoxPesquisaNome.Clear();
            Pesquisa();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlFornecedores;
        private System.Windows.Forms.TabPage tabPageConsultar;
        private System.Windows.Forms.Button buttonLimparPesquisa;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAltera;
        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private System.Windows.Forms.TextBox textBoxPesquisaNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCnpj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}