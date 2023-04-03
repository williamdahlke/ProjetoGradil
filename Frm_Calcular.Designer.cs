namespace ProjetoGradil
{
    partial class Frm_Calcular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Calcular));
            this.Lbl_Comprimento = new System.Windows.Forms.Label();
            this.Txt_Comprimento = new System.Windows.Forms.TextBox();
            this.Lbl_ComprimentoUn = new System.Windows.Forms.Label();
            this.Rb_Altura1 = new System.Windows.Forms.RadioButton();
            this.Lbl_Altura = new System.Windows.Forms.Label();
            this.Gb_Altura = new System.Windows.Forms.GroupBox();
            this.Lbl_Unidade3 = new System.Windows.Forms.Label();
            this.Lbl_Unidade2 = new System.Windows.Forms.Label();
            this.Lbl_Unidade1 = new System.Windows.Forms.Label();
            this.Rb_Altura3 = new System.Windows.Forms.RadioButton();
            this.Rb_Altura2 = new System.Windows.Forms.RadioButton();
            this.Lbl_Cor = new System.Windows.Forms.Label();
            this.Cb_Cor = new System.Windows.Forms.ComboBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Txt_ComprimentoComprar = new System.Windows.Forms.TextBox();
            this.Txt_DiferencaComprimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_ListaMateriais = new System.Windows.Forms.DataGridView();
            this.Lbl_ListaMateriais = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Desenho = new System.Windows.Forms.Button();
            this.Gb_Altura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Comprimento
            // 
            this.Lbl_Comprimento.AutoSize = true;
            this.Lbl_Comprimento.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Comprimento.Location = new System.Drawing.Point(20, 36);
            this.Lbl_Comprimento.Name = "Lbl_Comprimento";
            this.Lbl_Comprimento.Size = new System.Drawing.Size(204, 26);
            this.Lbl_Comprimento.TabIndex = 0;
            this.Lbl_Comprimento.Text = "Comprimento cerca:";
            // 
            // Txt_Comprimento
            // 
            this.Txt_Comprimento.Location = new System.Drawing.Point(271, 36);
            this.Txt_Comprimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Comprimento.Name = "Txt_Comprimento";
            this.Txt_Comprimento.Size = new System.Drawing.Size(97, 31);
            this.Txt_Comprimento.TabIndex = 1;
            this.Txt_Comprimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Comprimento_KeyPress);
            // 
            // Lbl_ComprimentoUn
            // 
            this.Lbl_ComprimentoUn.AutoSize = true;
            this.Lbl_ComprimentoUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ComprimentoUn.Location = new System.Drawing.Point(376, 36);
            this.Lbl_ComprimentoUn.Name = "Lbl_ComprimentoUn";
            this.Lbl_ComprimentoUn.Size = new System.Drawing.Size(29, 25);
            this.Lbl_ComprimentoUn.TabIndex = 2;
            this.Lbl_ComprimentoUn.Text = "m";
            // 
            // Rb_Altura1
            // 
            this.Rb_Altura1.AutoSize = true;
            this.Rb_Altura1.Checked = true;
            this.Rb_Altura1.Location = new System.Drawing.Point(18, 58);
            this.Rb_Altura1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_Altura1.Name = "Rb_Altura1";
            this.Rb_Altura1.Size = new System.Drawing.Size(71, 29);
            this.Rb_Altura1.TabIndex = 3;
            this.Rb_Altura1.TabStop = true;
            this.Rb_Altura1.Text = "1,03";
            this.Rb_Altura1.UseVisualStyleBackColor = true;
            // 
            // Lbl_Altura
            // 
            this.Lbl_Altura.AutoSize = true;
            this.Lbl_Altura.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Altura.Location = new System.Drawing.Point(20, 109);
            this.Lbl_Altura.Name = "Lbl_Altura";
            this.Lbl_Altura.Size = new System.Drawing.Size(166, 26);
            this.Lbl_Altura.TabIndex = 4;
            this.Lbl_Altura.Text = "Altura da Cerca:";
            // 
            // Gb_Altura
            // 
            this.Gb_Altura.Controls.Add(this.Lbl_Unidade3);
            this.Gb_Altura.Controls.Add(this.Lbl_Unidade2);
            this.Gb_Altura.Controls.Add(this.Lbl_Unidade1);
            this.Gb_Altura.Controls.Add(this.Rb_Altura3);
            this.Gb_Altura.Controls.Add(this.Rb_Altura2);
            this.Gb_Altura.Controls.Add(this.Rb_Altura1);
            this.Gb_Altura.Location = new System.Drawing.Point(271, 95);
            this.Gb_Altura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gb_Altura.Name = "Gb_Altura";
            this.Gb_Altura.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gb_Altura.Size = new System.Drawing.Size(457, 131);
            this.Gb_Altura.TabIndex = 5;
            this.Gb_Altura.TabStop = false;
            // 
            // Lbl_Unidade3
            // 
            this.Lbl_Unidade3.AutoSize = true;
            this.Lbl_Unidade3.Location = new System.Drawing.Point(356, 61);
            this.Lbl_Unidade3.Name = "Lbl_Unidade3";
            this.Lbl_Unidade3.Size = new System.Drawing.Size(28, 25);
            this.Lbl_Unidade3.TabIndex = 8;
            this.Lbl_Unidade3.Text = "m";
            // 
            // Lbl_Unidade2
            // 
            this.Lbl_Unidade2.AutoSize = true;
            this.Lbl_Unidade2.Location = new System.Drawing.Point(218, 61);
            this.Lbl_Unidade2.Name = "Lbl_Unidade2";
            this.Lbl_Unidade2.Size = new System.Drawing.Size(28, 25);
            this.Lbl_Unidade2.TabIndex = 7;
            this.Lbl_Unidade2.Text = "m";
            // 
            // Lbl_Unidade1
            // 
            this.Lbl_Unidade1.AutoSize = true;
            this.Lbl_Unidade1.Location = new System.Drawing.Point(87, 61);
            this.Lbl_Unidade1.Name = "Lbl_Unidade1";
            this.Lbl_Unidade1.Size = new System.Drawing.Size(28, 25);
            this.Lbl_Unidade1.TabIndex = 6;
            this.Lbl_Unidade1.Text = "m";
            // 
            // Rb_Altura3
            // 
            this.Rb_Altura3.AutoSize = true;
            this.Rb_Altura3.Location = new System.Drawing.Point(288, 58);
            this.Rb_Altura3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_Altura3.Name = "Rb_Altura3";
            this.Rb_Altura3.Size = new System.Drawing.Size(71, 29);
            this.Rb_Altura3.TabIndex = 5;
            this.Rb_Altura3.Text = "2,03";
            this.Rb_Altura3.UseVisualStyleBackColor = true;
            // 
            // Rb_Altura2
            // 
            this.Rb_Altura2.AutoSize = true;
            this.Rb_Altura2.Location = new System.Drawing.Point(151, 58);
            this.Rb_Altura2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_Altura2.Name = "Rb_Altura2";
            this.Rb_Altura2.Size = new System.Drawing.Size(71, 29);
            this.Rb_Altura2.TabIndex = 4;
            this.Rb_Altura2.Text = "1,53";
            this.Rb_Altura2.UseVisualStyleBackColor = true;
            // 
            // Lbl_Cor
            // 
            this.Lbl_Cor.AutoSize = true;
            this.Lbl_Cor.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cor.Location = new System.Drawing.Point(20, 255);
            this.Lbl_Cor.Name = "Lbl_Cor";
            this.Lbl_Cor.Size = new System.Drawing.Size(140, 26);
            this.Lbl_Cor.TabIndex = 6;
            this.Lbl_Cor.Text = "Cor da Cerca:";
            // 
            // Cb_Cor
            // 
            this.Cb_Cor.FormattingEnabled = true;
            this.Cb_Cor.Location = new System.Drawing.Point(271, 256);
            this.Cb_Cor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cb_Cor.Name = "Cb_Cor";
            this.Cb_Cor.Size = new System.Drawing.Size(273, 33);
            this.Cb_Cor.TabIndex = 7;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(447, 312);
            this.Btn_Calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(118, 78);
            this.Btn_Calcular.TabIndex = 9;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(571, 312);
            this.Btn_Confirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(118, 78);
            this.Btn_Confirmar.TabIndex = 10;
            this.Btn_Confirmar.Text = "Confirmar Pedido";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Txt_ComprimentoComprar
            // 
            this.Txt_ComprimentoComprar.Location = new System.Drawing.Point(294, 399);
            this.Txt_ComprimentoComprar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_ComprimentoComprar.Name = "Txt_ComprimentoComprar";
            this.Txt_ComprimentoComprar.ReadOnly = true;
            this.Txt_ComprimentoComprar.Size = new System.Drawing.Size(111, 31);
            this.Txt_ComprimentoComprar.TabIndex = 11;
            this.Txt_ComprimentoComprar.TabStop = false;
            // 
            // Txt_DiferencaComprimento
            // 
            this.Txt_DiferencaComprimento.Location = new System.Drawing.Point(294, 455);
            this.Txt_DiferencaComprimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_DiferencaComprimento.Name = "Txt_DiferencaComprimento";
            this.Txt_DiferencaComprimento.ReadOnly = true;
            this.Txt_DiferencaComprimento.Size = new System.Drawing.Size(111, 31);
            this.Txt_DiferencaComprimento.TabIndex = 12;
            this.Txt_DiferencaComprimento.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Comprimento Total a Comprar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Diferença de Comprimento";
            // 
            // Dgv_ListaMateriais
            // 
            this.Dgv_ListaMateriais.AllowUserToAddRows = false;
            this.Dgv_ListaMateriais.AllowUserToDeleteRows = false;
            this.Dgv_ListaMateriais.AllowUserToOrderColumns = true;
            this.Dgv_ListaMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListaMateriais.Location = new System.Drawing.Point(26, 569);
            this.Dgv_ListaMateriais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_ListaMateriais.Name = "Dgv_ListaMateriais";
            this.Dgv_ListaMateriais.ReadOnly = true;
            this.Dgv_ListaMateriais.RowHeadersWidth = 62;
            this.Dgv_ListaMateriais.RowTemplate.Height = 28;
            this.Dgv_ListaMateriais.Size = new System.Drawing.Size(452, 172);
            this.Dgv_ListaMateriais.TabIndex = 16;
            // 
            // Lbl_ListaMateriais
            // 
            this.Lbl_ListaMateriais.AutoSize = true;
            this.Lbl_ListaMateriais.Location = new System.Drawing.Point(29, 526);
            this.Lbl_ListaMateriais.Name = "Lbl_ListaMateriais";
            this.Lbl_ListaMateriais.Size = new System.Drawing.Size(148, 25);
            this.Lbl_ListaMateriais.TabIndex = 17;
            this.Lbl_ListaMateriais.Text = "Lista de Materiais";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(698, 312);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(118, 78);
            this.Btn_Limpar.TabIndex = 18;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Desenho
            // 
            this.Btn_Desenho.Location = new System.Drawing.Point(447, 408);
            this.Btn_Desenho.Name = "Btn_Desenho";
            this.Btn_Desenho.Size = new System.Drawing.Size(118, 78);
            this.Btn_Desenho.TabIndex = 19;
            this.Btn_Desenho.Text = "Desenho";
            this.Btn_Desenho.UseVisualStyleBackColor = true;
            this.Btn_Desenho.Click += new System.EventHandler(this.Btn_Desenho_Click);
            // 
            // Frm_Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 767);
            this.Controls.Add(this.Btn_Desenho);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Lbl_ListaMateriais);
            this.Controls.Add(this.Dgv_ListaMateriais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_DiferencaComprimento);
            this.Controls.Add(this.Txt_ComprimentoComprar);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Cb_Cor);
            this.Controls.Add(this.Lbl_Cor);
            this.Controls.Add(this.Gb_Altura);
            this.Controls.Add(this.Lbl_Altura);
            this.Controls.Add(this.Lbl_ComprimentoUn);
            this.Controls.Add(this.Txt_Comprimento);
            this.Controls.Add(this.Lbl_Comprimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Calcular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grandil - Calcular Cerca";
            this.Gb_Altura.ResumeLayout(false);
            this.Gb_Altura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaMateriais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Comprimento;
        private System.Windows.Forms.TextBox Txt_Comprimento;
        private System.Windows.Forms.Label Lbl_ComprimentoUn;
        private System.Windows.Forms.RadioButton Rb_Altura1;
        private System.Windows.Forms.Label Lbl_Altura;
        private System.Windows.Forms.GroupBox Gb_Altura;
        private System.Windows.Forms.RadioButton Rb_Altura3;
        private System.Windows.Forms.RadioButton Rb_Altura2;
        private System.Windows.Forms.Label Lbl_Cor;
        private System.Windows.Forms.ComboBox Cb_Cor;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Label Lbl_Unidade3;
        private System.Windows.Forms.Label Lbl_Unidade2;
        private System.Windows.Forms.Label Lbl_Unidade1;
        private System.Windows.Forms.TextBox Txt_ComprimentoComprar;
        private System.Windows.Forms.TextBox Txt_DiferencaComprimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_ListaMateriais;
        private System.Windows.Forms.Label Lbl_ListaMateriais;
        private System.Windows.Forms.Button Btn_Limpar;
        private Button Btn_Desenho;
    }
}

