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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            NombreTextBox.Text = "";
            ClaveTextBox.Text = "";
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función no disponible...");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(NombreTextBox.Text, ClaveTextBox.Text);
                PeliculasDb db = new PeliculasDb();
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                MessageBox.Show("Guardado con éxito!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
