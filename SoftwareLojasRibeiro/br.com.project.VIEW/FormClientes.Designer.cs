namespace SoftwareLojasRibeiro
{
    partial class FormClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisaNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 143);
            this.panel1.TabIndex = 1;
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Controls.Add(this.tabPage2);
            this.tabControlClientes.Controls.Add(this.tabPage3);
            this.tabControlClientes.Location = new System.Drawing.Point(1, 151);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(1024, 484);
            this.tabControlClientes.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCadastrar);
            this.tabPage1.Controls.Add(this.maskedTextBoxData);
            this.tabPage1.Controls.Add(this.maskedTextBoxNumero);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxEndereco);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.maskedTextBoxCpf);
            this.tabPage1.Controls.Add(this.maskedTextBoxRg);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(387, 329);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(232, 40);
            this.buttonCadastrar.TabIndex = 22;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(619, 111);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxData.TabIndex = 21;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(136, 261);
            this.maskedTextBoxNumero.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxNumero.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Número:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(555, 197);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(229, 20);
            this.textBoxEndereco.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(135, 197);
            this.maskedTextBoxCpf.Mask = "###.###.###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxCpf.TabIndex = 10;
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(136, 114);
            this.maskedTextBoxRg.Mask = "##.###.###-##";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxRg.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "R.G:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(537, 47);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(136, 50);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(247, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Devedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewCliente);
            this.tabPage3.Controls.Add(this.buttonPesquisar);
            this.tabPage3.Controls.Add(this.textBoxPesquisaNome);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Dados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(6, 102);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.Size = new System.Drawing.Size(1004, 350);
            this.dataGridViewCliente.TabIndex = 24;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(404, 19);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(232, 40);
            this.buttonPesquisar.TabIndex = 23;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisaNome
            // 
            this.textBoxPesquisaNome.Location = new System.Drawing.Point(132, 30);
            this.textBoxPesquisaNome.Name = "textBoxPesquisaNome";
            this.textBoxPesquisaNome.Size = new System.Drawing.Size(247, 20);
            this.textBoxPesquisaNome.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome Completo:";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 647);
            this.Controls.Add(this.tabControlClientes);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientes";
            this.Text = "Lojas Ribeiro - Clientes";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisaNome;
        private System.Windows.Forms.Label label11;
    }
}

