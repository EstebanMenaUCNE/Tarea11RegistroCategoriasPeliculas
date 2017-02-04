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
    public partial class FrmRegistroPeliculas : Form
    {
        public FrmRegistroPeliculas()
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
            EstrenoDateTimePicker.Value = DateTime.Today;
        }

        public void LlenarCombo()
        {
            var db = new PeliculasDb();
            var lista = PeliculaBLL.GetList();
            if (lista.Count >= 0)
            {
                CategoriaComboBox.DataSource = lista;
                CategoriaComboBox.DisplayMember = "Categoria";
                CategoriaComboBox.ValueMember = "CategoriaId";
            }
        }

        private void FrmRegistroPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void CategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula(EstrenoDateTimePicker.Value, DescripcionTextBox.Text, new Categoria(CategoriaComboBox.SelectedValue.ToString()));
            if (!Validar())
            {
                MessageBox.Show("Hay campos vacios...");
            }
            else if (PeliculaBLL.Guardar(pelicula))
            {
                MessageBox.Show("Guardado con éxito!");
            }
            Limpiar();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            DescripcionTextBox.Focus();
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                Pelicula pelicula = PeliculaBLL.Buscar(Convert.ToInt32(IdTextBox.Text));
                if (pelicula != null)
                {
                    if (PeliculaBLL.Eliminar(pelicula))
                        MessageBox.Show("Eliminado con éxito!");
                }
                Limpiar();
            }
        }
    }
}
