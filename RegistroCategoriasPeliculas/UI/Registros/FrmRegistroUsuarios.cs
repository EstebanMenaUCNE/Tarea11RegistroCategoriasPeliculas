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
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text) || string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            NombreTextBox.Focus();
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Usuario usuario = UsuarioBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (usuario != null)
                {
                    if (UsuarioBLL.Eliminar(usuario))
                        MessageBox.Show("Eliminado con éxito!");
                }
                Limpiar();
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(NombreTextBox.Text, ClaveTextBox.Text);
            if (!Validar())
            {
                MessageBox.Show("Hay campos vacios...");
            }
            else if (UsuarioBLL.Guardar(usuario))
            {
                MessageBox.Show("Guardado con éxito!");
            }
            Limpiar();
        }

        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Usuario usuario = UsuarioBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (usuario != null)
                {
                    NombreTextBox.Text = usuario.Nombre;
                    ClaveTextBox.Text = usuario.Clave;
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }
    }
}
