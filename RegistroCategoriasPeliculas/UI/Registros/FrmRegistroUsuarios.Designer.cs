namespace RegistroCategoriasPeliculas.UI.Registros
{
    partial class FrmRegistroUsuarios
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ElimiarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(195, 57);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ElimiarButton
            // 
            this.ElimiarButton.Location = new System.Drawing.Point(195, 187);
            this.ElimiarButton.Name = "ElimiarButton";
            this.ElimiarButton.Size = new System.Drawing.Size(75, 23);
            this.ElimiarButton.TabIndex = 14;
            this.ElimiarButton.Text = "Eliminar";
            this.ElimiarButton.UseVisualStyleBackColor = true;
            this.ElimiarButton.Click += new System.EventHandler(this.ElimiarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(107, 187);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(19, 187);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 12;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(100, 97);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(170, 20);
            this.NombreTextBox.TabIndex = 11;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(100, 59);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(82, 20);
            this.IdTextBox.TabIndex = 10;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(14, 98);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(57, 16);
            this.NombreLabel.TabIndex = 9;
            this.NombreLabel.Text = "Nombre";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(14, 60);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(69, 16);
            this.IdLabel.TabIndex = 8;
            this.IdLabel.Text = "Usuario Id";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(100, 135);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(170, 20);
            this.ClaveTextBox.TabIndex = 17;
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveLabel.Location = new System.Drawing.Point(14, 136);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(43, 16);
            this.ClaveLabel.TabIndex = 16;
            this.ClaveLabel.Text = "Clave";
            // 
            // FrmRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ElimiarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "FrmRegistroUsuarios";
            this.Text = "Registro de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ElimiarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.Label ClaveLabel;
    }
}