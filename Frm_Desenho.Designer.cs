namespace ProjetoGradil
{
    partial class Frm_Desenho
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
            this.Btn_Desenhar = new System.Windows.Forms.Button();
            this.Pb_Desenho = new System.Windows.Forms.PictureBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Desenho)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Desenhar
            // 
            this.Btn_Desenhar.Location = new System.Drawing.Point(121, 49);
            this.Btn_Desenhar.Name = "Btn_Desenhar";
            this.Btn_Desenhar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Desenhar.TabIndex = 0;
            this.Btn_Desenhar.Text = "Desenhar";
            this.Btn_Desenhar.UseVisualStyleBackColor = true;
            this.Btn_Desenhar.Click += new System.EventHandler(this.Btn_Desenhar_Click);
            // 
            // Pb_Desenho
            // 
            this.Pb_Desenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_Desenho.Location = new System.Drawing.Point(309, 32);
            this.Pb_Desenho.Name = "Pb_Desenho";
            this.Pb_Desenho.Size = new System.Drawing.Size(442, 365);
            this.Pb_Desenho.TabIndex = 1;
            this.Pb_Desenho.TabStop = false;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(121, 110);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Salvar.TabIndex = 2;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Frm_Desenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Pb_Desenho);
            this.Controls.Add(this.Btn_Desenhar);
            this.Name = "Frm_Desenho";
            this.Text = "Frm_Desenho";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Desenho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_Desenhar;
        private PictureBox Pb_Desenho;
        private Button Btn_Salvar;
    }
}