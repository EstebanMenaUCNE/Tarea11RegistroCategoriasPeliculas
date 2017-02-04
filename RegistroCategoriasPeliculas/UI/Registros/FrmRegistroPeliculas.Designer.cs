namespace RegistroCategoriasPeliculas.UI.Registros
{
    partial class FrmRegistroPeliculas
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
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ElimiarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EstrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstrenoLabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(14, 162);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(67, 16);
            this.CategoriaLabel.TabIndex = 26;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(195, 44);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 25;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ElimiarButton
            // 
            this.ElimiarButton.Location = new System.Drawing.Point(211, 211);
            this.ElimiarButton.Name = "ElimiarButton";
            this.ElimiarButton.Size = new System.Drawing.Size(75, 23);
            this.ElimiarButton.TabIndex = 24;
            this.ElimiarButton.Text = "Eliminar";
            this.ElimiarButton.UseVisualStyleBackColor = true;
            this.ElimiarButton.Click += new System.EventHandler(this.ElimiarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(123, 211);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(35, 211);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(100, 122);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.DescripcionTextBox.TabIndex = 21;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(100, 46);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(82, 20);
            this.IdTextBox.TabIndex = 20;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(14, 124);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(80, 16);
            this.DescripcionLabel.TabIndex = 19;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(14, 47);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(70, 16);
            this.IdLabel.TabIndex = 18;
            this.IdLabel.Text = "Pelicula Id";
            // 
            // EstrenoDateTimePicker
            // 
            this.EstrenoDateTimePicker.Location = new System.Drawing.Point(100, 84);
            this.EstrenoDateTimePicker.Name = "EstrenoDateTimePicker";
            this.EstrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EstrenoDateTimePicker.TabIndex = 28;
            // 
            // EstrenoLabel
            // 
            this.EstrenoLabel.AutoSize = true;
            this.EstrenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstrenoLabel.Location = new System.Drawing.Point(14, 88);
            this.EstrenoLabel.Name = "EstrenoLabel";
            this.EstrenoLabel.Size = new System.Drawing.Size(54, 16);
            this.EstrenoLabel.TabIndex = 29;
            this.EstrenoLabel.Text = "Estreno";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DisplayMember = "Descripcion";
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(100, 161);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(200, 21);
            this.CategoriaComboBox.TabIndex = 30;
            this.CategoriaComboBox.ValueMember = "Descripcion";
            this.CategoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriaComboBox_SelectedIndexChanged);
            // 
            // FrmRegistroPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 261);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.EstrenoLabel);
            this.Controls.Add(this.EstrenoDateTimePicker);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ElimiarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "FrmRegistroPeliculas";
            this.Text = "Registro de Peliculas";
            this.Load += new System.EventHandler(this.FrmRegistroPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ElimiarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.DateTimePicker EstrenoDateTimePicker;
        private System.Windows.Forms.Label EstrenoLabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
    }
}