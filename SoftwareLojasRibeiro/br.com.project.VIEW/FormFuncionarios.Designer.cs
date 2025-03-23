namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlFuncionarios = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageConsultar = new System.Windows.Forms.TabPage();
            this.buttonLimparPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.dataGridViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisaNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlFuncionarios.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Funcionários";
            // 
            // tabControlFuncionarios
            // 
            this.tabControlFuncionarios.Controls.Add(this.tabPageCadastrar);
            this.tabControlFuncionarios.Controls.Add(this.tabPageConsultar);
            this.tabControlFuncionarios.Location = new System.Drawing.Point(0, 149);
            this.tabControlFuncionarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlFuncionarios.Name = "tabControlFuncionarios";
            this.tabControlFuncionarios.SelectedIndex = 0;
            this.tabControlFuncionarios.Size = new System.Drawing.Size(1373, 599);
            this.tabControlFuncionarios.TabIndex = 1;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.textBoxLogin);
            this.tabPageCadastrar.Controls.Add(this.label16);
            this.tabPageCadastrar.Controls.Add(this.textBoxSenha);
            this.tabPageCadastrar.Controls.Add(this.label15);
            this.tabPageCadastrar.Controls.Add(this.label14);
            this.tabPageCadastrar.Controls.Add(this.comboBoxTipoUsuario);
            this.tabPageCadastrar.Controls.Add(this.buttonBuscar);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxCep);
            this.tabPageCadastrar.Controls.Add(this.label13);
            this.tabPageCadastrar.Controls.Add(this.textBoxID);
            this.tabPageCadastrar.Controls.Add(this.textBoxEndereco);
            this.tabPageCadastrar.Controls.Add(this.textBoxEmail);
            this.tabPageCadastrar.Controls.Add(this.textBoxNome);
            this.tabPageCadastrar.Controls.Add(this.label12);
            this.tabPageCadastrar.Controls.Add(this.buttonLimpar);
            this.tabPageCadastrar.Controls.Add(this.buttonCadastrar);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxData);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxNumero);
            this.tabPageCadastrar.Controls.Add(this.label10);
            this.tabPageCadastrar.Controls.Add(this.label9);
            this.tabPageCadastrar.Controls.Add(this.label8);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxCpf);
            this.tabPageCadastrar.Controls.Add(this.maskedTextBoxRg);
            this.tabPageCadastrar.Controls.Add(this.label7);
            this.tabPageCadastrar.Controls.Add(this.label6);
            this.tabPageCadastrar.Controls.Add(this.label5);
            this.tabPageCadastrar.Controls.Add(this.label4);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Controls.Add(this.label2);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(1365, 571);
            this.tabPageCadastrar.TabIndex = 0;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(1144, 110);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(149, 23);
            this.textBoxLogin.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1068, 113);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Login:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(1144, 173);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(149, 23);
            this.textBoxSenha.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1068, 177);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "Senha:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1009, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Tipo de Usuário:";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "ADMIN",
            "NORMAL"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(1144, 52);
            this.comboBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(149, 23);
            this.comboBoxTipoUsuario.TabIndex = 9;
            this.comboBoxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoUsuario_SelectedIndexChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(847, 177);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(85, 30);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(688, 181);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(129, 23);
            this.maskedTextBoxCep.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(621, 185);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "CEP:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(183, 58);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(64, 23);
            this.textBoxID.TabIndex = 25;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(688, 227);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(304, 23);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(664, 54);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(328, 23);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(185, 125);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(328, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(489, 437);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(309, 46);
            this.buttonLimpar.TabIndex = 23;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(489, 368);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(309, 46);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(773, 128);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(219, 23);
            this.maskedTextBoxData.TabIndex = 4;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(688, 294);
            this.maskedTextBoxNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxNumero.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(304, 23);
            this.maskedTextBoxNumero.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(184, 294);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxCpf.Mask = "###,###,###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(327, 23);
            this.maskedTextBoxCpf.TabIndex = 2;
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(185, 198);
            this.maskedTextBoxRg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxRg.Mask = "##,###,###-##";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(327, 23);
            this.maskedTextBoxRg.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 27);
            this.label7.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "R.G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
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
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo:";
            // 
            // tabPageConsultar
            // 
            this.tabPageConsultar.Controls.Add(this.buttonLimparPesquisa);
            this.tabPageConsultar.Controls.Add(this.buttonExcluir);
            this.tabPageConsultar.Controls.Add(this.buttonAlterar);
            this.tabPageConsultar.Controls.Add(this.dataGridViewFuncionarios);
            this.tabPageConsultar.Controls.Add(this.buttonPesquisar);
            this.tabPageConsultar.Controls.Add(this.textBoxPesquisaNome);
            this.tabPageConsultar.Controls.Add(this.label11);
            this.tabPageConsultar.Location = new System.Drawing.Point(4, 24);
            this.tabPageConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageConsultar.Name = "tabPageConsultar";
            this.tabPageConsultar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageConsultar.Size = new System.Drawing.Size(1357, 563);
            this.tabPageConsultar.TabIndex = 2;
            this.tabPageConsultar.Text = "Consultar Dados";
            this.tabPageConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparPesquisa
            // 
            this.buttonLimparPesquisa.Location = new System.Drawing.Point(276, 77);
            this.buttonLimparPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
            this.buttonLimparPesquisa.Size = new System.Drawing.Size(96, 33);
            this.buttonLimparPesquisa.TabIndex = 4;
            this.buttonLimparPesquisa.Text = "Limpar";
            this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
            this.buttonLimparPesquisa.Click += new System.EventHandler(this.buttonLimparPesquisa_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(1096, 35);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(213, 46);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(823, 35);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(213, 46);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.AllowUserToAddRows = false;
            this.dataGridViewFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(8, 118);
            this.dataGridViewFuncionarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.ReadOnly = true;
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(1339, 404);
            this.dataGridViewFuncionarios.TabIndex = 5;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(556, 35);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(213, 46);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxPesquisaNome
            // 
            this.textBoxPesquisaNome.Location = new System.Drawing.Point(173, 47);
            this.textBoxPesquisaNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPesquisaNome.Name = "textBoxPesquisaNome";
            this.textBoxPesquisaNome.Size = new System.Drawing.Size(328, 23);
            this.textBoxPesquisaNome.TabIndex = 0;
            this.textBoxPesquisaNome.TextChanged += new System.EventHandler(this.textBoxPesquisaNome_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome do Funcionário:";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1373, 747);
            this.Controls.Add(this.tabControlFuncionarios);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Funcionários";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlFuncionarios.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageConsultar.ResumeLayout(false);
            this.tabPageConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlFuncionarios;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageConsultar;
        private System.Windows.Forms.Button buttonLimparPesquisa;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.DataGridView dataGridViewFuncionarios;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisaNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}