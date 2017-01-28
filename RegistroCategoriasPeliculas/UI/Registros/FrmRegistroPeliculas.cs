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
    public partial class FrmRegistroPeliculas : Form
    {
        public FrmRegistroPeliculas()
        {
            InitializeComponent();
        }

        private void FrmRegistroPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void CategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var categorias = new PeliculasDb().Categorias.ToList();
            if(categorias.Count > 0)
            {
                try
                {
                    CategoriaComboBox.DataSource = categorias;
                    CategoriaComboBox.DisplayMember = "Descripcion";
                    CategoriaComboBox.ValueMember = "CategoriaId";
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
                
            }*/
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula pelicula = new Pelicula(EstrenoDateTimePicker.Value, DescripcionTextBox.Text, new Categoria("Sin Categoria"));
                var db = new PeliculasDb();
                db.Peliculas.Add(pelicula);
                db.SaveChanges();
                MessageBox.Show("Guardado con éxito!");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            DescripcionTextBox.Text = "";
        }
    }
}
