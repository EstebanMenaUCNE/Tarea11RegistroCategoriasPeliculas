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

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            DescripcionTextBox.Text = "";
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria(DescripcionTextBox.Text);
                var db = new PeliculasDb();
                db.Categorias.Add(categoria);
                db.SaveChanges();
                MessageBox.Show("Guardado con éxito!");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no disponible...");
        }
    }
}
