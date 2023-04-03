namespace ProjetoGradil
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Descricao = new System.Windows.Forms.Label();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titulo.Location = new System.Drawing.Point(154, 29);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(300, 23);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Gradil - Soluções em Cerca";
            // 
            // Lbl_Descricao
            // 
            this.Lbl_Descricao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Descricao.Location = new System.Drawing.Point(42, 105);
            this.Lbl_Descricao.Name = "Lbl_Descricao";
            this.Lbl_Descricao.Size = new System.Drawing.Size(593, 72);
            this.Lbl_Descricao.TabIndex = 1;
            this.Lbl_Descricao.Text = "O Gradil é uma solução prática, robusta e inteligente para fechamentos que necess" +
    "item de maior segurança e estética. \r\n";
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Calcular.Image")));
            this.Btn_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Calcular.Location = new System.Drawing.Point(145, 207);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(140, 80);
            this.Btn_Calcular.TabIndex = 0;
            this.Btn_Calcular.TabStop = false;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consultar.Image")));
            this.Btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar.Location = new System.Drawing.Point(318, 207);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(162, 80);
            this.Btn_Consultar.TabIndex = 0;
            this.Btn_Consultar.TabStop = false;
            this.Btn_Consultar.Text = "Histórico";
            this.Btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Frm_Principal
            // 
            this.ClientSize = new System.Drawing.Size(647, 338);
            this.Controls.Add(this.Lbl_Descricao);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Btn_Calcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradil - Soluções em Cerca";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label Lbl_Titulo;
        private Label Lbl_Descricao;
        private Button Btn_Calcular;
        private Button Btn_Consultar;
    }
}