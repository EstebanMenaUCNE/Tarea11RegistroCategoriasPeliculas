namespace RegistroCategoriasPeliculas.UI.Consultas
{
    partial class FrmConsultaUsuarios
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
            this.UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(22, 55);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.Size = new System.Drawing.Size(398, 150);
            this.UsuariosDataGridView.TabIndex = 1;
            // 
            // FrmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 261);
            this.Controls.Add(this.UsuariosDataGridView);
            this.Name = "FrmConsultaUsuarios";
            this.Text = "Consulta de Usuarios";
            this.Load += new System.EventHandler(this.FrmConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariosDataGridView;
    }
}