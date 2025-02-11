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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxTamanho = new System.Windows.Forms.TextBox();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategPub = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCategProd = new System.Windows.Forms.ComboBox();
            this.tabControlProdutos = new System.Windows.Forms.TabControl();
            this.buttonLimparPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 111);
            this.panel1.TabIndex = 3;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(-1, -1);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(103, 24);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1008, 432);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Atualizar Estoque";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1008, 432);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Produtos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxCategProd);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBoxCategPub);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxEstoque);
            this.tabPage1.Controls.Add(this.textBoxDescrição);
            this.tabPage1.Controls.Add(this.textBoxTamanho);
            this.tabPage1.Controls.Add(this.textBoxMarca);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.textBoxPreco);
            this.tabPage1.Controls.Add(this.textBoxCor);
            this.tabPage1.Controls.Add(this.textBoxNomeProd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.buttonLimpar);
            this.tabPage1.Controls.Add(this.buttonCadastrar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Estoque:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Descrição:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(397, 308);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(232, 40);
            this.buttonCadastrar.TabIndex = 37;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(397, 368);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(232, 40);
            this.buttonLimpar.TabIndex = 38;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tamanho:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Marca:";
            // 
            // textBoxNomeProd
            // 
            this.textBoxNomeProd.Location = new System.Drawing.Point(167, 191);
            this.textBoxNomeProd.Name = "textBoxNomeProd";
            this.textBoxNomeProd.Size = new System.Drawing.Size(247, 20);
            this.textBoxNomeProd.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cor:";
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(585, 80);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(229, 20);
            this.textBoxCor.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome do Produto:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(585, 186);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(229, 20);
            this.textBoxPreco.TabIndex = 35;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(167, 39);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(49, 20);
            this.textBoxID.TabIndex = 43;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(167, 240);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(247, 20);
            this.textBoxMarca.TabIndex = 44;
            // 
            // textBoxTamanho
            // 
            this.textBoxTamanho.Location = new System.Drawing.Point(585, 39);
            this.textBoxTamanho.Name = "textBoxTamanho";
            this.textBoxTamanho.Size = new System.Drawing.Size(229, 20);
            this.textBoxTamanho.TabIndex = 45;
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Location = new System.Drawing.Point(585, 133);
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.Size = new System.Drawing.Size(229, 20);
            this.textBoxDescrição.TabIndex = 46;
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Location = new System.Drawing.Point(585, 240);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(229, 20);
            this.textBoxEstoque.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria do Público:";
            // 
            // comboBoxCategPub
            // 
            this.comboBoxCategPub.FormattingEnabled = true;
            this.comboBoxCategPub.Location = new System.Drawing.Point(167, 137);
            this.comboBoxCategPub.Name = "comboBoxCategPub";
            this.comboBoxCategPub.Size = new System.Drawing.Size(247, 21);
            this.comboBoxCategPub.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Categoria do Produto:";
            // 
            // comboBoxCategProd
            // 
            this.comboBoxCategProd.FormattingEnabled = true;
            this.comboBoxCategProd.Location = new System.Drawing.Point(167, 80);
            this.comboBoxCategProd.Name = "comboBoxCategProd";
            this.comboBoxCategProd.Size = new System.Drawing.Size(247, 21);
            this.comboBoxCategProd.TabIndex = 51;
            // 
            // tabControlProdutos
            // 
            this.tabControlProdutos.Controls.Add(this.tabPage1);
            this.tabControlProdutos.Controls.Add(this.tabPage3);
            this.tabControlProdutos.Controls.Add(this.tabPage4);
            this.tabControlProdutos.Controls.Add(this.tabPage5);
            this.tabControlProdutos.Location = new System.Drawing.Point(2, 121);
            this.tabControlProdutos.Name = "tabControlProdutos";
            this.tabControlProdutos.SelectedIndex = 0;
            this.tabControlProdutos.Size = new System.Drawing.Size(1016, 474);
            this.tabControlProdutos.TabIndex = 4;
            // 
            // buttonLimparPesquisa
            // 
            this.buttonLimparPesquisa.Location = new System.Drawing.Point(203, 60);
            this.buttonLimparPesquisa.Name = "buttonLimparPesquisa";
            this.buttonLimparPesquisa.Size = new System.Drawing.Size(72, 29);
            this.buttonLimparPesquisa.TabIndex = 34;
            this.buttonLimparPesquisa.Text = "Limpar";
            this.buttonLimparPesquisa.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(818, 23);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(160, 40);
            this.buttonExcluir.TabIndex = 33;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(613, 23);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(160, 40);
            this.buttonAlterar.TabIndex = 32;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(2, 95);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(1004, 350);
            this.dataGridViewProdutos.TabIndex = 31;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(413, 23);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(160, 40);
            this.buttonPesquisar.TabIndex = 30;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisaProd
            // 
            this.textBoxPesquisaProd.Location = new System.Drawing.Point(126, 34);
            this.textBoxPesquisaProd.Name = "textBoxPesquisaProd";
            this.textBoxPesquisaProd.Size = new System.Drawing.Size(247, 20);
            this.textBoxPesquisaProd.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nome do Produto:";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 647);
            this.Controls.Add(this.tabControlProdutos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}