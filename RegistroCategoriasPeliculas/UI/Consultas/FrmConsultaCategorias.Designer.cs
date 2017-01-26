namespace RegistroCategoriasPeliculas.UI.Consultas
{
    partial class FrmConsultaCategorias
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
            this.CategoriasDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriasDataGridView
            // 
            this.CategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriasDataGridView.Location = new System.Drawing.Point(22, 64);
            this.CategoriasDataGridView.Name = "CategoriasDataGridView";
            this.CategoriasDataGridView.Size = new System.Drawing.Size(240, 150);
            this.CategoriasDataGridView.TabIndex = 0;
            this.CategoriasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriasDataGridView_CellContentClick);
            // 
            // FrmConsultaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CategoriasDataGridView);
            this.Name = "FrmConsultaCategorias";
            this.Text = "Consulta de Categorias";
            this.Load += new System.EventHandler(this.FrmConsultaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriasDataGridView;
    }
}