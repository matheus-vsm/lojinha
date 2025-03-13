namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    partial class FormExibirProdutos
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
            this.dataGridViewProds = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProds
            // 
            this.dataGridViewProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProds.Location = new System.Drawing.Point(4, 136);
            this.dataGridViewProds.Name = "dataGridViewProds";
            this.dataGridViewProds.Size = new System.Drawing.Size(792, 312);
            this.dataGridViewProds.TabIndex = 0;
            this.dataGridViewProds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProds_CellClick);
            this.dataGridViewProds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProds_CellContentClick);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(224, 94);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(325, 20);
            this.textBoxPesquisar.TabIndex = 1;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Produtos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 70);
            this.panel1.TabIndex = 18;
            // 
            // FormExibirProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.dataGridViewProds);
            this.Name = "FormExibirProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojas Ribeiro - Lista de Produtos";
            this.Load += new System.EventHandler(this.FormExibirProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProds;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}