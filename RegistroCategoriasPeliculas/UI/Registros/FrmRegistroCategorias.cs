using RegistroCategoriasPeliculas.BLL;
using RegistroCategoriasPeliculas.DAL;
using RegistroCategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCategoriasPeliculas.UI.Registros
{
    public partial class FrmRegistroCategorias : Form
    {
        public FrmRegistroCategorias()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            IdTextBox.Clear();
            DescripcionTextBox.Clear();
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(DescripcionTextBox.Text);
            if (!Validar())
            {
                MessageBox.Show("Hay campos vacios...");
            }
            else if (CategoriaBLL.Guardar(categoria))
            {
                MessageBox.Show("Guardado con éxito!");
            }
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Categoria categoria = CategoriaBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if(categoria != null)
                {
                    DescripcionTextBox.Text = categoria.Descripcion;
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Categoria categoria = CategoriaBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (categoria != null)
                {
                    if(CategoriaBLL.Eliminar(categoria))
                        MessageBox.Show("Eliminado con éxito!");
                }
                Limpiar();
            }
        }
        
        private void FrmRegistroCategorias_Load(object sender, EventArgs e)
        {

        }

        private void FrmRegistroCategorias_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
