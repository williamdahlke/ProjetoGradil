namespace ProjetoGradil
{
    partial class Frm_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Historico));
            this.Dgv_Historico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historico)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Historico
            // 
            this.Dgv_Historico.AllowUserToAddRows = false;
            this.Dgv_Historico.AllowUserToDeleteRows = false;
            this.Dgv_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Historico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Historico.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Historico.Name = "Dgv_Historico";
            this.Dgv_Historico.ReadOnly = true;
            this.Dgv_Historico.RowHeadersWidth = 62;
            this.Dgv_Historico.RowTemplate.Height = 33;
            this.Dgv_Historico.Size = new System.Drawing.Size(959, 270);
            this.Dgv_Historico.TabIndex = 0;
            // 
            // Frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 270);
            this.Controls.Add(this.Dgv_Historico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Historico";
            this.Text = "Histórico";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Dgv_Historico;
    }
}